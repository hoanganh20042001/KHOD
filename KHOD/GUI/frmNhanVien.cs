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
	public partial class frmNhanVien : Form
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
			guna2DataGridView1.DataSource = table;
		}
		public frmNhanVien()
		{
			InitializeComponent();
		}

		private void frmNhanVien_Load(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
			connection.Open();
			loaddata();
		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int i;
			i = guna2DataGridView1.CurrentRow.Index;

			guna2DateTimePicker1.Text = guna2DataGridView1.Rows[i].Cells[2].Value.ToString();
			guna2DateTimePicker2.Text = guna2DataGridView1.Rows[i].Cells[10].Value.ToString();
			guna2TextBox1.Text = guna2DataGridView1.Rows[i].Cells[0].Value.ToString();
			guna2TextBox2.Text = guna2DataGridView1.Rows[i].Cells[1].Value.ToString();
			guna2TextBox3.Text = guna2DataGridView1.Rows[i].Cells[3].Value.ToString();
			guna2TextBox4.Text = guna2DataGridView1.Rows[i].Cells[4].Value.ToString();
			guna2TextBox5.Text = guna2DataGridView1.Rows[i].Cells[7].Value.ToString();
			guna2TextBox6.Text = guna2DataGridView1.Rows[i].Cells[6].Value.ToString();
			guna2TextBox8.Text = guna2DataGridView1.Rows[i].Cells[11].Value.ToString();
			guna2TextBox9.Text = guna2DataGridView1.Rows[i].Cells[12].Value.ToString();
			guna2TextBox13.Text = guna2DataGridView1.Rows[i].Cells[8].Value.ToString();
			guna2TextBox12.Text = guna2DataGridView1.Rows[i].Cells[9].Value.ToString();
			guna2TextBox11.Text = guna2DataGridView1.Rows[i].Cells[5].Value.ToString();

			if (guna2DataGridView1.Rows[i].Cells[13].Value.ToString()== "True")
			{
				comboBox1.Text = "Hoạt động";
			}
			else
			{
				comboBox1.Text = "Ngừng hoạt động";
			}


		}

		private void guna2Button4_Click(object sender, EventArgs e)
		{
			command = connection.CreateCommand();
			int value;
			if (comboBox1.Text == "Ngừng hoạt động")
			{
				value = 0;
			}
			else
			{
				value = 1;
			}
			DateTime dat = guna2DateTimePicker1.Value.Date;
			string datS = dat.ToString("yyyy-MM-dd");
			DateTime dat2 = guna2DateTimePicker2.Value.Date;
			string datS2 = dat.ToString("yyyy-MM-dd");
			command.CommandText = "update NHAN_VIEN set TenNV = '"+guna2TextBox2.Text+"', Ngaysinh = '"+datS+ "', DiaChi = '"+ guna2TextBox3.Text
				+"',SDT = '"+ Decimal.Parse(guna2TextBox4.Text) + "', GhiChu = '"+ guna2TextBox11.Text + "', ChucVu = '"+ guna2TextBox6.Text + "', QuanHam = '"+ guna2TextBox5.Text
				+ "',TaiKhoan = '"+ guna2TextBox13.Text + "',MatKhau = '"+ guna2TextBox12.Text + "',NgayCN= '"+ datS2 + "',MaBP= '"+ Convert.ToInt32(guna2TextBox8.Text)
				+ "',MaPQ= '"+ Convert.ToInt32(guna2TextBox9.Text) + "',TrangThai= '"+ Convert.ToInt32(value) + "'";
			command.ExecuteNonQuery();
			loaddata();
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{

			command = connection.CreateCommand();
			command.CommandText = "Delete from NHAN_VIEN where MaNV = '"+ guna2TextBox1.Text + "'";
			command.ExecuteNonQuery();
			loaddata();
		}
	}
}
