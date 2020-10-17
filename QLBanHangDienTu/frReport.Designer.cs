namespace QLBanHangDienTu
{
    partial class frReport
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.QLBanHangDienTu_bantestDataSet = new QLBanHangDienTu.QLBanHangDienTu_bantestDataSet();
            this.tbDMHanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDMHanghoaTableAdapter = new QLBanHangDienTu.QLBanHangDienTu_bantestDataSetTableAdapters.tbDMHanghoaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.QLBanHangDienTu_bantestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDMHanghoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(319, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(531, 106);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(76, 34);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // QLBanHangDienTu_bantestDataSet
            // 
            this.QLBanHangDienTu_bantestDataSet.DataSetName = "QLBanHangDienTu_bantestDataSet";
            this.QLBanHangDienTu_bantestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDMHanghoaBindingSource
            // 
            this.tbDMHanghoaBindingSource.DataMember = "tbDMHanghoa";
            this.tbDMHanghoaBindingSource.DataSource = this.QLBanHangDienTu_bantestDataSet;
            // 
            // tbDMHanghoaTableAdapter
            // 
            this.tbDMHanghoaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 219);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(977, 448);
            this.reportViewer1.TabIndex = 2;
            // 
            // frReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 679);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.comboBox1);
            this.Name = "frReport";
            this.Text = "frReport";
            this.Load += new System.EventHandler(this.frReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBanHangDienTu_bantestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDMHanghoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.BindingSource tbDMHanghoaBindingSource;
        private QLBanHangDienTu_bantestDataSet QLBanHangDienTu_bantestDataSet;
        private QLBanHangDienTu_bantestDataSetTableAdapters.tbDMHanghoaTableAdapter tbDMHanghoaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}