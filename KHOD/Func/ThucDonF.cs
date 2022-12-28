using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KHOD.DAO;
using KHOD.Bang;
using KHOD.GUI;
using System.Windows.Forms;

namespace KHOD.Func
{
	class ThucDonF
	{
		MyDB db = new MyDB();
		public DateTime Ngay { get; set; }
		public string Buoi { get; set; }

		public int QuanSo { get; set; }
		public string MonAn { get; set; }
		
		public ThucDonF()
		{
			

		}
		public List<ThucDonF> ListAll()
		{
			List<ThucDonF> list = new List<ThucDonF>();
			
			var MaTT = db.Database.SqlQuery<int>("select matt from Thong_tin").ToList();
			int STT = 0;
			foreach( var item in MaTT)
			{
				STT = STT + 1;
				ThucDonF TT = new ThucDonF();
				TT.Ngay = db.Database.SqlQuery<DateTime>("select Ngay from Thong_tin where matt=@matt", new SqlParameter("@matt", item)).SingleOrDefault();
				TT.Buoi= db.Database.SqlQuery<string>("select buoi from Thong_tin where matt=@matt", new SqlParameter("@matt", item)).SingleOrDefault();
			
				TT.QuanSo= db.Database.SqlQuery<int>("select quanso from Thong_tin where matt=@matt", new SqlParameter("@matt", item)).SingleOrDefault();
				var listMA = db.Database.SqlQuery<string>("select tenma from DS_MA join Mon_an on ds_ma.mama=mon_an.mama where matt=@matt", new SqlParameter("@matt", item)).ToList();
				foreach(var i in listMA)
				{
					if (TT.MonAn == null)
					{
						TT.MonAn = i;
					}
					else
						TT.MonAn = TT.MonAn + " , " + i;
				}
				list.Add(TT);
				
			}
			return list;
			
		}
		public List<ThucDonF> List(DateTime d1, DateTime d2)
		{
			List<ThucDonF> newList = new List<ThucDonF>();
			if (d2 < d1) return newList;
			else
			{
				var MaTT = db.Database.SqlQuery<int>("select matt from Thong_tin where ngay>=@d1 and ngay<=@d2", new SqlParameter("@d1",d1), new SqlParameter("@d2", d2)).ToList();
				int STT = 0;
				foreach (var item in MaTT)
				{
					STT = STT + 1;
					ThucDonF TT = new ThucDonF();
					TT.Ngay = db.Database.SqlQuery<DateTime>("select Ngay from Thong_tin where matt=@matt", new SqlParameter("@matt", item)).SingleOrDefault();
					TT.Buoi = db.Database.SqlQuery<string>("select buoi from Thong_tin where matt=@matt", new SqlParameter("@matt", item)).SingleOrDefault();

					TT.QuanSo = db.Database.SqlQuery<int>("select quanso from Thong_tin where matt=@matt", new SqlParameter("@matt", item)).SingleOrDefault();
					var listMA = db.Database.SqlQuery<string>("select tenma from DS_MA join Mon_an on ds_ma.mama=mon_an.mama where matt=@matt", new SqlParameter("@matt", item)).ToList();
					foreach (var i in listMA)
					{
						if (TT.MonAn == null)
						{
							TT.MonAn = i;
						}
						else
							TT.MonAn = TT.MonAn + " , " + i;
					}
					newList.Add(TT);

				}
				return newList;
			}
		}
		
	}
}
