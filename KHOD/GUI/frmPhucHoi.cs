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
	public partial class frmPhucHoi : Form
	{
		SqlConnection connection;
		string str = @"Data Source=LINH-CHI;Initial Catalog=QLKHO;Integrated Security=True";
		public frmPhucHoi()
		{
			InitializeComponent();
		}

		private void frmPhucHoi_Load(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "file dữ liệu| .bak";
			dlg.Title = "Dữ liệu phục hồi";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				guna2TextBox1.Text = dlg.FileName;
				guna2Button2.Enabled = true;
			}
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			string database = connection.Database.ToString();
			connection.Open();
			try
			{
				string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
				SqlCommand cmd = new SqlCommand(str1, connection);
				cmd.ExecuteNonQuery();
				string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK = '" + guna2TextBox1.Text + "' WITH REPLACE;";
				SqlCommand cmd1 = new SqlCommand(str2, connection);
				cmd1.ExecuteNonQuery();
				string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
				SqlCommand cmd2 = new SqlCommand(str3, connection);
				cmd2.ExecuteNonQuery();
				MessageBox.Show("Phục hồi dữ liệu thành công");
				connection.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
