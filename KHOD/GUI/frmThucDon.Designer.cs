
namespace KHOD.GUI
{
    partial class frmThucDon
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Buoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateTimeOffsetEdit1 = new DevExpress.XtraEditors.DateTimeOffsetEdit();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.sidePanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.Controls.Add(this.panelControl3);
			this.panelControl1.Controls.Add(this.panelControl2);
			this.panelControl1.Controls.Add(this.sidePanel1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(925, 538);
			this.panelControl1.TabIndex = 0;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
			this.labelControl2.Appearance.Options.UseBackColor = true;
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.labelControl2.Location = new System.Drawing.Point(161, 0);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(217, 31);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Danh sách thực đơn";
			// 
			// sidePanel1
			// 
			this.sidePanel1.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.sidePanel1.Appearance.Options.UseBackColor = true;
			this.sidePanel1.Controls.Add(this.labelControl1);
			this.sidePanel1.Controls.Add(this.dateTimeOffsetEdit1);
			this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.sidePanel1.Location = new System.Drawing.Point(2, 2);
			this.sidePanel1.Name = "sidePanel1";
			this.sidePanel1.Size = new System.Drawing.Size(921, 107);
			this.sidePanel1.TabIndex = 3;
			this.sidePanel1.Text = "sidePanel1";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(27, 29);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(51, 28);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Ngày";
			this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeight = 29;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.Buoi,
            this.QS,
            this.MonAn});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.Location = new System.Drawing.Point(2, 37);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(917, 388);
			this.dataGridView1.TabIndex = 0;
			// 
			// Ngay
			// 
			this.Ngay.HeaderText = "Ngày";
			this.Ngay.MinimumWidth = 6;
			this.Ngay.Name = "Ngay";
			this.Ngay.Width = 125;
			// 
			// Buoi
			// 
			this.Buoi.HeaderText = "Buổi";
			this.Buoi.MinimumWidth = 6;
			this.Buoi.Name = "Buoi";
			this.Buoi.Width = 125;
			// 
			// QS
			// 
			this.QS.HeaderText = "Quân Số";
			this.QS.MinimumWidth = 6;
			this.QS.Name = "QS";
			this.QS.Width = 125;
			// 
			// MonAn
			// 
			this.MonAn.HeaderText = "Món Ăn";
			this.MonAn.MinimumWidth = 6;
			this.MonAn.Name = "MonAn";
			this.MonAn.Width = 125;
			// 
			// dateTimeOffsetEdit1
			// 
			this.dateTimeOffsetEdit1.EditValue = null;
			this.dateTimeOffsetEdit1.Location = new System.Drawing.Point(101, 35);
			this.dateTimeOffsetEdit1.Name = "dateTimeOffsetEdit1";
			this.dateTimeOffsetEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateTimeOffsetEdit1.Size = new System.Drawing.Size(145, 22);
			this.dateTimeOffsetEdit1.TabIndex = 2;
			this.dateTimeOffsetEdit1.EditValueChanged += new System.EventHandler(this.dateTimeOffsetEdit1_EditValueChanged);
			// 
			// panelControl2
			// 
			this.panelControl2.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panelControl2.Appearance.Options.UseBackColor = true;
			this.panelControl2.Controls.Add(this.labelControl2);
			this.panelControl2.Controls.Add(this.dataGridView1);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl2.Location = new System.Drawing.Point(2, 109);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(921, 427);
			this.panelControl2.TabIndex = 5;
			// 
			// panelControl3
			// 
			this.panelControl3.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panelControl3.Appearance.Options.UseBackColor = true;
			this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelControl3.Location = new System.Drawing.Point(2, 109);
			this.panelControl3.Name = "panelControl3";
			this.panelControl3.Size = new System.Drawing.Size(125, 427);
			this.panelControl3.TabIndex = 6;
			// 
			// frmThucDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 538);
			this.Controls.Add(this.panelControl1);
			this.Name = "frmThucDon";
			this.Text = "Thực đơn";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.sidePanel1.ResumeLayout(false);
			this.sidePanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.panelControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dateTimeOffsetEdit1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
		private System.Windows.Forms.DataGridViewTextBoxColumn Buoi;
		private System.Windows.Forms.DataGridViewTextBoxColumn QS;
		private System.Windows.Forms.DataGridViewTextBoxColumn MonAn;
		private DevExpress.XtraEditors.PanelControl panelControl3;
		private DevExpress.XtraEditors.PanelControl panelControl2;
	}
}