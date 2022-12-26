
namespace KHOD.GUI
{
    partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.txtCheck = new DevExpress.XtraEditors.CheckEdit();
			this.txtMK = new System.Windows.Forms.TextBox();
			this.txtDN = new System.Windows.Forms.TextBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCheck.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Controls.Add(this.btnThoat);
			this.panelControl1.Controls.Add(this.pictureEdit1);
			this.panelControl1.Controls.Add(this.txtCheck);
			this.panelControl1.Controls.Add(this.txtMK);
			this.panelControl1.Controls.Add(this.txtDN);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(576, 405);
			this.panelControl1.TabIndex = 0;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simpleButton1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.Appearance.Options.UseForeColor = true;
			this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
			this.simpleButton1.Location = new System.Drawing.Point(392, 287);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.simpleButton1.Size = new System.Drawing.Size(172, 49);
			this.simpleButton1.TabIndex = 8;
			this.simpleButton1.Text = "Đăng nhập";
			// 
			// btnThoat
			// 
			this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnThoat.Appearance.Options.UseFont = true;
			this.btnThoat.Appearance.Options.UseForeColor = true;
			this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
			this.btnThoat.Location = new System.Drawing.Point(220, 287);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(144, 49);
			this.btnThoat.TabIndex = 7;
			this.btnThoat.Text = "Thoát";
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(23, 188);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new System.Drawing.Size(176, 148);
			this.pictureEdit1.TabIndex = 6;
			// 
			// txtCheck
			// 
			this.txtCheck.Location = new System.Drawing.Point(236, 185);
			this.txtCheck.Name = "txtCheck";
			this.txtCheck.Properties.Caption = "Hiển thị mật khẩu";
			this.txtCheck.Size = new System.Drawing.Size(163, 24);
			this.txtCheck.TabIndex = 5;
			// 
			// txtMK
			// 
			this.txtMK.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMK.Location = new System.Drawing.Point(236, 132);
			this.txtMK.Name = "txtMK";
			this.txtMK.Size = new System.Drawing.Size(328, 35);
			this.txtMK.TabIndex = 4;
			this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
			// 
			// txtDN
			// 
			this.txtDN.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDN.Location = new System.Drawing.Point(236, 77);
			this.txtDN.Name = "txtDN";
			this.txtDN.Size = new System.Drawing.Size(328, 35);
			this.txtDN.TabIndex = 3;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseBackColor = true;
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(23, 138);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(99, 29);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "Mật khẩu";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseBackColor = true;
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(23, 83);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(161, 29);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Tên đăng nhập";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseBackColor = true;
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(220, 3);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(116, 29);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Đăng nhập";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 405);
			this.Controls.Add(this.panelControl1);
			this.Name = "frmLogin";
			this.Text = "Đăng nhập";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCheck.Properties)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtDN;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.CheckEdit txtCheck;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}