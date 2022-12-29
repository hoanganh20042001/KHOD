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
using DevExpress.XtraEditors;
using KHOD.DAO;
using KHOD.Func;

namespace KHOD.GUI
{
	public partial class frmNhapKho : DevExpress.XtraEditors.XtraForm
	{
		public frmNhapKho()
		{
			InitializeComponent();
		}
		MyDB db = new MyDB();

		private void frmNhapKho_Load(object sender, EventArgs e)
		{

			NhapF nhap = new NhapF();
			dataGridView1.DataSource = nhap.NhapNgay(date1.Value.Date);
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			NHAP_KHO nk = new NHAP_KHO();// khoi taoj nhap kho
			HOA_DON hd = new HOA_DON();//khoir tao hoa don
			NhapF nhap = new NhapF();// thong tin cac san pham nhap
			foreach (var item in nhap.NhapNgay(date1.Value.Date))
			{

			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
	
}