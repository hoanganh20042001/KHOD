using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KHOD.DAO;
namespace KHOD.Func
{
	class ThanhPhanF
	{
		MyDB db = new MyDB();
		//public string Buoi { get; set; }
		public DateTime NgayD { get; set; }
		public string ThanhPhan { get; set; }
		public int maTP { get; set; }
		public double Gia { get; set; }
		public int MaLoai { get; set; }
		public double DinhLuong { get; set; }
		public ThanhPhanF()
		{

		}
		public List<ThanhPhanF> ListAll()
		{
			List<ThanhPhanF> list = new List<ThanhPhanF>();
			
			list = db.Database.SqlQuery<ThanhPhanF>("select ngay,tp.matp,tentp as ThanhPhan ,sum(DinhLuong*quanso) as DinhLuong,tp.maloai,gia from mon_an ma join ds_ma ds on ds.mama=ma.mama join ds_tp on ds_tp.MaMA=ma.mama join THANH_PHAN tp on tp.matp=ds_tp.MaTP join THONG_TIN tt on tt.matt=ds.matt join loainl on loainl.maloai=tp.maloai group by tp.matp,tentp, ngay,tp.maloai,gia").ToList();
			return list;

		}
		public List<ThanhPhanF> ListNgay(DateTime d)
		{
			var List = db.Database.SqlQuery<ThanhPhanF>("select ngay ngayd,tp.matp,tentp as ThanhPhan ,sum(DinhLuong*quanso) as DinhLuong,tp.maloai,gia from mon_an ma join ds_ma ds on ds.mama=ma.mama join ds_tp on ds_tp.MaMA=ma.mama join THANH_PHAN tp on tp.matp=ds_tp.MaTP join THONG_TIN tt on tt.matt=ds.matt join loainl on loainl.maloai=tp.maloai where ngay=@ngay  group by ngay,tp.matp,tentp,tp.maloai,gia order by ngay", new SqlParameter("@ngay", d.Date)).ToList();
			return List;
		}
		public List<ThanhPhanF> ngay(DateTime d1, DateTime d2)
		{

			List<ThanhPhanF> List = new List<ThanhPhanF>();//lay cac nguyen lieu ngan han trong tuan
			List= db.Database.SqlQuery<ThanhPhanF>("select ngay ngayd,tp.matp,tentp as ThanhPhan ,sum(DinhLuong*quanso) as DinhLuong,tp.maloai,gia from mon_an ma join ds_ma ds on ds.mama=ma.mama join ds_tp on ds_tp.MaMA=ma.mama join THANH_PHAN tp on tp.matp=ds_tp.MaTP join THONG_TIN tt on tt.matt=ds.matt join loainl on loainl.maloai=tp.maloai where ngay>=@d1 and ngay<=@d2 and tp.maloai=0 group by ngay,tp.matp,tentp,tp.maloai,gia order by ngay", new SqlParameter("@d1", d1.Date), new SqlParameter("@d2", d2.Date)).ToList();
			


				var nldh = db.Database.SqlQuery<NlDaiHan>("select tp.matp,tentp as ThanhPhan ,sum(DinhLuong*quanso) as DinhLuong,tp.maloai,gia from mon_an ma join ds_ma ds on ds.mama=ma.mama join ds_tp on ds_tp.MaMA=ma.mama join THANH_PHAN tp on tp.matp=ds_tp.MaTP join THONG_TIN tt on tt.matt=ds.matt join loainl on loainl.maloai=tp.maloai where ngay>=@d1 and ngay<=@d2 and tp.maloai=1 group by tp.matp,tentp,tp.maloai,gia", new SqlParameter("@d1", d1.Date), new SqlParameter("@d2", d2.Date)).ToList();
			foreach(var item in nldh)
			{
				ThanhPhanF tp = new ThanhPhanF();
				tp.DinhLuong = item.DinhLuong;
				tp.Gia = item.Gia;
				tp.MaLoai = item.MaLoai;
				tp.maTP = item.maTP;
				tp.ThanhPhan = item.ThanhPhan;
				tp.NgayD= d1.Date;
				
				List.Add(tp);
				
			}
			var list= List.OrderBy(x => x.NgayD).ToList();
			return list;
		}
		
	}
}
