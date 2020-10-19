﻿using DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QLBanHangDienTu
{
    public partial class frReport : Form
    {
        public frReport()
        {
            InitializeComponent();
        }

        private void frReport_Load(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cbbManv.SelectedIndex == -1)
                return;
            DataSet ds = getDataDAL.SPBanChayNhat(cbbManv.SelectedValue.ToString());
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblempty.Visible = false;
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "rds";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else
            {
                this.reportViewer1.Reset();
                lblempty.Visible = true;
            }
        }
        DataTable tbnv;
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            tbnv = BLL_getData.getTable("pro_getAllNhanvien");
            fillComboBox(tbnv, cbbManv, "MaNV", "Tennhanvien");
        }

        private void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        private void fillComboBox(DataTable table, ComboBox cmb, string ma, string ten)
        {
            string newc = "NameAndCode";
            AddMultipleColumn(table, newc, ma, ten);
            cmb.DataSource = table;
            cmb.ValueMember = ma;
            cmb.DisplayMember = newc;
            cmb.SelectedIndex = 0;
        }
    }
}
