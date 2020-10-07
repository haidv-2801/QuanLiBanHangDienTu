using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Handling;


namespace QLBanHangDienTu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void HàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frDMHanghoa frHH = new frDMHanghoa();
            frHH.MdiParent = this;
            frHH.Dock = DockStyle.Fill;
            frHH.Show();
        }

        private void closeDuplicateForm()
        {
            if (this.MdiChildren.FirstOrDefault() != null)
                this.MdiChildren.FirstOrDefault().Close();
        }
        private void HóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frHoaDonNhap frhdn = new frHoaDonNhap();
            frhdn.MdiParent = this;
            frhdn.Dock = DockStyle.Fill;
            frhdn.Show();
        }
        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
