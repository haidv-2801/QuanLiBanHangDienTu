namespace QLBanHangDienTu
{
    partial class frReport1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnChon = new System.Windows.Forms.Button();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.QLBanHangDienTu_bantestDataSet = new QLBanHangDienTu.QLBanHangDienTu_bantestDataSet();
            this.tbDMHanghoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDMHanghoaTableAdapter = new QLBanHangDienTu.QLBanHangDienTu_bantestDataSetTableAdapters.tbDMHanghoaTableAdapter();
            this.lblempty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLBanHangDienTu_bantestDataSet1 = new QLBanHangDienTu.QLBanHangDienTu_bantestDataSet1();
            this.pro_getDataForQuestion7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pro_getDataForQuestion7TableAdapter = new QLBanHangDienTu.QLBanHangDienTu_bantestDataSet1TableAdapters.pro_getDataForQuestion7TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLBanHangDienTu_bantestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDMHanghoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBanHangDienTu_bantestDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_getDataForQuestion7BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(646, 102);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(76, 34);
            this.btnChon.TabIndex = 7;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(305, 108);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(319, 24);
            this.cbbNCC.TabIndex = 6;
            this.cbbNCC.DropDown += new System.EventHandler(this.comboBox1_DropDown);
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
            // lblempty
            // 
            this.lblempty.AutoSize = true;
            this.lblempty.Location = new System.Drawing.Point(423, 437);
            this.lblempty.Name = "lblempty";
            this.lblempty.Size = new System.Drawing.Size(114, 17);
            this.lblempty.TabIndex = 11;
            this.lblempty.Text = "Không có dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(997, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "DANH SÁCH HÓA ĐƠN VÀ TỔNG TIỀN NHẬP HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhà cung cấp";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pro_getDataForQuestion7BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLBanHangDienTu.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 219);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(977, 448);
            this.reportViewer1.TabIndex = 8;
            // 
            // QLBanHangDienTu_bantestDataSet1
            // 
            this.QLBanHangDienTu_bantestDataSet1.DataSetName = "QLBanHangDienTu_bantestDataSet1";
            this.QLBanHangDienTu_bantestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pro_getDataForQuestion7BindingSource
            // 
            this.pro_getDataForQuestion7BindingSource.DataMember = "pro_getDataForQuestion7";
            this.pro_getDataForQuestion7BindingSource.DataSource = this.QLBanHangDienTu_bantestDataSet1;
            // 
            // pro_getDataForQuestion7TableAdapter
            // 
            this.pro_getDataForQuestion7TableAdapter.ClearBeforeFill = true;
            // 
            // frReport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 679);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cbbNCC);
            this.Controls.Add(this.lblempty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frReport1";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frReport1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBanHangDienTu_bantestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDMHanghoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBanHangDienTu_bantestDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pro_getDataForQuestion7BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ComboBox cbbNCC;
        private QLBanHangDienTu_bantestDataSet QLBanHangDienTu_bantestDataSet;
        private System.Windows.Forms.BindingSource tbDMHanghoaBindingSource;
        private QLBanHangDienTu_bantestDataSetTableAdapters.tbDMHanghoaTableAdapter tbDMHanghoaTableAdapter;
        private System.Windows.Forms.Label lblempty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pro_getDataForQuestion7BindingSource;
        private QLBanHangDienTu_bantestDataSet1 QLBanHangDienTu_bantestDataSet1;
        private QLBanHangDienTu_bantestDataSet1TableAdapters.pro_getDataForQuestion7TableAdapter pro_getDataForQuestion7TableAdapter;
    }
}