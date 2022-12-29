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

namespace KHOD
{
	public partial class frmSaoLuu : Form
	{
		SqlConnection connection;
		string str = @"Data Source=LINH-CHI;Initial Catalog=QLKHO;Integrated Security=True";

		public frmSaoLuu()
		{
			InitializeComponent();
		}

		private void frmSaoLuu_Load(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
			
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				guna2TextBox1.Text = dlg.SelectedPath;
				guna2Button2.Enabled = true;
			}
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			string databse = connection.Database.ToString();
			if (guna2TextBox1.Text == string.Empty)
			{
				MessageBox.Show("Chọn nơi để lưu!!");
			}
			else
			{
				string cm = "BACKUP DATABASE [" + databse + "] TO DISK '" + guna2TextBox1.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
				SqlCommand command = new SqlCommand(cm, connection);
				connection.Open();
				command.ExecuteNonQuery();
				MessageBox.Show("Sao lưu thành công");
				connection.Close();
				guna2Button2.Enabled = false;
			}
		}
	}
}
