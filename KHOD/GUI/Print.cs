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
		
		private void btnSub_Click(object sender, EventArgs e)
		{

		}
		public void setLable(Label lb,List<string> list)
		{

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