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
    public partial class frTaiKhoan : Form
    {
        public frTaiKhoan()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frTaiKhoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_getData.getTable("proc_getAllTaikhoan");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtMatkhau.Text = "";
            txtMatkhau.Text = "";
            cbbManv.SelectedIndex = -1;
            cbbRole.SelectedIndex = -1;
        }
    }
}
