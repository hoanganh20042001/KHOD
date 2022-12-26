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
using System.Data.SqlClient;
using KHOD.DAO;
namespace KHOD.GUI
{
    public partial class frmPhucHoi : DevExpress.XtraEditors.XtraForm
    {
        public frmPhucHoi()
        {
            InitializeComponent();
        }
        MyDB db = new MyDB();

        private void sidePanel2_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel3_Click(object sender, EventArgs e)
        {

        }
        public string Restore(string filename)
		{
            
            SqlParameter idParam = new SqlParameter { ParameterName = "filename", Value = filename };
            int i = db.Database.ExecuteSqlCommand("USE MASTER ALTER DATABASE[CameraTrackingSystem] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ALTER DATABASE[CameraTrackingSystem] SET MULTI_USER RESTORE DATABASE[CameraTrackingSystem] FROM DISK =@filename WITH REPLACE", idParam);
            return filename;
        }
        private void getFiles()
		{

		}

		private void btnPhucHoi_Click(object sender, EventArgs e)
		{
            string file = @"D:\DatabaseBackup\" + txtDuongDan.Text;
            try
            {
                Restore(file);
                MessageBox.Show("Phục hồi dữ liệu thành công. ",
                                     "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            catch (Exception ex)
            {
                MessageBox.Show("Phục hồi dữ liệu không thành công do lỗi : " + ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
	}
}