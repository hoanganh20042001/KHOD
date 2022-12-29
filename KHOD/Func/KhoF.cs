using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KHOD.DAO;
using System.Data.SqlClient;

namespace KHOD.Func
{
	class KhoF
	{
		MyDB db = new MyDB();
		public int MaNL { get; set; }
		public string NguyenLieu { get; set; }
		public DateTime NSX { get; set; }
		public DateTime HSD { get; set; }
		public double Gia { get; set; }
		public int SoLuong { set; get; }
		public bool TrangThai { get; set; }
		public List<KhoF> ListAll()
		{
			List<KhoF> kho = new List<KhoF>();
			kho = db.Database.SqlQuery<KhoF>("select manl,tp.tentp nguyenlieu, ngaysanxuat nsx, hansudung hsd,Gia,soluong,trangthai from thanh_phan tp join nguyen_lieu nl on tp.matp=nl.matp where soluong>0 ").ToList();
			//var kq = from nl in db.NGUYEN_LIEU
			//		 join tp in db.THANH_PHAN on nl.MaTP equals tp.MaTP where SoLuong>0
			//		 select new {
			//			 MaNL=nl.MaNL,
			//			 NguyenLieu = tp.tenTP,
			//			 NSX = nl.NgaySanXuat,
			//			 HSD = nl.HanSuDung,
			//			 Gia = nl.DonGia,
			//			 SoLuong = nl.SoLuong,
			//			 TrangThai = nl.TrangThai
			//		 };
			//foreach(var item in kq)
			//{
			//	KhoF k = new KhoF();
			//	k.MaNL = item.MaNL;
			//	k.NguyenLieu = item.NguyenLieu;
			//	k.NSX = item.NSX;
			//	k.HSD = item.HSD;
			//	k.Gia = item.Gia;
			//	k.SoLuong = item.SoLuong;
			//	k.TrangThai = item.TrangThai;
			//	kho.Add(k);
			//}
			return kho;
		}

		public void TuDong()
		{
			if (DateTime.Now.Hour <= 7 || (14 <= DateTime.Now.Hour && DateTime.Now.Hour <= 15))
			{
				foreach (var item in ListAll())
				{
					var result = db.NGUYEN_LIEU.Find(item.MaNL);
					result.TrangThai = false;
					db.SaveChanges();
				}
			}

		}
		public void KiemTra(int manl, int soLuongLoaiBo, string LyDo, int MaNV)
		{
			var result = db.NGUYEN_LIEU.Find(manl);
			KIEM_TRA kiemtra = new KIEM_TRA();
			kiemtra.MaNV = MaNV;
			kiemtra.MaNL = manl;
			if (soLuongLoaiBo < result.SoLuong)
			{
				result.SoLuong = result.SoLuong - soLuongLoaiBo;
				DS_LOAI_BO_NL lb = new DS_LOAI_BO_NL();
				lb.LyDo = LyDo;
				lb.SoLuong = soLuongLoaiBo;
				db.DS_LOAI_BO_NL.Add(lb);

				kiemtra.MaLB = lb.MaLB;

			}
			DateTime T = DateTime.Now;
			kiemtra.ThoiGian = T;
			kiemtra.MaNV = MaNV;
			db.KIEM_TRA.Add(kiemtra);

			result.TrangThai = true;
			db.SaveChanges();

		}
		public void XuatKho()
		{

		}
		public List<ThanhPhanF> DuKien(DateTime d1, DateTime d2)
		{
			List<ThanhPhanF> list = new List<ThanhPhanF>();
			ThanhPhanF tp = new ThanhPhanF();
			KhoiLuong kho = new KhoiLuong();
			List<ThanhPhanF> List = tp.ngay(d1, d2);
			foreach (var item in List)// lay ra nguyen lieu CAN MUA
			{
				ThanhPhanF dat = new ThanhPhanF();
				KhoiLuong khoiluong = kho.getNL(item.maTP);//lay ra nguyen lieu trong kho
				if (khoiluong != null)
				{
					if (item.DinhLuong > khoiluong.SoLuong)
					{

						dat.DinhLuong = (int)item.DinhLuong - khoiluong.SoLuong;
					}
					else
					{
						dat.DinhLuong = khoiluong.SoLuong - (int)item.DinhLuong;
					}
					if (dat.DinhLuong != 0)
					{
						dat.maTP = khoiluong.MaTP;
						dat.ThanhPhan = khoiluong.ThanhPhan;
						dat.Gia = khoiluong.Gia;
						dat.MaLoai = khoiluong.MaLoai;
						dat.NgayD = d1;
					}

				}
				else
				{

					dat.DinhLuong = (int)item.DinhLuong;
					dat.maTP = item.maTP;
					dat.ThanhPhan = item.ThanhPhan;
					dat.Gia = item.Gia;
					dat.MaLoai = item.MaLoai;
					dat.NgayD = item.NgayD;
				}
				if (dat.DinhLuong != 0)
				{
					list.Add(dat);
				}

			}
			return list;

		}
		public void DatNL(DateTime d1, DateTime d2, int manv, int mancc)
		{
			ThanhPhanF tp = new ThanhPhanF();
			List<ThanhPhanF> List = DuKien(d1, d2);

			KhoiLuong kho = new KhoiLuong();

			DateTime d = d1;
			for (int i = 1; i <= 7; i++)
			{
				DON_DAT_NL don = new DON_DAT_NL();
				don.NgayLap = DateTime.Now.Date;
				don.NgaySD = d.Date;
				don.MaNCC = mancc;
				don.MaNV = manv;
				db.DON_DAT_NL.Add(don);
				db.SaveChanges();
				foreach (var item in List)
				{
					if (item.NgayD.Date == d.Date)
					{
						DAT_NL dat = new DAT_NL();
						dat.MaTP = item.maTP;
						dat.MaDon = don.MaDON;
						dat.SoLuong = (int)item.DinhLuong;
						dat.DonGia = item.Gia;
						db.DAT_NL.Add(dat);

					}
				}

				d = d.AddDays(1);
			}



			db.SaveChanges();




		}

	}
}
