namespace QLBanHangDienTu
{
    partial class UC_Search_Hoadonnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Search_Hoadonnhap));
            this.tbHDN = new System.Windows.Forms.DataGridView();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grTime = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbNhacungcap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMahang = new System.Windows.Forms.ComboBox();
            this.btnLammoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTimkiem = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.tbHDN)).BeginInit();
            this.grTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHDN
            // 
            this.tbHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbHDN.BackgroundColor = System.Drawing.Color.White;
            this.tbHDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbHDN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbHDN.Location = new System.Drawing.Point(26, 387);
            this.tbHDN.Name = "tbHDN";
            this.tbHDN.ReadOnly = true;
            this.tbHDN.RowHeadersWidth = 51;
            this.tbHDN.RowTemplate.Height = 24;
            this.tbHDN.Size = new System.Drawing.Size(849, 310);
            this.tbHDN.TabIndex = 42;
            // 
            // dtpDen
            // 
            this.dtpDen.CustomFormat = "dd-MM-yyyy";
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDen.Location = new System.Drawing.Point(418, 41);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(133, 30);
            this.dtpDen.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Từ";
            // 
            // dtpTu
            // 
            this.dtpTu.CustomFormat = "dd-MM-yyyy";
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTu.Location = new System.Drawing.Point(127, 46);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(127, 30);
            this.dtpTu.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Đến";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(234, 160);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(234, 29);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "Tìm kiếm theo thời gian";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grTime
            // 
            this.grTime.Controls.Add(this.dtpDen);
            this.grTime.Controls.Add(this.label11);
            this.grTime.Controls.Add(this.dtpTu);
            this.grTime.Controls.Add(this.label1);
            this.grTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grTime.Location = new System.Drawing.Point(220, 209);
            this.grTime.Name = "grTime";
            this.grTime.Size = new System.Drawing.Size(581, 99);
            this.grTime.TabIndex = 45;
            this.grTime.TabStop = false;
            this.grTime.Text = "Tìm kiếm theo thời gian";
            this.grTime.Enter += new System.EventHandler(this.grTime_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nhà cung cấp";
            // 
            // cbbNhacungcap
            // 
            this.cbbNhacungcap.FormattingEnabled = true;
            this.cbbNhacungcap.Location = new System.Drawing.Point(409, 102);
            this.cbbNhacungcap.Name = "cbbNhacungcap";
            this.cbbNhacungcap.Size = new System.Drawing.Size(282, 33);
            this.cbbNhacungcap.TabIndex = 40;
            this.cbbNhacungcap.DropDown += new System.EventHandler(this.CbbMaNCC_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Mã hàng";
            // 
            // cbbMahang
            // 
            this.cbbMahang.FormattingEnabled = true;
            this.cbbMahang.Location = new System.Drawing.Point(409, 45);
            this.cbbMahang.Name = "cbbMahang";
            this.cbbMahang.Size = new System.Drawing.Size(282, 33);
            this.cbbMahang.TabIndex = 38;
            this.cbbMahang.DropDown += new System.EventHandler(this.CbbMahang_DropDown);
            // 
            // btnLammoi
            // 
            this.btnLammoi.ActiveBorderThickness = 1;
            this.btnLammoi.ActiveCornerRadius = 20;
            this.btnLammoi.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnLammoi.ActiveForecolor = System.Drawing.Color.White;
            this.btnLammoi.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnLammoi.BackColor = System.Drawing.Color.White;
            this.btnLammoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLammoi.BackgroundImage")));
            this.btnLammoi.ButtonText = "Làm mới";
            this.btnLammoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnLammoi.IdleBorderThickness = 1;
            this.btnLammoi.IdleCornerRadius = 20;
            this.btnLammoi.IdleFillColor = System.Drawing.Color.White;
            this.btnLammoi.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnLammoi.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnLammoi.Location = new System.Drawing.Point(559, 316);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(127, 42);
            this.btnLammoi.TabIndex = 52;
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.ActiveBorderThickness = 1;
            this.btnTimkiem.ActiveCornerRadius = 20;
            this.btnTimkiem.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnTimkiem.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimkiem.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.BackgroundImage")));
            this.btnTimkiem.ButtonText = "Tìm kiếm";
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnTimkiem.IdleBorderThickness = 1;
            this.btnTimkiem.IdleCornerRadius = 20;
            this.btnTimkiem.IdleFillColor = System.Drawing.Color.White;
            this.btnTimkiem.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnTimkiem.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnTimkiem.Location = new System.Drawing.Point(320, 316);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(127, 42);
            this.btnTimkiem.TabIndex = 53;
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // UC_Search_Hoadonnhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.tbHDN);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.grTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbNhacungcap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbMahang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "UC_Search_Hoadonnhap";
            this.Size = new System.Drawing.Size(1200, 720);
            this.Load += new System.EventHandler(this.UC_Search_Hoadonnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbHDN)).EndInit();
            this.grTime.ResumeLayout(false);
            this.grTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tbHDN;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbNhacungcap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMahang;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLammoi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimkiem;
    }
}
