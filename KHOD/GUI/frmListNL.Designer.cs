
namespace KHOD.GUI
{
	partial class frmListNL
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
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.button1 = new System.Windows.Forms.Button();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.button1);
            this.sidePanel1.Controls.Add(this.date2);
            this.sidePanel1.Controls.Add(this.date1);
            this.sidePanel1.Controls.Add(this.labelControl3);
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1188, 87);
            this.sidePanel1.TabIndex = 4;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(420, 29);
            this.date2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(172, 21);
            this.date2.TabIndex = 8;
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(122, 29);
            this.date1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(172, 21);
            this.date1.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(327, 24);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 23);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Đến ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(498, 60);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(195, 25);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Danh sách nguyên liệu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 24);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Từ ngày";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 87);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1188, 442);
            this.panelControl2.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.dataGridView1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1184, 438);
            this.panelControl1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1186, 436);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 125;
            // 
            // frmListNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 529);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.sidePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmListNL";
            this.Text = "frmListTD";
            this.Load += new System.EventHandler(this.frmListNL_Load);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SidePanel sidePanel1;
		private System.Windows.Forms.DateTimePicker date2;
		private System.Windows.Forms.DateTimePicker date1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
		private System.Windows.Forms.Button button1;
	}
}