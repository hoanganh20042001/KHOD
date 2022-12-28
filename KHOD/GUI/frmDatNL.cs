using DevExpress.XtraEditors;
using KHOD.Func;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHOD.GUI
{
	public partial class frmDatNL : DevExpress.XtraEditors.XtraForm
	{
		public frmDatNL()
		{
			InitializeComponent();
		}

		private void frmDatNL_Load(object sender, EventArgs e)
		{

			ThanhPhanF tp = new ThanhPhanF();
			dataGridView1.DataSource = tp.ListAll();

			KhoiLuong kl = new KhoiLuong();
			dataGridView2.DataSource = kl.ListAll();

		}
	}
}