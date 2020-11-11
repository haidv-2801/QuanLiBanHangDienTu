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
    public partial class UC_Timkiem : UserControl
    {
        public UC_Timkiem()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            searchRightPanel.Controls.Clear();
            searchRightPanel.Controls.Add(c);
        }

        private void btnHanghoa_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_Search_Hanghoa());
        }

        private void btnHoadonnhap_Click(object sender, EventArgs e)
        {
            AddControlsToPanel(new UC_Search_Hoadonnhap());
        }
    }
}
