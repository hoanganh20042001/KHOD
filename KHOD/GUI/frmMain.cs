using DevExpress.XtraBars;
using KHOD.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KHOD.report;

namespace KHOD
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            frmChangePass form = new frmChangePass();

            //frmChangePass.TopLevel = false;
            
            ////Switch.Controls.Add(frmChangePass);
            //frmChangePass.Dock = DockStyle.Fill;
            //frmChangePass.Show();
            //frmChangePass.BringToFront();
            //Switch.Controls.RemoveByKey("frmAlert");
            //Switch.Controls.RemoveByKey("frmTurnOff");
            //Switch.Controls.RemoveByKey("frmCall");
            panelMain.Controls.Clear();
            //panelMain.Dock = DockStyle.Fill;
            
            form.TopLevel = false;
            //form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);

            form.Show();
            form.BringToFront();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
        }

        private void accordionControlElement22_Click(object sender, EventArgs e)
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

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement20_Click(object sender, EventArgs e)
        {
			


		}

		private void accordionControlElement12_Click(object sender, EventArgs e)
		{
           
        }

		private void accordionControlElement15_Click(object sender, EventArgs e)
		{
            frmPhucHoi form = new frmPhucHoi();

            //frmChangePass.TopLevel = false;


            panelMain.Controls.Clear();
            //panelMain.Dock = DockStyle.Fill;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);

            form.Show();
            form.BringToFront();
        }

		private void accordionControlElement14_Click(object sender, EventArgs e)
		{
            frmSaoLuu form = new frmSaoLuu();

            //frmChangePass.TopLevel = false;


            panelMain.Controls.Clear();
            //panelMain.Dock = DockStyle.Fill;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);

            form.Show();
            form.BringToFront();
        }

		private void accordionControlElement6_Click(object sender, EventArgs e)
		{

		}

		private void accordionControlElement7_Click(object sender, EventArgs e)
		{

            Print form = new Print();

            //frmChangePass.TopLevel = false;


            panelMain.Controls.Clear();
            //panelMain.Dock = DockStyle.Fill;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);

            form.Show();
            form.BringToFront();
        }

		private void accordionControlElement1_Click(object sender, EventArgs e)
		{
			frmThongKe form = new frmThongKe();

			//frmChangePass.TopLevel = false;


			panelMain.Controls.Clear();
			//panelMain.Dock = DockStyle.Fill;

			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			panelMain.Controls.Add(form);

			form.Show();
			form.BringToFront();
		}

		private void accordionControlElement19_Click(object sender, EventArgs e)
		{
			MA ma = new MA();
			ma.Show();
		}
	}
}
