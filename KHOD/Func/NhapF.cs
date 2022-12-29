using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KHOD.DAO;

namespace KHOD.Func
{
	class NhapF
	{
		MyDB db = new MyDB();
		public string ThanhPhan { get; set; }
		public int MaTP { get; set; }
		public int MaDon { get; set; }
		public int MaLoai { get; set; }
		public double Gia { get; set; }
		public int SoLuong { get; set; }
		public string DonViTinh { get; set; }
		public List<NhapF> NhapNgay(DateTime ngay)
		{
			return db.Database.SqlQuery<NhapF>("select tp.matp,tenTp ThanhPhan,gia,soluong,donvitinh,d.Madon,MaLoai from dat_nl d join don_dat_nl don on don.madon=d.madon join thanh_phan tp on tp.matp=d.matp where ngaysd=@ngay", new SqlParameter("@ngay", ngay.Date)).ToList();
		}
	}
}
