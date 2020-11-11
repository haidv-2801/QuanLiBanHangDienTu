using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangDienTu
{
    public partial class UC_Baocao : UserControl
    {
        public UC_Baocao()
        {
            InitializeComponent();
        }

        private void addControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(c);
        }

        private void btnHanghoa_Click(object sender, EventArgs e)
        {
            addControlToPanel(new UC_Baocao_Sanpham());
        }

        private void btnHoadonnhap_Click(object sender, EventArgs e)
        {
            addControlToPanel(new UC_Baocao_Hoadonnhap());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addControlToPanel(new UC_Baocao_NCC());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addControlToPanel(new UC_Baocao_Doanhthu());
        }
    }
}
