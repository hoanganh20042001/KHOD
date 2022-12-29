using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KHOD.Func;
using KHOD.DAO;
using System.Data.SqlClient;
namespace KHOD.GUI
{
	public partial class frmXK : DevExpress.XtraEditors.XtraForm
	{
		public frmXK()
		{
			InitializeComponent();
		}
		MyDB db = new MyDB();
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void frmXK_Load(object sender, EventArgs e)
		{
			ThanhPhanF tp = new ThanhPhanF();
			dataGridView1.DataSource = tp.ListNgay(date1.Value);
		}

		private void date1_ValueChanged(object sender, EventArgs e)
		{
			ThanhPhanF tp = new ThanhPhanF();
			dataGridView1.DataSource = tp.ListNgay(date1.Value);
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			try
			{

				ThanhPhanF tp = new ThanhPhanF();
				var List=tp.ListNgay(date1.Value);
				foreach(var item in List)//danh sach thuc don
				{
					var ds = db.Database.SqlQuery<NGUYEN_LIEU>("select * from nguyen_lieu where matp=@matp", new SqlParameter("@matp", item.maTP)).ToList();
					foreach(var i in ds)//nguyn lieu do tron kho
					{
						NGUYEN_LIEU nl = db.NGUYEN_LIEU.Find(i.MaNL);
						if (item.DinhLuong < i.SoLuong)
						{
							
							nl.SoLuong = i.SoLuong -(int) item.DinhLuong;
						}
						else
						{
							
							nl.SoLuong = 0;
							item.DinhLuong = item.DinhLuong - i.SoLuong;
						}
						XUAT_KHO xk = new XUAT_KHO();
						xk.MaNV = 4;
						xk.NgayXuat = date1.Value;
						db.XUAT_KHO.Add(xk);
						PHIEU_XUAT_KHO pxk = new PHIEU_XUAT_KHO();
						pxk.SoLuong = (int)item.DinhLuong;
						pxk.MaXK = xk.MaXK;
						pxk.MaNL = nl.MaNL;
						db.PHIEU_XUAT_KHO.Add(pxk);
						db.SaveChanges();
					}
				}
				MessageBox.Show("Xuất kho thành công");
			}
			catch
			{
				MessageBox.Show("Xuất kho không thành công");
			}
		}
	}
}