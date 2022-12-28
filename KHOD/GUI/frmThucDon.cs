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
using KHOD.Bang;
namespace KHOD.GUI
{
    public partial class frmThucDon : DevExpress.XtraEditors.XtraForm
    {
        public frmThucDon()
        {
            InitializeComponent();
        }
		MyDB db =new MyDB();
        private void dateNavigator1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeOffsetEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
		DataSet dataset = null;
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void frmThucDon_Load(object sender, EventArgs e)
		{
			ThucDonF td = new ThucDonF();

			dataGridView1.DataSource = td.ListAll();

		}

		private void date2_EditValueChanged(object sender, EventArgs e)
		{
			
		}

		private void date2_ValueChanged(object sender, EventArgs e)
		{
			ThucDonF td = new ThucDonF();
			DateTime d1 = date1.Value;
			DateTime d2 = date2.Value;
			dataGridView1.DataSource = td.List(d1,d2);
		}

		private void date1_ValueChanged(object sender, EventArgs e)
		{
			ThucDonF td = new ThucDonF();
			DateTime d1 = date1.Value;
			DateTime d2 = date2.Value;
			dataGridView1.DataSource = td.List(d1, d2);
		}
	}
}