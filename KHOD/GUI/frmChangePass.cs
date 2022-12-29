using DevExpress.XtraEditors;
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
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
		public string str = @"Data Source=LINH-CHI;Initial Catalog=KHO_D;Integrated Security=True";
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
		public frmChangePass()
        {
            InitializeComponent();
			txtMKMoi.PasswordChar = '*';
			txtMKCu.PasswordChar = '*';
			txtNhapLaiMK.PasswordChar = '*';
		}
		void values()
		{
			txtUser.Text = tennv(frmLogin.ID_NHANVIEN);
			
		}
		private void frmChangePass_Load(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
			connection.Open();
			loaddata();
			values();
		}
		string matkhau, ghichu;

		private void btnThayDoi_Click(object sender, EventArgs e)
		{
			if (txtMKCu.Text == matkhau && txtMKMoi.Text == txtNhapLaiMK.Text && txtMKMoi.Text != txtMKCu.Text)
			{
				command.CommandText = "update NHAN_VIEN set MatKhau = '" + txtMKMoi.Text + "', GhiChu = '" + txtTTCT.Text + "' where MaNV = '" + frmLogin.ID_NHANVIEN + "'";
				command.ExecuteNonQuery();
			}
			else if (txtMKCu.Text != matkhau)
			{
				MessageBox.Show("Mật khẩu cũ nhập chưa đúng");
			}
			else if (txtMKCu.Text == txtMKMoi.Text)
			{
				MessageBox.Show("Hãy nhập mật khẩu mới khác với mật khẩu bạn đã dùng!");
			}
			else
			{
				MessageBox.Show("Không thành công, hãy kiếm tra lại các trường của bạn!");
			}
			loaddata();
			this.Hide();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
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
						ten = dr["TenNV"].ToString();
						matkhau = dr["MatKhau"].ToString();
					}
				}
			}
			return ten;
		}


	}
}