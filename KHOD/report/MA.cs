using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using KHOD.DAO;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace KHOD.report
{
	class MA
	{

		
		public re Ds;
		public rep rep;
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
		public bool Nhap()
		{
			var list = db.MON_AN.ToList();
			foreach(var item in list)
			{
				string mama = item.MaMA.ToString();
				string tenma = item.TeMA.ToString();
				Ds.MA.Rows.Add(new object[] { mama,tenma});
			}
			return true;
		}
		public void Show()
		{
			rep.DataSource = Ds;
			rep.DataMember = Ds.MA.TableName;
			Nhap();
			ReportPrintTool viewRP = new ReportPrintTool(rep);



			
			viewRP.ShowPreviewDialog();
		}

	}
}
