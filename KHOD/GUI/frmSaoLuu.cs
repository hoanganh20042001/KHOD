using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KHOD.DAO;
using System.Data.SqlClient;
namespace KHOD.GUI
{
	public partial class frmSaoLuu : DevExpress.XtraEditors.XtraForm
	{
		MyDB db = new MyDB();
		public frmSaoLuu()
		{
			InitializeComponent();
		}

		private void labelControl1_Click(object sender, EventArgs e)
		{

		}
		public string backup(string filename)
		{
			string filenameout = filename;
			SqlParameter idParam = new SqlParameter { ParameterName = "filenameout", Value = filenameout };
			int i = db.Database.ExecuteSqlCommand("Backup database CameraTrackingSystem to disk = @filrnamout",idParam);
			return filename;
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{

			try
			{
				backup(txtDuongDan.Text);
				MessageBox.Show("Sao lưu dữ liệu thành công. ",
								"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


			}
			catch (Exception ex)
			{
				MessageBox.Show("Sao lưu không thành công do : " + ex.Message.ToString());
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		private void frmSaoLuu_Load(object sender, EventArgs e)
		{
			//CheckPermissions();
			//txtDBName.Text = GlobalParams.DBName;
			//txtDuongDan.Text = QuiUocMacDinh.DuongDanLuuDuLieu + @"\" + DateTime.Now.ToString("ddMMyyyy") + "_" + DateTime.Now.ToString("HH_mm_ss") + ".bak";
			txtDuongDan.Text = @"D:\DatabaseBackup\" + DateTime.Now.ToString("ddMMyyyy") + "_" + DateTime.Now.ToString("HH_mm_ss") + ".bak";
		}
		private void btnChon_Click(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.InitialDirectory = @"D:\QLTG\SAOLUU";

			save.Filter = "Bak files (*.bak)|*.bak|All files (*.*)|*.*";
			save.FileName = DateTime.Now.ToString("ddMMyyyy") + "_" +
							DateTime.Now.ToString("HH_mm_ss") + ".bak";
			save.RestoreDirectory = true;
			if (save.ShowDialog() == DialogResult.OK)
			{
				txtDuongDan.Text = save.FileName;
			}
		}
		private void panelControl2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}