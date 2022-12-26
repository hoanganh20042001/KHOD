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
using System.Globalization;
using KHOD.DAO;

namespace KHOD.GUI
{
	public partial class Print : DevExpress.XtraEditors.XtraForm
	{
		public Print()
		{
			InitializeComponent();
		}
		MyDB db = new MyDB();
		[System.Runtime.InteropServices.DllImport("gdi32.dll")]
		private static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
		private Bitmap memoryImage;
		private void PrintS()
		{
			Graphics mygraphics = this.CreateGraphics();
			Size s = this.Size;
			memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
			Graphics memoryGraphics = Graphics.FromImage(memoryImage);
			IntPtr dc1 = mygraphics.GetHdc();
			IntPtr dc2 = memoryGraphics.GetHdc();
			BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
			mygraphics.ReleaseHdc(dc1);
			memoryGraphics.ReleaseHdc(dc2);
		}
		private bool button1WasClicked = false;
		frmBaoCao1 frm = new frmBaoCao1();
		private void btnSub_Click(object sender, EventArgs e)
		{
			//btnSub.Visible = false;
			////if (MessageBox.Show("Mở giao diện in hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			////{
			//button1WasClicked = true;
			//PrintS();
			//printPreviewDialog1.ShowDialog();
			//this.Close();
			frmBaoCao1 form = new frmBaoCao1();

			//frmChangePass.TopLevel = false;

			//frm_PrintBill frm = new frm_PrintBill();
			//frm.tbCus.DataSource = tbInfCus.DataSource;
			//frm.tbRoom.DataSource = tbBillRoom.DataSource;
			
			
			frm.tbO.DataSource = db.MON_AN.ToList();
			
			List<string> list = db.Database.SqlQuery<string>("select teMa from mon_an").ToList();
			
			//frm.tbO.DataSource=
			//if (tbBillSer.Rows.Count > 1)
			//{
			//	frm.tbSer.DataSource = tbBillSer.DataSource;
			//}
			//else frm.tbSer.Visible = false;
			//if (tbBillDv.Rows.Count > 1)
			//{
			//	frm.tbFood.DataSource = tbBillDv.DataSource;
			//}
			//else frm.tbFood.Visible = false;

			setAutoHeight(frm.tbO, frm.tbO);
			////.....Filldata to tbSer
			//setAutoHeight(frm.tbSer, frm.tbSer);
			////.....Filldata to tbFood
			//setAutoHeight(frm.tbFood, frm.tbFood);
			//////Tính tổng tiền
			////Int64 sumMo = sumBill(tbBillRoom, 4) + sumBill(tbBillSer, 6) + sumBill(tbBillDv, 4);
			//////updateBill(sumBill(tbBillRoom, 4), sumBill(tbBillSer, 6), sumBill(tbBillDv, 4));
			//////insertDT();
			////DateTimePicker pk = new DateTimePicker();
			////pk.Value = DateTime.Today;
			//cn.setData("thanhtoan '" + getMaxIdHD() + "','" + pk.Value.ToString() + "'," + sumBill(tbBillRoom, 4) + "," + sumBill(tbBillSer, 6) + "," + sumBill(tbBillDv, 4) + ",'" + idCus + "'", "Tạo hóa đơn thành công.");
			//frm.lbSum.Text = sumMo.ToString("N");
			frm.Show();
			

		}
		public void setLable(Label lb,List<string> list)
		{

		}
		public void setAutoHeight(DataGridView dtgNative, DataGridView dtg)
		{
			// int hr = frm.tbRoom.ColumnHeadersHeight;
			//int sumHr = 0;
			//if (dtgNative.DataSource == null)
			//{
			//	dtgNative.Height = sumHr;
			//	dtgNative.Visible = false;
			//}
			//else
			//{
			//	foreach (DataGridViewRow row in dtgNative.Rows)
			//		sumHr += row.Height;
			//	dtgNative.Height = sumHr;
			//}
			//dtg.Location = dtgNative.Location + new Size(0, sumHr + 2);

			//int dgv_width = dtg.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
			//int dgv_height = dtg.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
			dtgNative.Size = new Size(823, 700);
			frm.lbO.Location = new Point(300,1000);
			frm.lbO.Text = "hoanganh";
			//dtg.Location = new Point(dtgNative.Location.X, dtgNative.Location.Y);



		}

		private void Print_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (button1WasClicked == false)
			{
				e.Cancel = true;
			}
		}

		private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(memoryImage, 0, 0);
		}

		private void h(object sender, EventArgs e)
		{

		}

		private void Print_Load(object sender, EventArgs e)
		{

		}
	}
}