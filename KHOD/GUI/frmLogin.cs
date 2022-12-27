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

    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
		public static string ID_NHANVIEN = "";
		SqlConnection connection;
		SqlCommand command;
		string str = @"Data Source=LINH-CHI;Initial Catalog=KHO_D;Integrated Security=True";

		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();
		void loaddata()
		{

			command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM NHAN_VIEN";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
		}
		public frmLogin()
        {
            InitializeComponent();
			txtMK.PasswordChar = '*';
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

		private void frmLogin_Load(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
			connection.Open();
			loaddata();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			ID_NHANVIEN = getID(txtDN.Text, txtMK.Text);
			if (ID_NHANVIEN != "")
			{
				frmNewMain fmain = new frmNewMain();
				fmain.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Tài khoản và mật khẩu không đúng !");
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}



		private string getID(string username, string pass)
		{
			string id = "";
			try
			{
				command.CommandText = "SELECT * FROM NHAN_VIEN WHERE TaiKhoan ='" + username + "' and MatKhau='" + pass + "'";
				SqlDataAdapter da = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				da.Fill(dt);
				if (dt != null)
				{
					foreach (DataRow dr in dt.Rows)
					{
						id = dr["MaNV"].ToString();
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
			}
			finally
			{
				connection.Close();
			}
			return id;
		}
	}
}