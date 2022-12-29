using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KHOD.DAO;
using System.Data.SqlClient;

namespace KHOD.Func
{
	class KhoiLuong
	{
		MyDB db = new MyDB();
		public string ThanhPhan { get; set; }
		//public DateTime Ngay { get; set; }
		public int MaTP { get; set; }
		public int MaLoai { get; set; }
		public double Gia { get; set; }
		public int SoLuong { get; set; }
		public List<KhoiLuong> ListAll (){
			return db.Database.SqlQuery<KhoiLuong>("select tp.matp, tentp ThanhPhan,tp.maloai,gia,sum(soluong) SoLuong from thanh_phan tp join nguyen_lieu nl on nl.matp=tp.matp join loainl on tp.maloai=loainl.maloai where soluong>0 group by tp.matp,tentp,gia,tp.maloai").ToList();
		}
		public KhoiLuong getNL(int MaTP)
		{
			return db.Database.SqlQuery<KhoiLuong>("select tp.matp, tentp ThanhPhan,tp.maloai,gia,sum(soluong) SoLuong from thanh_phan tp join nguyen_lieu nl on nl.matp=tp.matp join loainl on tp.maloai=loainl.maloai where soluong>0 and tp.matp=@matp group by tp.matp,tentp,gia,tp.maloai", new SqlParameter("@matp", MaTP)).SingleOrDefault();
		}
		//public List<KhoiLuong> DuKien()
		//{

		//}
	}
}
