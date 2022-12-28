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
		public int MaTP { get; set; }
		public int SoLuong { get; set; }
		public List<KhoiLuong> ListAll (){
			return db.Database.SqlQuery<KhoiLuong>("select tp.matp, tentp ThanhPhan,sum(soluong) SoLuong from thanh_phan tp join nguyen_lieu nl on nl.matp=tp.matp where soluong>0 group by tp.matp,tentp").ToList();
		}
		public KhoiLuong getNL(int MaTP)
		{
			return db.Database.SqlQuery<KhoiLuong>("select tp.matp, tentp ThanhPhan,sum(soluong) SoLuong from thanh_phan tp join nguyen_lieu nl on nl.matp=tp.matp where soluong>0 and matp=@matp group by tp.matp,tentp", new SqlParameter("@matp", MaTP)).SingleOrDefault();
		}
		//public List<KhoiLuong> DuKien()
		//{

		//}
	}
}
