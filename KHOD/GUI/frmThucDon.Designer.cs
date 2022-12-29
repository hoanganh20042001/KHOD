
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
<<<<<<< HEAD
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Buoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QuanSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
			this.date2 = new System.Windows.Forms.DateTimePicker();
			this.date1 = new System.Windows.Forms.DateTimePicker();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.sidePanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.Controls.Add(this.panelControl2);
			this.panelControl1.Controls.Add(this.sidePanel1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1787, 706);
			this.panelControl1.TabIndex = 0;
			// 
			// panelControl2
			// 
			this.panelControl2.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panelControl2.Appearance.Options.UseBackColor = true;
			this.panelControl2.Controls.Add(this.dataGridView1);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl2.Location = new System.Drawing.Point(2, 109);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(1783, 595);
			this.panelControl2.TabIndex = 5;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeight = 29;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.Buoi,
            this.QuanSo,
            this.MonAn});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.Location = new System.Drawing.Point(2, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1779, 591);
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
			// Buoi
			// 
			this.Buoi.DataPropertyName = "Buoi";
			this.Buoi.HeaderText = "Buổi";
			this.Buoi.MinimumWidth = 6;
			this.Buoi.Name = "Buoi";
			this.Buoi.Width = 125;
			// 
			// QuanSo
			// 
			this.QuanSo.DataPropertyName = "QuanSo";
			this.QuanSo.HeaderText = "Quân Số";
			this.QuanSo.MinimumWidth = 6;
			this.QuanSo.Name = "QuanSo";
			this.QuanSo.Width = 125;
			// 
			// MonAn
			// 
			this.MonAn.DataPropertyName = "MonAn";
			this.MonAn.HeaderText = "Món Ăn";
			this.MonAn.MinimumWidth = 6;
			this.MonAn.Name = "MonAn";
			this.MonAn.Width = 1500;
			// 
			// sidePanel1
			// 
			this.sidePanel1.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.sidePanel1.Appearance.Options.UseBackColor = true;
			this.sidePanel1.Controls.Add(this.date2);
			this.sidePanel1.Controls.Add(this.date1);
			this.sidePanel1.Controls.Add(this.labelControl3);
			this.sidePanel1.Controls.Add(this.labelControl2);
			this.sidePanel1.Controls.Add(this.labelControl1);
			this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.sidePanel1.Location = new System.Drawing.Point(2, 2);
			this.sidePanel1.Name = "sidePanel1";
			this.sidePanel1.Size = new System.Drawing.Size(1783, 107);
			this.sidePanel1.TabIndex = 3;
			this.sidePanel1.Text = "sidePanel1";
			// 
			// date2
			// 
			this.date2.Location = new System.Drawing.Point(490, 36);
			this.date2.Name = "date2";
			this.date2.Size = new System.Drawing.Size(200, 23);
			this.date2.TabIndex = 8;
			this.date2.ValueChanged += new System.EventHandler(this.date2_ValueChanged);
			// 
			// date1
			// 
			this.date1.Location = new System.Drawing.Point(139, 36);
			this.date1.Name = "date1";
			this.date1.Size = new System.Drawing.Size(200, 23);
			this.date1.TabIndex = 7;
			this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(382, 30);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(102, 29);
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
			this.labelControl2.Location = new System.Drawing.Point(754, 76);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(217, 31);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Danh sách thực đơn";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(48, 30);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(88, 29);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Từ ngày";
			this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
			// 
			// frmThucDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1787, 706);
			this.Controls.Add(this.panelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmThucDon";
			this.Text = "Thực đơn";
			this.Load += new System.EventHandler(this.frmThucDon_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.sidePanel1.ResumeLayout(false);
			this.sidePanel1.PerformLayout();
			this.ResumeLayout(false);
=======
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thucDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new KHOD.Bang.DataSet1();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimeOffsetEdit1 = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.sidePanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1532, 574);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.dataGridView2);
            this.panelControl2.Controls.Add(this.dataGridView1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 89);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1528, 483);
            this.panelControl2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(77, 22);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(206, 122);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.Buoi,
            this.QS,
            this.MonAn,
            this.ngayDataGridViewTextBoxColumn,
            this.buoiDataGridViewTextBoxColumn,
            this.quanSoDataGridViewTextBoxColumn,
            this.monAnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thucDonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(377, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 479);
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
            // Buoi
            // 
            this.Buoi.DataPropertyName = "Buoi";
            this.Buoi.HeaderText = "Buổi";
            this.Buoi.MinimumWidth = 6;
            this.Buoi.Name = "Buoi";
            this.Buoi.Width = 125;
            // 
            // QS
            // 
            this.QS.DataPropertyName = "QuanSo ";
            this.QS.HeaderText = "Quân Số";
            this.QS.MinimumWidth = 6;
            this.QS.Name = "QS";
            this.QS.Width = 125;
            // 
            // MonAn
            // 
            this.MonAn.DataPropertyName = "MonAn";
            this.MonAn.HeaderText = "Món Ăn";
            this.MonAn.MinimumWidth = 6;
            this.MonAn.Name = "MonAn";
            this.MonAn.Width = 125;
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "Ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngay";
            this.ngayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            this.ngayDataGridViewTextBoxColumn.Width = 125;
            // 
            // buoiDataGridViewTextBoxColumn
            // 
            this.buoiDataGridViewTextBoxColumn.DataPropertyName = "Buoi";
            this.buoiDataGridViewTextBoxColumn.HeaderText = "Buoi";
            this.buoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buoiDataGridViewTextBoxColumn.Name = "buoiDataGridViewTextBoxColumn";
            this.buoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // quanSoDataGridViewTextBoxColumn
            // 
            this.quanSoDataGridViewTextBoxColumn.DataPropertyName = "QuanSo ";
            this.quanSoDataGridViewTextBoxColumn.HeaderText = "QuanSo ";
            this.quanSoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quanSoDataGridViewTextBoxColumn.Name = "quanSoDataGridViewTextBoxColumn";
            this.quanSoDataGridViewTextBoxColumn.Width = 125;
            // 
            // monAnDataGridViewTextBoxColumn
            // 
            this.monAnDataGridViewTextBoxColumn.DataPropertyName = "MonAn";
            this.monAnDataGridViewTextBoxColumn.HeaderText = "MonAn";
            this.monAnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monAnDataGridViewTextBoxColumn.Name = "monAnDataGridViewTextBoxColumn";
            this.monAnDataGridViewTextBoxColumn.Width = 125;
            // 
            // thucDonBindingSource
            // 
            this.thucDonBindingSource.DataMember = "ThucDon";
            this.thucDonBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Controls.Add(this.dateTimeOffsetEdit1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(2, 2);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1528, 87);
            this.sidePanel1.TabIndex = 3;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(1047, 62);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(173, 25);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Danh sách thực đơn";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 24);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ngày";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // dateTimeOffsetEdit1
            // 
            this.dateTimeOffsetEdit1.EditValue = null;
            this.dateTimeOffsetEdit1.Location = new System.Drawing.Point(87, 28);
            this.dateTimeOffsetEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeOffsetEdit1.Name = "dateTimeOffsetEdit1";
            this.dateTimeOffsetEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeOffsetEdit1.Size = new System.Drawing.Size(124, 20);
            this.dateTimeOffsetEdit1.TabIndex = 2;
            this.dateTimeOffsetEdit1.EditValueChanged += new System.EventHandler(this.dateTimeOffsetEdit1_EditValueChanged);
            // 
            // frmThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 574);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThucDon";
            this.Text = "Thực đơn";
            this.Load += new System.EventHandler(this.frmThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
>>>>>>> origin/chichi

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		public System.Windows.Forms.DataGridView dataGridView1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private System.Windows.Forms.DateTimePicker date2;
		private System.Windows.Forms.DateTimePicker date1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
		private System.Windows.Forms.DataGridViewTextBoxColumn Buoi;
		private System.Windows.Forms.DataGridViewTextBoxColumn QuanSo;
		private System.Windows.Forms.DataGridViewTextBoxColumn MonAn;
	}
}