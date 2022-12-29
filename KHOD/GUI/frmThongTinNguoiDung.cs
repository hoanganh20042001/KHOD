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
	public partial class frmThongTinNguoiDung : Form
	{
		public string str = @"Data Source=DESKTOP-CB0GE4G;Initial Catalog=KHO_D;Integrated Security=True";
		SqlConnection connection;
		SqlCommand command;
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();
		public void loaddata()
		{
			command = connection.CreateCommand();
			command.CommandText = "select * from NHAN_VIEN where MaNV = '"+frmLogin.ID_NHANVIEN +"'";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
		}
		public void values()
		{
			guna2HtmlLabel3.Text = frmLogin.ID_NHANVIEN;
			guna2HtmlLabel4.Text = tennv(frmLogin.ID_NHANVIEN);
			guna2HtmlLabel18.Text = ngaysinh;
			guna2HtmlLabel17.Text = diachi;
			guna2HtmlLabel16.Text = sdt;
			guna2HtmlLabel15.Text = chucvu;
			guna2HtmlLabel6.Text = quanham;
			guna2HtmlLabel5.Text = tenbophan(mabp);
			guna2HtmlLabel19.Text = taikhoan;
		}
		public frmThongTinNguoiDung()
		{
			InitializeComponent();
		}

		private void frmThongTinNguoiDung_Load(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
			connection.Open();
			loaddata();
			values();
		}
		string ngaysinh, diachi, sdt, chucvu, quanham, taikhoan, matkhau, ngaycn;

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			frmChangePass frm = new frmChangePass();
			frm.Show();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			frmThongTinNguoiDung_Sua frm = new frmThongTinNguoiDung_Sua();
			frm.TopLevel = false;
			panel1.Controls.Add(frm);
			frm.BringToFront();
			frm.Show();
		}

		int mabp;
		
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
