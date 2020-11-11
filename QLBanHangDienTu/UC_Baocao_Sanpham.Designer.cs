namespace QLBanHangDienTu
{
    partial class UC_Baocao_Sanpham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Baocao_Sanpham));
            this.lblempty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbManv = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lblempty
            // 
            this.lblempty.AutoSize = true;
            this.lblempty.Location = new System.Drawing.Point(364, 437);
            this.lblempty.Name = "lblempty";
            this.lblempty.Size = new System.Drawing.Size(158, 25);
            this.lblempty.TabIndex = 16;
            this.lblempty.Text = "Không có dữ liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nhân viên";
            // 
            // cbbManv
            // 
            this.cbbManv.FormattingEnabled = true;
            this.cbbManv.Location = new System.Drawing.Point(268, 155);
            this.cbbManv.Name = "cbbManv";
            this.cbbManv.Size = new System.Drawing.Size(249, 33);
            this.cbbManv.TabIndex = 13;
            this.cbbManv.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(20, 258);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(854, 446);
            this.reportViewer1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(150, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(668, 59);
            this.label4.TabIndex = 59;
            this.label4.Text = "TOP 3 sản phẩm bán nhiều nhất";
            // 
            // btnChon
            // 
            this.btnChon.ActiveBorderThickness = 1;
            this.btnChon.ActiveCornerRadius = 20;
            this.btnChon.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnChon.ActiveForecolor = System.Drawing.Color.White;
            this.btnChon.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnChon.BackColor = System.Drawing.Color.White;
            this.btnChon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChon.BackgroundImage")));
            this.btnChon.ButtonText = "Xem";
            this.btnChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnChon.IdleBorderThickness = 1;
            this.btnChon.IdleCornerRadius = 20;
            this.btnChon.IdleFillColor = System.Drawing.Color.White;
            this.btnChon.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnChon.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnChon.Location = new System.Drawing.Point(560, 146);
            this.btnChon.Margin = new System.Windows.Forms.Padding(5);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(127, 42);
            this.btnChon.TabIndex = 60;
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // UC_Baocao_Sanpham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblempty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbManv);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Baocao_Sanpham";
            this.Size = new System.Drawing.Size(894, 720);
            this.Load += new System.EventHandler(this.UC_Baocao_Sanpham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblempty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbManv;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChon;
    }
}
