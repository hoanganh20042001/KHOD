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
	public partial class frmLichSuTruyCap : Form
	{
		SqlConnection connection;
		SqlCommand command;
		string str = @"Data Source=DESKTOP-CB0GE4G;Initial Catalog=KHO_D;Integrated Security=True";

		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();
		void loaddata()
		{
			command = connection.CreateCommand();
			command.CommandText = "select NHAN_VIEN.MaNV, NHAN_VIEN.TenNV, ThoiGian, ThoiGianThoat from LICH_SU_DN , NHAN_VIEN WHERE NHAN_VIEN.MaNV = LICH_SU_DN.MaNV";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
			guna2DataGridView1.DataSource = table;
		}
		public frmLichSuTruyCap()
		{
			InitializeComponent();
		}

		private void frmLichSuTruyCap_Load(object sender, EventArgs e)
		{
			connection = new SqlConnection(str);
			connection.Open();
			loaddata();
		}
	}
}
