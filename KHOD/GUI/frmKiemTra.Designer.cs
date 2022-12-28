
namespace KHOD.GUI
{
	partial class frmKiemTra
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.MaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.lbMa = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.lbten = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.lbSoLuongBD = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.txtSl = new System.Windows.Forms.TextBox();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.txtLyDO = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.panel2);
			this.panelControl1.Controls.Add(this.panel1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1503, 595);
			this.panelControl1.TabIndex = 0;
			this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(2, 221);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1499, 372);
			this.panel2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Ivory;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNL,
            this.TenNL,
            this.SoLuong,
            this.NgaySanXuat,
            this.HanSuDung,
            this.TrangThai,
            this.Column1});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1499, 372);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
			// 
			// MaNL
			// 
			this.MaNL.DataPropertyName = "MaNL";
			this.MaNL.HeaderText = "Mã Nguyên Liệu";
			this.MaNL.MinimumWidth = 6;
			this.MaNL.Name = "MaNL";
			this.MaNL.Width = 150;
			// 
			// TenNL
			// 
			this.TenNL.DataPropertyName = "NguyenLieu";
			this.TenNL.HeaderText = "Nguyên Liệu";
			this.TenNL.MinimumWidth = 6;
			this.TenNL.Name = "TenNL";
			this.TenNL.Width = 250;
			// 
			// SoLuong
			// 
			this.SoLuong.DataPropertyName = "SoLuong";
			this.SoLuong.HeaderText = "Số Lượng";
			this.SoLuong.MinimumWidth = 6;
			this.SoLuong.Name = "SoLuong";
			this.SoLuong.Width = 125;
			// 
			// NgaySanXuat
			// 
			this.NgaySanXuat.DataPropertyName = "NSX";
			this.NgaySanXuat.HeaderText = "Ngày Sản Xuất";
			this.NgaySanXuat.MinimumWidth = 6;
			this.NgaySanXuat.Name = "NgaySanXuat";
			this.NgaySanXuat.Width = 175;
			// 
			// HanSuDung
			// 
			this.HanSuDung.DataPropertyName = "HSD";
			this.HanSuDung.HeaderText = "Hạn Sử Dụng";
			this.HanSuDung.MinimumWidth = 6;
			this.HanSuDung.Name = "HanSuDung";
			this.HanSuDung.Width = 175;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng Thái";
			this.TrangThai.MinimumWidth = 6;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.Width = 125;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Gia";
			this.Column1.HeaderText = "Đơn Giá";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.txtLyDO);
			this.panel1.Controls.Add(this.labelControl6);
			this.panel1.Controls.Add(this.simpleButton1);
			this.panel1.Controls.Add(this.txtSl);
			this.panel1.Controls.Add(this.labelControl5);
			this.panel1.Controls.Add(this.lbSoLuongBD);
			this.panel1.Controls.Add(this.labelControl4);
			this.panel1.Controls.Add(this.labelControl2);
			this.panel1.Controls.Add(this.lbten);
			this.panel1.Controls.Add(this.labelControl3);
			this.panel1.Controls.Add(this.lbMa);
			this.panel1.Controls.Add(this.labelControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1499, 219);
			this.panel1.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(54, 83);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(106, 17);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Mã Nguyên Liệu :";
			this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
			// 
			// lbMa
			// 
			this.lbMa.Location = new System.Drawing.Point(163, 83);
			this.lbMa.Name = "lbMa";
			this.lbMa.Size = new System.Drawing.Size(91, 17);
			this.lbMa.TabIndex = 1;
			this.lbMa.Text = "Mã nguyên liệu";
			this.lbMa.Click += new System.EventHandler(this.lbMa_Click);
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(54, 121);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(112, 17);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "Tên Nguyên Liệu :";
			// 
			// lbten
			// 
			this.lbten.Location = new System.Drawing.Point(163, 121);
			this.lbten.Name = "lbten";
			this.lbten.Size = new System.Drawing.Size(97, 17);
			this.lbten.TabIndex = 3;
			this.lbten.Text = "Tên nguyên liệu";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(542, 10);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(310, 34);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Kiểm Tra Nguyên Liệu";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(412, 83);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(114, 17);
			this.labelControl4.TabIndex = 5;
			this.labelControl4.Text = "Số lượng ban đầu:";
			// 
			// lbSoLuongBD
			// 
			this.lbSoLuongBD.Location = new System.Drawing.Point(532, 83);
			this.lbSoLuongBD.Name = "lbSoLuongBD";
			this.lbSoLuongBD.Size = new System.Drawing.Size(109, 17);
			this.lbSoLuongBD.TabIndex = 6;
			this.lbSoLuongBD.Text = "Số lượng ban đầu";
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(412, 121);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(96, 17);
			this.labelControl5.TabIndex = 7;
			this.labelControl5.Text = "Số lượng hỏng:";
			// 
			// txtSl
			// 
			this.txtSl.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSl.Location = new System.Drawing.Point(514, 115);
			this.txtSl.Name = "txtSl";
			this.txtSl.Size = new System.Drawing.Size(82, 23);
			this.txtSl.TabIndex = 8;
			this.txtSl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.Location = new System.Drawing.Point(1292, 98);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(146, 40);
			this.simpleButton1.TabIndex = 9;
			this.simpleButton1.Text = "Kiểm tra";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(793, 83);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(80, 17);
			this.labelControl6.TabIndex = 10;
			this.labelControl6.Text = "Lý do hỏng :";
			// 
			// txtLyDO
			// 
			this.txtLyDO.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLyDO.Location = new System.Drawing.Point(879, 77);
			this.txtLyDO.Name = "txtLyDO";
			this.txtLyDO.Size = new System.Drawing.Size(213, 23);
			this.txtLyDO.TabIndex = 11;
			// 
			// frmKiemTra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1503, 595);
			this.Controls.Add(this.panelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmKiemTra";
			this.Text = "frmKiemTra";
			this.Load += new System.EventHandler(this.frmKiemTra_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNL;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgaySanXuat;
		private System.Windows.Forms.DataGridViewTextBoxColumn HanSuDung;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private DevExpress.XtraEditors.LabelControl lbten;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl lbMa;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.TextBox txtSl;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl lbSoLuongBD;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private System.Windows.Forms.TextBox txtLyDO;
		private DevExpress.XtraEditors.LabelControl labelControl6;
	}
}