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
	public partial class frmThongTinNguoiDung_Sua : Form
	{
		public string str = @"Data Source=DESKTOP-CB0GE4G;Initial Catalog=KHO_D;Integrated Security=True";
		SqlConnection connection;
		SqlCommand command;
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();
		void loaddata()
		{
			command = connection.CreateCommand();
			command.CommandText = "select * from NHAN_VIEN where MaNV = '" + frmLogin.ID_NHANVIEN + "'";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
		}
		void values()
		{
			guna2HtmlLabel3.Text = frmLogin.ID_NHANVIEN;
			guna2TextBox1.Text = tennv(frmLogin.ID_NHANVIEN);
			guna2DateTimePicker1.Text = ngaysinh;
			guna2TextBox2.Text = diachi;
			guna2TextBox3.Text = sdt;
			guna2TextBox4.Text = chucvu;
			guna2TextBox5.Text = quanham;
			guna2HtmlLabel5.Text = tenbophan(mabp);
			guna2TextBox6.Text = taikhoan;
		}
		public frmThongTinNguoiDung_Sua()
		{
			InitializeComponent();
		}

		string ngaysinh, diachi, sdt, chucvu, quanham, taikhoan, matkhau, ngaycn;

		private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
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

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			DateTime dat = guna2DateTimePicker1.Value.Date;
			string datS = dat.ToString("yyyy-MM-dd");
			command.CommandText = "update NHAN_VIEN set TenNV = '" + guna2TextBox1.Text + "', Ngaysinh = '" + datS + "', DiaChi = '" + guna2TextBox2.Text
				+ "',SDT = '" + Decimal.Parse(guna2TextBox3.Text) + "', ChucVu = '" + guna2TextBox4.Text + "', QuanHam = '" + guna2TextBox5.Text
				+ "',TaiKhoan = '" + guna2TextBox6.Text + "' where MaNV = '"+ guna2HtmlLabel3.Text + "'";
			command.ExecuteNonQuery();
			loaddata();
			this.Hide();
			frmThongTinNguoiDung frm = new frmThongTinNguoiDung();
			frm.TopLevel = false;
			panel1.Controls.Add(frm);
			frm.BringToFront();
			frm.Show();
		}

		int mabp;
		private void frmThongTinNguoiDung_Sua_Load_1(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
			connection.Open();
			loaddata();
			values();
		}

		private string tennv(string id_user)
		{
			string ten = "";
			SqlDataAdapter da = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			da.Fill(dt);
			if (dt != null)
			{
				foreach (DataRow dr in dt.Rows)
				{
					if (dr["MaNV"].ToString() == frmLogin.ID_NHANVIEN)
					{
						ten = dr["tenNV"].ToString();
						ngaysinh = dr["NgaySinh"].ToString();
						diachi = dr["DiaChi"].ToString();
						sdt = dr["SDT"].ToString();
						chucvu = dr["ChucVu"].ToString();
						quanham = dr["QuanHam"].ToString();
						taikhoan = dr["TaiKhoan"].ToString();
						ngaycn = dr["NgayCN"].ToString();
						mabp = Convert.ToInt32(dr["MaBP"]);
					}
				}
			}
			return ten;
		}

		private string tenbophan(int id_bp)
		{
			string tenbp = "";
			command.CommandText = "select * from BO_PHAN where MaBP = '" + id_bp + "'";
			SqlDataAdapter da = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			da.Fill(dt);
			if (dt != null)
			{
				foreach (DataRow dr in dt.Rows)
				{
					if (Convert.ToInt32(dr["MaBP"]) == id_bp)
					{
						tenbp = dr["tenBP"].ToString();

					}
				}
			}
			return tenbp;
		}
	}
}
