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
using KHOD.DAO;
namespace KHOD.GUI
{
	public partial class frmDatNL : DevExpress.XtraEditors.XtraForm
	{
		public frmDatNL()
		{
			InitializeComponent();
		}
		MyDB db = new MyDB();
		private void frmDatNL_Load(object sender, EventArgs e)
		{
			
			ThanhPhanF tp = new ThanhPhanF();
			dataGridView1.DataSource = tp.ListAll();

			KhoiLuong kl = new KhoiLuong();
			dataGridView2.DataSource = kl.ListAll();
			var list = db.Database.SqlQuery<string>("select tenNcc from nha_cung_cap").ToList();
			foreach(var item in list)
			{
				comboBox1.Items.Add(item);
			}

		}

		private void date1_ValueChanged(object sender, EventArgs e)
		{
			ThanhPhanF tp = new ThanhPhanF();
			dataGridView1.DataSource = tp.ngay(date1.Value.Date);
			KhoF kho = new KhoF();
			dataGridView3.DataSource = kho.DuKien(date1.Value.Date);
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int i = dataGridView3.CurrentRow.Index;
			lbGia.Text = dataGridView3.Rows[i].Cells[3].Value.ToString();
			lbten.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
			txtSl.Text = dataGridView3.Rows[i].Cells[4].Value.ToString();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			KhoF kho = new KhoF();
			kho.DatNL(date1.Value.Date, 4, 0);
		}
	}
}