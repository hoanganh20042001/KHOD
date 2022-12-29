
namespace KHOD.GUI
{
	partial class frmXuatKho
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.thanhtoan = new System.Windows.Forms.ComboBox();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.lbGia = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.date1 = new System.Windows.Forms.DateTimePicker();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.txtSl = new System.Windows.Forms.TextBox();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.lbten = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.thanhtoan);
			this.panel1.Controls.Add(this.labelControl6);
			this.panel1.Controls.Add(this.lbGia);
			this.panel1.Controls.Add(this.labelControl5);
			this.panel1.Controls.Add(this.date1);
			this.panel1.Controls.Add(this.simpleButton1);
			this.panel1.Controls.Add(this.txtSl);
			this.panel1.Controls.Add(this.labelControl4);
			this.panel1.Controls.Add(this.labelControl2);
			this.panel1.Controls.Add(this.lbten);
			this.panel1.Controls.Add(this.labelControl3);
			this.panel1.Controls.Add(this.labelControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(995, 268);
			this.panel1.TabIndex = 0;
			// 
			// thanhtoan
			// 
			this.thanhtoan.FormattingEnabled = true;
			this.thanhtoan.Location = new System.Drawing.Point(744, 109);
			this.thanhtoan.Name = "thanhtoan";
			this.thanhtoan.Size = new System.Drawing.Size(121, 24);
			this.thanhtoan.TabIndex = 41;
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(597, 109);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(141, 17);
			this.labelControl6.TabIndex = 40;
			this.labelControl6.Text = "Hình thức thanh toán :";
			// 
			// lbGia
			// 
			this.lbGia.Location = new System.Drawing.Point(468, 109);
			this.lbGia.Name = "lbGia";
			this.lbGia.Size = new System.Drawing.Size(17, 16);
			this.lbGia.TabIndex = 39;
			this.lbGia.Text = "gia";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(391, 161);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(64, 17);
			this.labelControl5.TabIndex = 38;
			this.labelControl5.Text = "Số lượng :";
			// 
			// date1
			// 
			this.date1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date1.Location = new System.Drawing.Point(116, 102);
			this.date1.Name = "date1";
			this.date1.Size = new System.Drawing.Size(182, 23);
			this.date1.TabIndex = 37;
			this.date1.Value = new System.DateTime(2022, 12, 29, 0, 0, 0, 0);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.Location = new System.Drawing.Point(793, 214);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(146, 40);
			this.simpleButton1.TabIndex = 36;
			this.simpleButton1.Text = "Xuất kho";
			// 
			// txtSl
			// 
			this.txtSl.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSl.Location = new System.Drawing.Point(468, 155);
			this.txtSl.Name = "txtSl";
			this.txtSl.Size = new System.Drawing.Size(82, 23);
			this.txtSl.TabIndex = 35;
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(391, 109);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(49, 16);
			this.labelControl4.TabIndex = 34;
			this.labelControl4.Text = "Đơn giá:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(576, 36);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(129, 34);
			this.labelControl2.TabIndex = 33;
			this.labelControl2.Text = "Xuất Kho";
			// 
			// lbten
			// 
			this.lbten.Location = new System.Drawing.Point(201, 161);
			this.lbten.Name = "lbten";
			this.lbten.Size = new System.Drawing.Size(97, 17);
			this.lbten.TabIndex = 32;
			this.lbten.Text = "Tên nguyên liệu";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(55, 161);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(112, 17);
			this.labelControl3.TabIndex = 31;
			this.labelControl3.Text = "Tên Nguyên Liệu :";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(70, 107);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(37, 16);
			this.labelControl1.TabIndex = 30;
			this.labelControl1.Text = "Ngày :";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 268);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(995, 251);
			this.panel2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(995, 251);
			this.dataGridView1.TabIndex = 0;
			// 
			// frmXuatKho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(995, 519);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmXuatKho";
			this.Text = "frmXuatKho";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox thanhtoan;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl lbGia;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private System.Windows.Forms.DateTimePicker date1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private System.Windows.Forms.TextBox txtSl;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl lbten;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}