namespace QLBanHangDienTu
{
    partial class UC_Timkiem1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Timkiem1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHoadonnhap = new System.Windows.Forms.Button();
            this.btnHanghoa = new System.Windows.Forms.Button();
            this.searchRightPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnHoadonnhap);
            this.panel1.Controls.Add(this.btnHanghoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 720);
            this.panel1.TabIndex = 0;
            // 
            // btnHoadonnhap
            // 
            this.btnHoadonnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadonnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadonnhap.Image = ((System.Drawing.Image)(resources.GetObject("btnHoadonnhap.Image")));
            this.btnHoadonnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadonnhap.Location = new System.Drawing.Point(37, 229);
            this.btnHoadonnhap.Name = "btnHoadonnhap";
            this.btnHoadonnhap.Size = new System.Drawing.Size(233, 53);
            this.btnHoadonnhap.TabIndex = 4;
            this.btnHoadonnhap.Text = "Hóa đơn nhập";
            this.btnHoadonnhap.UseVisualStyleBackColor = true;
            this.btnHoadonnhap.Click += new System.EventHandler(this.btnHoadonnhap_Click);
            // 
            // btnHanghoa
            // 
            this.btnHanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHanghoa.Image = ((System.Drawing.Image)(resources.GetObject("btnHanghoa.Image")));
            this.btnHanghoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHanghoa.Location = new System.Drawing.Point(37, 142);
            this.btnHanghoa.Name = "btnHanghoa";
            this.btnHanghoa.Size = new System.Drawing.Size(233, 53);
            this.btnHanghoa.TabIndex = 5;
            this.btnHanghoa.Text = "Hàng hóa";
            this.btnHanghoa.UseVisualStyleBackColor = true;
            this.btnHanghoa.Click += new System.EventHandler(this.btnHanghoa_Click);
            // 
            // searchRightPanel
            // 
            this.searchRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchRightPanel.Location = new System.Drawing.Point(423, 0);
            this.searchRightPanel.Name = "searchRightPanel";
            this.searchRightPanel.Size = new System.Drawing.Size(777, 720);
            this.searchRightPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Location = new System.Drawing.Point(374, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 719);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(27, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 59);
            this.label4.TabIndex = 58;
            this.label4.Text = "Tìm kiếm";
            // 
            // UC_Timkiem1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.searchRightPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Timkiem1";
            this.Size = new System.Drawing.Size(1200, 720);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel searchRightPanel;
        private System.Windows.Forms.Button btnHoadonnhap;
        private System.Windows.Forms.Button btnHanghoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}
