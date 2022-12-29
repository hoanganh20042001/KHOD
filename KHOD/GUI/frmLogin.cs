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
		public static string MALS_DN ="";
		public static string MAPQ = "";

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
				DateTime now = DateTime.Now;

				SqlConnection sc = new SqlConnection();
				SqlCommand com = new SqlCommand();
				sc.ConnectionString = str;
				sc.Open();
				com.Connection = sc;
				com.CommandText = @"INSERT INTO LICH_SU_DN (MaNV, ThoiGian) VALUES (@manv, @tg)";
				com.Parameters.AddWithValue("@manv", ID_NHANVIEN);
				com.Parameters.AddWithValue("@tg", now);
				com.ExecuteNonQuery();
				sc.Close();
				MAPQ = getMAPQ(ID_NHANVIEN);
				frmNewMain fmain = new frmNewMain();
				fmain.Show();
				this.Hide();
				connection.Close();
				MALS_DN = getMALS(ID_NHANVIEN, now.ToString());

			}
			else
			{
				MessageBox.Show("Kiểm tra lại các trường đã nhập hoặc tài khoản của bạn đã bị khóa!");
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
				command.CommandText = "SELECT * FROM NHAN_VIEN WHERE TaiKhoan ='" + username + "' and MatKhau='" + pass + "' and TrangThai = '"+1+"'";
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

		private string getMALS(string id, string thoigianbd)
		{
			string mals ="";
			try
			{
				command.CommandText = "SELECT * FROM LICH_SU_DN ";
				SqlDataAdapter da = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				da.Fill(dt);
				if (dt != null)
				{
					foreach (DataRow dr in dt.Rows)
					{
						mals = dr["MaLS"].ToString();
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
			return mals;
		}
		private string getMAPQ(string id)
		{
			string mapq = "";
			try
			{
				command.CommandText = "SELECT * FROM NHAN_VIEN where MaNV = '" + Convert.ToInt32(id) + "'";
				SqlDataAdapter da = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				da.Fill(dt);
				if (dt != null)
				{
					foreach (DataRow dr in dt.Rows)
					{
						mapq = dr["MaPQ"].ToString();
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
			return mapq;
		}
	}
}