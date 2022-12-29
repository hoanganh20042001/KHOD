
namespace KHOD.GUI
{
	partial class frmXK
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.simpleButton2);
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
			this.panel1.Size = new System.Drawing.Size(901, 188);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// lbGia
			// 
			this.lbGia.Location = new System.Drawing.Point(470, 85);
			this.lbGia.Name = "lbGia";
			this.lbGia.Size = new System.Drawing.Size(17, 16);
			this.lbGia.TabIndex = 39;
			this.lbGia.Text = "gia";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(393, 137);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(64, 17);
			this.labelControl5.TabIndex = 38;
			this.labelControl5.Text = "Số lượng :";
			// 
			// date1
			// 
			this.date1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date1.Location = new System.Drawing.Point(118, 78);
			this.date1.Name = "date1";
			this.date1.Size = new System.Drawing.Size(182, 23);
			this.date1.TabIndex = 37;
			this.date1.Value = new System.DateTime(2022, 12, 29, 0, 0, 0, 0);
			this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.Location = new System.Drawing.Point(795, 190);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(146, 40);
			this.simpleButton1.TabIndex = 36;
			this.simpleButton1.Text = "Nhập kho";
			// 
			// txtSl
			// 
			this.txtSl.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSl.Location = new System.Drawing.Point(470, 131);
			this.txtSl.Name = "txtSl";
			this.txtSl.Size = new System.Drawing.Size(82, 23);
			this.txtSl.TabIndex = 35;
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(393, 85);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(49, 16);
			this.labelControl4.TabIndex = 34;
			this.labelControl4.Text = "Đơn giá:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(578, 12);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(129, 34);
			this.labelControl2.TabIndex = 33;
			this.labelControl2.Text = "Xuất Kho";
			// 
			// lbten
			// 
			this.lbten.Location = new System.Drawing.Point(203, 137);
			this.lbten.Name = "lbten";
			this.lbten.Size = new System.Drawing.Size(97, 17);
			this.lbten.TabIndex = 32;
			this.lbten.Text = "Tên nguyên liệu";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(345, 168);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(247, 17);
			this.labelControl3.TabIndex = 31;
			this.labelControl3.Text = "Danh sách nguyên liệu nhập trong ngày";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(72, 83);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(37, 16);
			this.labelControl1.TabIndex = 30;
			this.labelControl1.Text = "Ngày :";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 188);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(901, 322);
			this.dataGridView1.TabIndex = 1;
			// 
			// simpleButton2
			// 
			this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton2.Appearance.Options.UseFont = true;
			this.simpleButton2.Location = new System.Drawing.Point(716, 137);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(146, 40);
			this.simpleButton2.TabIndex = 40;
			this.simpleButton2.Text = "Xuất kho";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// frmXK
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(901, 510);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmXK";
			this.Text = "XtraForm2";
			this.Load += new System.EventHandler(this.frmXK_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
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
		private System.Windows.Forms.DataGridView dataGridView1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
	}
}