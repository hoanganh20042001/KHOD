
namespace KHOD.GUI
{
	partial class frmSaoLuu
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaoLuu));
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.txtDuongDan = new System.Windows.Forms.TextBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtDBName = new System.Windows.Forms.TextBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Location = new System.Drawing.Point(2, 6);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(72, 256);
			this.panelControl1.TabIndex = 0;
			// 
			// panelControl2
			// 
			this.panelControl2.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelControl2.Appearance.Options.UseBackColor = true;
			this.panelControl2.Controls.Add(this.txtDuongDan);
			this.panelControl2.Controls.Add(this.labelControl2);
			this.panelControl2.Controls.Add(this.txtDBName);
			this.panelControl2.Controls.Add(this.labelControl1);
			this.panelControl2.Location = new System.Drawing.Point(80, 12);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(550, 250);
			this.panelControl2.TabIndex = 1;
			this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
			// 
			// txtDuongDan
			// 
			this.txtDuongDan.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDuongDan.Location = new System.Drawing.Point(69, 133);
			this.txtDuongDan.Name = "txtDuongDan";
			this.txtDuongDan.Size = new System.Drawing.Size(353, 35);
			this.txtDuongDan.TabIndex = 5;
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
			this.labelControl2.Location = new System.Drawing.Point(69, 35);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(99, 28);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Tên CSDL";
			// 
			// txtDBName
			// 
			this.txtDBName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDBName.Location = new System.Drawing.Point(69, 69);
			this.txtDBName.Name = "txtDBName";
			this.txtDBName.Size = new System.Drawing.Size(353, 35);
			this.txtDBName.TabIndex = 3;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.labelControl1.Appearance.Options.UseBackColor = true;
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.ImeMode = System.Windows.Forms.ImeMode.On;
			this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.labelControl1.Location = new System.Drawing.Point(202, -6);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(152, 28);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Sao lưu dữ liệu";
			this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
			// 
			// simpleButton1
			// 
			this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
			this.simpleButton1.Location = new System.Drawing.Point(10, 11);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(57, 48);
			this.simpleButton1.TabIndex = 0;
			this.simpleButton1.Text = "simpleButton1";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// frmSaoLuu
			// 
			this.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 260);
			this.Controls.Add(this.panelControl2);
			this.Controls.Add(this.panelControl1);
			this.Name = "frmSaoLuu";
			this.Text = "Sao lưu dữ liệu";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.panelControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
		private System.Windows.Forms.TextBox txtDuongDan;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.TextBox txtDBName;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}