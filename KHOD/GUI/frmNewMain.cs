using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using KHOD.Func;
namespace KHOD.GUI
{
	public partial class frmNewMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		SqlConnection connection;
		SqlCommand command;
		string str = @"Data Source=LINH-CHI;Initial Catalog=QLKHO;Integrated Security=True";
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();
		void loaddata()
		{

			command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM LICH_SU_DN";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
		}
		public frmNewMain()
		{
			InitializeComponent();
		}

		private void accordionControlElement1_Click(object sender, EventArgs e)
		{

		}

		private void frmNewMain_Load(object sender, EventArgs e)
		{
<<<<<<< HEAD
			KhoF kho = new KhoF();
			kho.TuDong();
			frmThucDon form = new frmThucDon();

			//frmChangePass.TopLevel = false;


			panelMain.Controls.Clear();
			//panelMain.Dock = DockStyle.Fill;

			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			panelMain.Controls.Add(form);

			form.Show();
			form.BringToFront();
=======
			connection = new SqlConnection(str);
			connection.Open();
			loaddata();
>>>>>>> origin/chichi
		}

		private void accordionControlElement8_Click(object sender, EventArgs e)
		{
			frmThucDon form = new frmThucDon();

			//frmChangePass.TopLevel = false;


			panelMain.Controls.Clear();
			//panelMain.Dock = DockStyle.Fill;

			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			panelMain.Controls.Add(form);

			form.Show();
			form.BringToFront();
		}

		private void accordionControlElement9_Click(object sender, EventArgs e)
		{
			frmListNL form = new frmListNL();

			//frmChangePass.TopLevel = false;


			panelMain.Controls.Clear();
			//panelMain.Dock = DockStyle.Fill;

			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			panelMain.Controls.Add(form);

			form.Show();
			form.BringToFront();
		}

<<<<<<< HEAD
		private void accordionControlElement10_Click(object sender, EventArgs e)
		{

			frmKiemTra form = new frmKiemTra();
=======
		private void accordionControlElement13_Click(object sender, EventArgs e)
		{
			frmNhanVien form = new frmNhanVien();
>>>>>>> origin/chichi

			//frmChangePass.TopLevel = false;


			panelMain.Controls.Clear();
			//panelMain.Dock = DockStyle.Fill;

			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			panelMain.Controls.Add(form);

			form.Show();
			form.BringToFront();
		}

<<<<<<< HEAD
		private void accordionControlElement11_Click(object sender, EventArgs e)
		{
			frmThongKe form = new frmThongKe();
=======
		private void accordionControlElement14_Click(object sender, EventArgs e)
		{
			frmNhanVien_Themmoi form = new frmNhanVien_Themmoi();
>>>>>>> origin/chichi

			//frmChangePass.TopLevel = false;


			panelMain.Controls.Clear();
			//panelMain.Dock = DockStyle.Fill;

			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			panelMain.Controls.Add(form);

			form.Show();
			form.BringToFront();
		}

<<<<<<< HEAD
		private void accordionControlElement12_Click(object sender, EventArgs e)
		{
			frmDatNL form = new frmDatNL();

=======
		private void accordionControlElement18_Click(object sender, EventArgs e)
		{
			frmThongTinNguoiDung form = new frmThongTinNguoiDung();
>>>>>>> origin/chichi

			//frmChangePass.TopLevel = false;


			panelMain.Controls.Clear();
			//panelMain.Dock = DockStyle.Fill;

			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			panelMain.Controls.Add(form);

			form.Show();
			form.BringToFront();
		}

<<<<<<< HEAD
		private void accordionControlElement22_Click(object sender, EventArgs e)
		{
			frmNhapKho form = new frmNhapKho();

=======
		private void accordionControlElement19_Click(object sender, EventArgs e)
		{
			if (frmLogin.MALS_DN != "")
			{
				DateTime now = DateTime.Now;
				SqlConnection sc = new SqlConnection();
				SqlCommand com = new SqlCommand();
				sc.ConnectionString = str;
				sc.Open();
				com.Connection = sc;
				com.CommandText = @"update LICH_SU_DN set ThoiGianThoat= @tg where MaLS = '" + frmLogin.MALS_DN + "'";
				com.Parameters.AddWithValue("@tg", now);
				com.ExecuteNonQuery();
				sc.Close();

				frmLogin frm = new frmLogin();
				frm.Show();
				this.Close();
				connection.Close();
			}
			else
			{
				MessageBox.Show("ERROR!");
			}
		}

		private void frmNewMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (frmLogin.MALS_DN != "")
			{
				DateTime now = DateTime.Now;
				SqlConnection sc = new SqlConnection();
				SqlCommand com = new SqlCommand();
				sc.ConnectionString = str;
				sc.Open();
				com.Connection = sc;
				com.CommandText = @"update LICH_SU_DN set ThoiGianThoat= @tg where MaLS = '" + frmLogin.MALS_DN + "'";
				com.Parameters.AddWithValue("@tg", now);
				com.ExecuteNonQuery();
				sc.Close();
				connection.Close();
				Application.Exit();
			}
			else
			{
				MessageBox.Show("ERROR!");
			}
		}

		private void accordionControlElement24_Click(object sender, EventArgs e)
		{
			frmLichSuTruyCap form = new frmLichSuTruyCap();
>>>>>>> origin/chichi

			//frmChangePass.TopLevel = false;


			panelMain.Controls.Clear();
			//panelMain.Dock = DockStyle.Fill;

			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			panelMain.Controls.Add(form);

			form.Show();
			form.BringToFront();
		}
<<<<<<< HEAD
=======

		private void accordionControlElement15_Click(object sender, EventArgs e)
		{
			frmSaoLuu form = new frmSaoLuu();
			panelMain.Controls.Clear();
			//panelMain.Dock = DockStyle.Fill;

			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			panelMain.Controls.Add(form);

			form.Show();
			form.BringToFront();
		}

		private void accordionControlElement16_Click(object sender, EventArgs e)
		{
			frmPhucHoi form = new frmPhucHoi();
			panelMain.Controls.Clear();
			//panelMain.Dock = DockStyle.Fill;

			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			panelMain.Controls.Add(form);

			form.Show();
			form.BringToFront();
		}
>>>>>>> origin/chichi
	}
}
