using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KHOD.DAO;
using KHOD.Func;
namespace KHOD.GUI
{
	public partial class frmListNL : DevExpress.XtraEditors.XtraForm
	{
		public frmListNL()
		{
			InitializeComponent();
		}
		MyDB db = new MyDB();

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void frmListNL_Load(object sender, EventArgs e)
		{
			ThanhPhanF tp = new ThanhPhanF();
			dataGridView1.DataSource = tp.ListAll();
		}
	}
}