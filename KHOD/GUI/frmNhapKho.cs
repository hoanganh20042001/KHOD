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
			thanhtoan.Items.Add("Trực tiếp");
			thanhtoan.Items.Add("Thẻ ngân hàng");
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			NHAP_KHO nk = new NHAP_KHO();// khoi taoj nhap kho
			HOA_DON hd = new HOA_DON();//khoir tao hoa don
			NhapF nhap = new NhapF();// thong tin cac san pham nhap
			int madon = nhap.NhapNgay(date1.Value.Date)[1].MaDon;
			hd.MaDon = madon;
			hd.HinhThucThanhToan = thanhtoan.Text;

			hd.Thanhtien = db.Database.SqlQuery<double>("select sum(dongia*soluong) from DAT_NL where madon=@madon", new SqlParameter("@madon",madon)).SingleOrDefault();
			hd.NgayLap = DateTime.Now.Date;
			db.HOA_DON.Add(hd);
			db.SaveChanges();
			nk.MaHD = hd.MaHD;
			nk.MaNV = 4;
			nk.NgayLap = date1.Value.Date;
			db.NHAP_KHO.Add(nk);
			db.SaveChanges();
			foreach (var item in nhap.NhapNgay(date1.Value.Date))
			{
				NGUYEN_LIEU nl = new NGUYEN_LIEU();
				nl.NgaySanXuat = date1.Value.Date;
				if (item.MaLoai == 1)
				{
					nl.HanSuDung = date1.Value.Date.AddDays(30);
				}
				else
					nl.HanSuDung = date1.Value.Date.AddDays(1);
				nl.MaTP = item.MaTP;
				nl.MaNK = nk.MaNK;
				nl.SoLuong = item.SoLuong;
				nl.TrangThai = true;
				db.NGUYEN_LIEU.Add(nl);
			}
			db.SaveChanges();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lbten_Click(object sender, EventArgs e)
		{

		}

		private void txtSl_TextChanged(object sender, EventArgs e)
		{

		}

		private void date1_ValueChanged(object sender, EventArgs e)
		{
			NhapF nhap = new NhapF();// thong tin cac san pham nhap
			dataGridView1.DataSource = nhap.NhapNgay(date1.Value.Date);
		}
	}
	
}