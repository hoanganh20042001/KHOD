using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KHOD.DAO;
using KHOD.Bang;
namespace KHOD.Func
{
	class ThucDonF
	{
		MyDB db = new MyDB();
		private int Buoi;
		private DateTime Ngay;
		private int QuanSo;
		private string MonAn;
		public DataSet1 ds;
		public ThucDonF()
		{
			

		}
		public void ListAll()
		{
			List<ThucDonF> list = new List<ThucDonF>();
			
			var MaTT = db.Database.SqlQuery<int>("select matt from Thong_tin").ToList();
			foreach( var item in MaTT)
			{
				ThucDonF TT = new ThucDonF();
				TT.Ngay = db.Database.SqlQuery<DateTime>("select Ngay from Thong_tin where matt=@matt", new SqlParameter("@matt", item)).SingleOrDefault();
				TT.Buoi= db.Database.SqlQuery<int>("select buoi from Thong_tin where matt=@matt", new SqlParameter("@matt", item)).SingleOrDefault();
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
				ds.ThucDon.Rows.Add(new object[] {TT.Ngay,TT.Buoi,TT.QuanSo,TT.MonAn });
			}

			
		}
	}
}
