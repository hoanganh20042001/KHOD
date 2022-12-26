
namespace KHOD.GUI
{
    partial class frmPhucHoi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhucHoi));
			this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
			this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
			this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtDuongDan = new System.Windows.Forms.TextBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtDBName = new System.Windows.Forms.TextBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.DuongDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnPhucHoi = new DevExpress.XtraEditors.SimpleButton();
			this.sidePanel1.SuspendLayout();
			this.sidePanel3.SuspendLayout();
			this.sidePanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// sidePanel1
			// 
			this.sidePanel1.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.sidePanel1.Appearance.Options.UseBackColor = true;
			this.sidePanel1.Controls.Add(this.btnPhucHoi);
			this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidePanel1.Location = new System.Drawing.Point(0, 0);
			this.sidePanel1.Name = "sidePanel1";
			this.sidePanel1.Size = new System.Drawing.Size(98, 515);
			this.sidePanel1.TabIndex = 0;
			this.sidePanel1.Text = "sidePanel1";
			// 
			// sidePanel3
			// 
			this.sidePanel3.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.sidePanel3.Appearance.Options.UseBackColor = true;
			this.sidePanel3.Controls.Add(this.txtDuongDan);
			this.sidePanel3.Controls.Add(this.labelControl2);
			this.sidePanel3.Controls.Add(this.txtDBName);
			this.sidePanel3.Controls.Add(this.labelControl3);
			this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.sidePanel3.Location = new System.Drawing.Point(98, 0);
			this.sidePanel3.Name = "sidePanel3";
			this.sidePanel3.Size = new System.Drawing.Size(697, 157);
			this.sidePanel3.TabIndex = 1;
			this.sidePanel3.Text = "sidePanel3";
			// 
			// sidePanel4
			// 
			this.sidePanel4.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.sidePanel4.Appearance.Options.UseBackColor = true;
			this.sidePanel4.Controls.Add(this.dataGridView1);
			this.sidePanel4.Controls.Add(this.labelControl1);
			this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sidePanel4.Location = new System.Drawing.Point(98, 165);
			this.sidePanel4.Name = "sidePanel4";
			this.sidePanel4.Size = new System.Drawing.Size(697, 350);
			this.sidePanel4.TabIndex = 2;
			this.sidePanel4.Text = "sidePanel4";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseBackColor = true;
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(283, 0);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(107, 28);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Danh sách";
			// 
			// txtDuongDan
			// 
			this.txtDuongDan.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDuongDan.Location = new System.Drawing.Point(42, 97);
			this.txtDuongDan.Name = "txtDuongDan";
			this.txtDuongDan.Size = new System.Drawing.Size(353, 35);
			this.txtDuongDan.TabIndex = 9;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelControl2.Appearance.Options.UseBackColor = true;
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.ImeMode = System.Windows.Forms.ImeMode.On;
			this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.labelControl2.Location = new System.Drawing.Point(42, 12);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(99, 28);
			this.labelControl2.TabIndex = 8;
			this.labelControl2.Text = "Tên CSDL";
			// 
			// txtDBName
			// 
			this.txtDBName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDBName.Location = new System.Drawing.Point(42, 46);
			this.txtDBName.Name = "txtDBName";
			this.txtDBName.Size = new System.Drawing.Size(353, 35);
			this.txtDBName.TabIndex = 7;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelControl3.Appearance.Options.UseBackColor = true;
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Appearance.Options.UseForeColor = true;
			this.labelControl3.ImeMode = System.Windows.Forms.ImeMode.On;
			this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.labelControl3.Location = new System.Drawing.Point(302, 0);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(152, 28);
			this.labelControl3.TabIndex = 6;
			this.labelControl3.Text = "Sao lưu dữ liệu";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DuongDan,
            this.ThoiGian});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 1);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(697, 349);
			this.dataGridView1.TabIndex = 98;
			// 
			// DuongDan
			// 
			this.DuongDan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DuongDan.DataPropertyName = "Name";
			this.DuongDan.HeaderText = "Đường dẫn";
			this.DuongDan.MinimumWidth = 6;
			this.DuongDan.Name = "DuongDan";
			// 
			// ThoiGian
			// 
			this.ThoiGian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ThoiGian.DataPropertyName = "CreationTime";
			this.ThoiGian.HeaderText = "Thời gian";
			this.ThoiGian.MinimumWidth = 6;
			this.ThoiGian.Name = "ThoiGian";
			// 
			// btnPhucHoi
			// 
			this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
			this.btnPhucHoi.Location = new System.Drawing.Point(12, 12);
			this.btnPhucHoi.Name = "btnPhucHoi";
			this.btnPhucHoi.Size = new System.Drawing.Size(57, 48);
			this.btnPhucHoi.TabIndex = 1;
			this.btnPhucHoi.Text = "simpleButton1";
			this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
			// 
			// frmPhucHoi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(795, 515);
			this.Controls.Add(this.sidePanel3);
			this.Controls.Add(this.sidePanel4);
			this.Controls.Add(this.sidePanel1);
			this.Name = "frmPhucHoi";
			this.ShowInTaskbar = false;
			this.Text = "Phục hồi dữ liệu";
			this.sidePanel1.ResumeLayout(false);
			this.sidePanel3.ResumeLayout(false);
			this.sidePanel3.PerformLayout();
			this.sidePanel4.ResumeLayout(false);
			this.sidePanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.TextBox txtDuongDan;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.TextBox txtDBName;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn DuongDan;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
		private DevExpress.XtraEditors.SimpleButton btnPhucHoi;
	}
}