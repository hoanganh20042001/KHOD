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
		public DateTime Ngay { get; set; }
		public string ThanhPhan { get; set; }
		public int maTP { get; set; }
		public double DinhLuong { get; set; }
		public ThanhPhanF()
		{

		}
		public List<ThanhPhanF> ListAll()
		{
			List<ThanhPhanF> list = new List<ThanhPhanF>();
			
			list = db.Database.SqlQuery<ThanhPhanF>("select tp.matp,tentp as ThanhPhan ,ngay,sum(DinhLuong*quanso) as DinhLuong from mon_an ma join ds_ma ds on ds.mama=ma.mama join ds_tp on ds_tp.MaMA=ma.mama join THANH_PHAN tp on tp.matp=ds_tp.MaTP join THONG_TIN tt on tt.matt=ds.matt group by tp.matp,tentp, ngay").ToList();
			return list;

		}
		public List<ThanhPhanF> ngay(DateTime d)
		{

			List<ThanhPhanF> list = new List<ThanhPhanF>();

			list = db.Database.SqlQuery<ThanhPhanF>("select tp.matp,tentp as ThanhPhan ,ngay,sum(DinhLuong*quanso) as DinhLuong from mon_an ma join ds_ma ds on ds.mama=ma.mama join ds_tp on ds_tp.MaMA=ma.mama join THANH_PHAN tp on tp.matp=ds_tp.MaTP join THONG_TIN tt on tt.matt=ds.matt where ngay=@ngay group by tp.matp,tentp, ngay", new SqlParameter("@ngay", d)).ToList();
			return list;
		}
		
	}
}
