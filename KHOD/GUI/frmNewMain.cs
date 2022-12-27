using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace KHOD.GUI
{
	public partial class frmNewMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		public frmNewMain()
		{
			InitializeComponent();
		}

		private void accordionControlElement1_Click(object sender, EventArgs e)
		{

		}

		private void frmNewMain_Load(object sender, EventArgs e)
		{

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
	}
}
