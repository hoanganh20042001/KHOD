using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using KHOD.DAO;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using KHOD.DAO;
using System.Data.SqlClient;
namespace KHOD.report
{
	class MA
	{

		
		public re Ds { get; set; }
		public rep rep { get; set; }
		public MA()
		{

			this.Ds = new re();
			this.rep = new rep();
		}
		MyDB db = new MyDB();
		public DataTable getMA()
		{
			DataTable tb = new DataTable();
			var list = db.MON_AN.ToList();
			DataSet ds = new DataSet();
			tb.Rows.Add(list);
			return tb;

		}
		public void setNLhong(DateTime d)
		{
			/*var list = db.MON_AN.ToList();
			foreach(var item in list)
			{
				string mama = item.MaMA.ToString();
				string tenma = item.TenMA.ToString();
				Ds.MA.Rows.Add(new object[] { mama,tenma});
			}
			*/
			
			int Stt = 0;
			DateTime d1 = d.AddDays(1);
			var list = db.Database.SqlQuery<NLhong>("select tentp nguyenlieu, lb.soluong, donvitinh, lydo, gia from THANH_PHAN tp join NGUYEN_LIEU nl on nl.Matp = tp.matp join KIEM_TRA kt on kt.Manl = nl.manl join DS_LOAI_BO_NL lb on lb.MaLB = kt.MaLB where ThoiGian >= @d and thoigian < @d1 ", new SqlParameter("@d", d.Date), new SqlParameter("@d1", d1.Date)).ToList();
			foreach(var item in list)
			{
				Stt = Stt + 1;
				string tien = item.gia + "vnd";
				string soluong = item.soluong + " " + item.Donvitinh;
				Ds.NLhong.Rows.Add(new object[] {
					Stt,item.NguyenLieu,soluong,item.lydo,tien
				});
			}

		}
		public List<NLhong> getNLhong(DateTime d)
		{

			
			DateTime d1 = d.AddDays(1);
			
			var list = db.Database.SqlQuery<NLhong>("select tentp nguyenlieu, lb.soluong, donvitinh, lydo, gia from THANH_PHAN tp join NGUYEN_LIEU nl on nl.Matp = tp.matp join KIEM_TRA kt on kt.Manl = nl.manl join DS_LOAI_BO_NL lb on lb.MaLB = kt.MaLB where ThoiGian >= @d and thoigian < @d1 ", new SqlParameter("@d", d.Date), new SqlParameter("@d1", d1.Date)).ToList();

			return list;
		}
		public void Show(DateTime d)
		{
			rep.DataSource = Ds;
			rep.DataMember = Ds.NLhong.TableName;
			baoCaoNl bc = new baoCaoNl();
		
			setNLhong(d.Date);
			ReportPrintTool viewRP = new ReportPrintTool(rep);
			rep.lbTG.Text = d.Date.ToString().Substring(0, 10);


			
			viewRP.ShowPreviewDialog();
		}

	}
}
