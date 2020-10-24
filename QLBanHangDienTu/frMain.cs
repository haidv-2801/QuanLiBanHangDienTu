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

        private void NhàcungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frNhaCungCap frNcc = new frNhaCungCap();
            frNcc.MdiParent = this;
            frNcc.Dock = DockStyle.Fill;
            frNcc.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frNhanVien frnv = new frNhanVien();
            frnv.MdiParent = this;
            frnv.Dock = DockStyle.Fill;
            frnv.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frKhachHang frkh = new frKhachHang();
            frkh.MdiParent = this;
            frkh.Dock = DockStyle.Fill;
            frkh.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frHoaDonBan frhdb = new frHoaDonBan();
            frhdb.MdiParent = this;
            frhdb.Dock = DockStyle.Fill;
            frhdb.Show();
        }

        private void hóaĐơnBánToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frTimKiemHDB frhdb = new frTimKiemHDB();
            frhdb.MdiParent = this;
            frhdb.Dock = DockStyle.Fill;
            frhdb.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frTimKiemHDN frhdn = new frTimKiemHDN();
            frhdn.MdiParent = this;
            frhdn.Dock = DockStyle.Fill;
            frhdn.Show();
        }

      
        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frReport1 frBCHanghoa = new frReport1();
            frBCHanghoa.MdiParent = this;
            frBCHanghoa.Dock = DockStyle.Fill;
            frBCHanghoa.Show();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frReport2 frBCHoadon = new frReport2();
            frBCHoadon.MdiParent = this;
            frBCHoadon.Dock = DockStyle.Fill;
            frBCHoadon.Show();
        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frReport3 frBCDoanhthu = new frReport3();
            frBCDoanhthu.MdiParent = this;
            frBCDoanhthu.Dock = DockStyle.Fill;
            frBCDoanhthu.Show();
        }

        private void báoCáoNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDuplicateForm();
            frReport4 frBCNCC = new frReport4();
            frBCNCC.MdiParent = this;
            frBCNCC.Dock = DockStyle.Fill;
            frBCNCC.Show();
        }
    }
}
