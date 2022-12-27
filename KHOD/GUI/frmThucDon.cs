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
    public partial class frmThucDon : DevExpress.XtraEditors.XtraForm
    {
        public frmThucDon()
        {
            InitializeComponent();
        }

        private void dateNavigator1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeOffsetEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void frmThucDon_Load(object sender, EventArgs e)
		{
			ThucDonF td = new ThucDonF();
			DataSet ds = new DataSet();
			//DataTable dt = new DataTable();
			//dataGridView1.DataSource = null;
			//dataGridView1.DataSource = td.ListAll();
			//dataGridView2.DataSource = null;
			//dataGridView2.DataSource = td.ListAll();
			//DataTable dt = (DataTable)dataGridView1.DataSource;

			//dataGridView1.Refresh();
			////for(int i = 0; i < dataGridView1.Rows.Count; i++)
			////{
			//	dataGridView1.Rows[i].Cells[1]=td.ListAll().
			//}
		}
	}
}