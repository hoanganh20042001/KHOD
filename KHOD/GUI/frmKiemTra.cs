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
using KHOD.Func;
using KHOD.report;
namespace KHOD.GUI
{
	public partial class frmKiemTra : DevExpress.XtraEditors.XtraForm
	{
		public frmKiemTra()
		{
			InitializeComponent();
		}

		private void panelControl1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void frmKiemTra_Load(object sender, EventArgs e)
		{
			KhoF kho = new KhoF();
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = kho.ListAll();
			
			//foreach (DataGridViewRow dgvr in dataGridView1.Rows)
			//{
			//	//if ((bool)dgvr.Cells["TrangThai"].Value)
			//	//{
			//		dgvr.DefaultCellStyle.BackColor = Color.Red;
			//	//}
			//}
			

		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				bool test = Convert.ToBoolean(row.Cells["Trangthai"].Value);
				if (test==false)
				{
					row.DefaultCellStyle.BackColor = Color.Red;
					row.DefaultCellStyle.ForeColor = Color.White;
				}
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int i = dataGridView1.CurrentRow.Index;
			lbMa.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
			lbten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
			lbSoLuongBD.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
		}

		private void lbMa_Click(object sender, EventArgs e)
		{

		}

		private void labelControl1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				KhoF kho = new KhoF();
				kho.KiemTra(int.Parse(lbMa.Text), int.Parse(txtSl.Text), txtLyDO.Text, 4);
				MessageBox.Show("Kiểm tra nguyên liệu  thành công");
				this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
				dataGridView1.DataSource = kho.ListAll();
			}
			catch {
				MessageBox.Show("Chưa nhập nguyên liệu cần kiểm tra.");
			}


		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			baoCaoNl bc = new baoCaoNl();
			bc.ShowDialog();

		}
	}
	
}
