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

namespace KHOD.GUI
{
	public partial class frmBaoCao1 : DevExpress.XtraEditors.XtraForm
	{
		public frmBaoCao1()
		{
			InitializeComponent();
		}
		[System.Runtime.InteropServices.DllImport("gdi32.dll")]
		private static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
		private Bitmap memoryImage;
		private void PrintS()
		{
			Graphics mygraphics = this.CreateGraphics();
			Size s = this.Size;
			memoryImage = new Bitmap(s.Width,20000, mygraphics);
			Graphics memoryGraphics = Graphics.FromImage(memoryImage);
			IntPtr dc1 = mygraphics.GetHdc();
			IntPtr dc2 = memoryGraphics.GetHdc();
			BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
			mygraphics.ReleaseHdc(dc1);
			memoryGraphics.ReleaseHdc(dc2);
		}
		private bool button1WasClicked = false;
		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void frmBaoCao1_Load(object sender, EventArgs e)
		{

		}

		private void btnSub_Click(object sender, EventArgs e)
		{
			btnSub.Visible = false;
			//if (MessageBox.Show("Mở giao diện in hóa đơn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			//{
			button1WasClicked = true;
			PrintS();
			//string docName = "testPage.txt";
			//string docPath = @"C:\";
			//string fullPath = System.IO.Path.Combine(docPath, docName);
			//printDocument1.DocumentName = docName;
			//stringToPrint = System.IO.File.ReadAllText(fullPath);

			//printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.ShowDialog();
			this.Close();
		}

		private void frmBaoCao1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (button1WasClicked == false)
			{
				e.Cancel = true;
			}
		}
		private string documentContents = "";

		// Declare a variable to hold the portion of the document that
		// is not printed.
		private string stringToPrint = "";
		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
		//				//string docName = "testPage.txt";
		//	//string docPath = @"C:\";
		//	//string fullPath = System.IO.Path.Combine(docPath, docName);
		//	//printDocument1.DocumentName = docName;
		//	//stringToPrint = System.IO.File.ReadAllText(fullPath);

		//	int charactersOnPage = 0;
		//	int linesPerPage = 0;

		//	// Sets the value of charactersOnPage to the number of characters
		//	// of stringToPrint that will fit within the bounds of the page.
		//	e.Graphics.MeasureString(stringToPrint, this.Font,
		//		e.MarginBounds.Size, StringFormat.GenericTypographic,
		//		out charactersOnPage, out linesPerPage);

		//	// Draws the string within the bounds of the page.
		//	e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
		//	e.MarginBounds, StringFormat.GenericTypographic);

		//	// Remove the portion of the string that has been printed.
		//	stringToPrint = stringToPrint.Substring(charactersOnPage);

		//	// Check to see if more pages are to be printed.
		//	e.HasMorePages = (stringToPrint.Length > 0);

		//	// If there are no more pages, reset the string to be printed.
		//	if (!e.HasMorePages)
		//		stringToPrint = documentContents;
			e.Graphics.DrawImage(memoryImage, 0, 0);
		}

		private void lbO_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lbTG_Click(object sender, EventArgs e)
		{

		}

		private void lbO_Click(object sender, EventArgs e)
		{

		}
	}
}