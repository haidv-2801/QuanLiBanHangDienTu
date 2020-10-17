namespace QLBanHangDienTu
{
    partial class frTimKiemHDB
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
            this.dtpNgaytao = new System.Windows.Forms.DateTimePicker();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.tbHDN = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbKhachhang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMahang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgaytao
            // 
            this.dtpNgaytao.CustomFormat = "yyyy-MM-dd";
            this.dtpNgaytao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaytao.Location = new System.Drawing.Point(413, 156);
            this.dtpNgaytao.Name = "dtpNgaytao";
            this.dtpNgaytao.Size = new System.Drawing.Size(222, 22);
            this.dtpNgaytao.TabIndex = 41;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(488, 242);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(102, 28);
            this.btnLammoi.TabIndex = 40;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(282, 242);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(84, 28);
            this.btnTimkiem.TabIndex = 39;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // tbHDN
            // 
            this.tbHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbHDN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbHDN.Location = new System.Drawing.Point(12, 333);
            this.tbHDN.Name = "tbHDN";
            this.tbHDN.ReadOnly = true;
            this.tbHDN.RowHeadersWidth = 51;
            this.tbHDN.RowTemplate.Height = 24;
            this.tbHDN.Size = new System.Drawing.Size(976, 310);
            this.tbHDN.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Ngày tạo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Khách hàng";
            // 
            // cbbKhachhang
            // 
            this.cbbKhachhang.FormattingEnabled = true;
            this.cbbKhachhang.Location = new System.Drawing.Point(413, 93);
            this.cbbKhachhang.Name = "cbbKhachhang";
            this.cbbKhachhang.Size = new System.Drawing.Size(187, 24);
            this.cbbKhachhang.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Mã hàng";
            // 
            // cbbMahang
            // 
            this.cbbMahang.FormattingEnabled = true;
            this.cbbMahang.Location = new System.Drawing.Point(413, 36);
            this.cbbMahang.Name = "cbbMahang";
            this.cbbMahang.Size = new System.Drawing.Size(187, 24);
            this.cbbMahang.TabIndex = 33;
            // 
            // frTimKiemHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 679);
            this.Controls.Add(this.dtpNgaytao);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.tbHDN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbKhachhang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbMahang);
            this.Name = "frTimKiemHDB";
            this.Text = "frTimKiemHDB";
            ((System.ComponentModel.ISupportInitialize)(this.tbHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgaytao;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView tbHDN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbKhachhang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMahang;
    }
}