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
	}
}
