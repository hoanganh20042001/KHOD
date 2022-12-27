using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHOD.GUI
{
	public partial class frmNhanVien_Themmoi : Form
	{
		SqlConnection connection;
		SqlCommand command;
		string str = @"Data Source=LINH-CHI;Initial Catalog=KHO_D;Integrated Security=True";

		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();
		void loaddata()
		{
			command = connection.CreateCommand();
			command.CommandText = "select * from NHAN_VIEN";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
		}
		public frmNhanVien_Themmoi()
		{
			InitializeComponent();
		}

		private void guna2Button4_Click(object sender, EventArgs e)
		{
			int value;
			if (comboBox1.Text == "Ngừng hoạt động")
			{
				value = 0;
			}
			else
			{
				value = 1;
			}
			command = connection.CreateCommand();
			DateTime dat = guna2DateTimePicker1.Value.Date;
			string datS = dat.ToString("yyyy-MM-dd");
			DateTime dat2 = guna2DateTimePicker2.Value.Date;
			string datS2 = dat.ToString("yyyy-MM-dd");
			command.CommandText = "insert into NHAN_VIEN (TenNV, NgaySinh, DiaChi,SDT, GhiChu, ChucVu, QuanHam,TaiKhoan,MatKhau,NgayCN,MaBP,MaPQ,TrangThai) values ('"+ guna2TextBox2.Text 
				+ "', '"+ datS+ "', '" + guna2TextBox3.Text + "','" + Decimal.Parse(guna2TextBox4.Text) + "','" + guna2TextBox11.Text + "','" + guna2TextBox6.Text + "','" 
				+ guna2TextBox5.Text + "','" + guna2TextBox13.Text + "','" + guna2TextBox12.Text + "','" + datS2 + "','" + Convert.ToInt32(guna2TextBox8.Text) + "','" 
				+ Convert.ToInt32(guna2TextBox9.Text) + "','" + Convert.ToInt32(value) + "')";
			command.ExecuteNonQuery();
			this.Close();
			frmNhanVien reloadnv = new frmNhanVien();
			reloadnv.Show();
		}

		private void frmNhanVien_Themmoi_Load(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
			connection.Open();
			loaddata();
		}

		private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
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

		private void guna2TextBox8_KeyPress(object sender, KeyPressEventArgs e)
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

		private void guna2TextBox9_KeyPress(object sender, KeyPressEventArgs e)
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
	}
}
