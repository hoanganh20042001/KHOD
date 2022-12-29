using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KHOD.DAO;
namespace KHOD.report
{
	public partial class baoCaoNl : DevExpress.XtraEditors.XtraForm
	{
		MyDB db = new MyDB();
		public baoCaoNl()
		{
			InitializeComponent();
		}

		private void labelControl1_Click(object sender, EventArgs e)
		{

		}

		private void baoCaoNl_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = db.Database.SqlQuery<NLhong>("select tentp nguyenlieu, lb.soluong, donvitinh, lydo, gia from THANH_PHAN tp join NGUYEN_LIEU nl on nl.Matp = tp.matp join KIEM_TRA kt on kt.Manl = nl.manl join DS_LOAI_BO_NL lb on lb.MaLB = kt.MaLB ").ToList();
			
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			MA ma = new MA();
			dataGridView1.DataSource= ma.getNLhong(dateTimePicker1.Value);
			ma.Show(dateTimePicker1.Value);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			

		}
	}
}