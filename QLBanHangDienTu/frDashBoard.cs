using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangDienTu
{
    public partial class frDashBoard : Form
    {
        int panelLeftWith;
        public frDashBoard()
        {
            InitializeComponent();
            panelLeftWith = panelLeft.Width;
        }

        private void frDashBoard_Load(object sender, EventArgs e)
        {

            username.Text = frDangNhap.taiKhoan.TenTaiKhoan;
            role.Text = frDangNhap.taiKhoan.PhanQuyen == 0 ? "Admin" : "Nhân viên";

            if(role.Text == "Admin") { control(true); }
            else { control(false); }

            UC_Home uC_Home = new UC_Home();
            pnBody.Controls.Add(uC_Home);

            timer1.Start();
        }

        private void control(bool status)
        {
            btnHanghoa.Enabled = status;
            btnNhanvien.Enabled = status;
            btnBaocao.Enabled = status;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString();
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void collapse_Click(object sender, EventArgs e)
        {
            if(panelLeft.Width <= 55)
            {
                while(panelLeft.Width < 219)
                {
                    panelLeft.Width++;
                    pictureBox1.Width++;
                }
                return;
            }
            while(panelLeft.Width > 55)
            {
                panelLeft.Width--;
                pictureBox1.Width--;
            }    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            movePanels(btn);

            this.Hide();
            frDangNhap frLogin = new frDangNhap();
            frLogin.Show();
        }

        private void movePanels(Control ctl)
        {
            movePanel.Top = ctl.Top;
            movePanel.Height = ctl.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnBody.Controls.Clear();
            pnBody.Controls.Add(c);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            movePanels(btn);

            UC_Home uC_Home = new UC_Home();
            AddControlsToPanel(uC_Home);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            movePanels(btn);

            UC_Hanghoa uC_Hanghoa = new UC_Hanghoa();
            AddControlsToPanel(uC_Hanghoa);
        }

        private void btnHoadonnhap_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            movePanels(btn);

            AddControlsToPanel(new UC_Hoadonnhap());
        }

        private void btnHoadonban_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            movePanels(btn);

            AddControlsToPanel(new UC_Hoadonban());
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            movePanels(btn);

            UC_Nhanvien uC_Nhanvien = new UC_Nhanvien();
            AddControlsToPanel(uC_Nhanvien);
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            movePanels(btn);

            AddControlsToPanel(new UC_Baocao());
            //animationPanel(pnBottomLeft, 135, 317);

        }

        private void animationPanel(Panel panel, int lower, int upper)
        {
            if (panel.Height < upper)
            {
                while (panel.Height < upper) panel.Height++;
                return;
            }

            while (panel.Height > lower) panel.Height--;

        }

        private void btnTimkiem_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            movePanels(btn);

            UC_Timkiem1 uC_Timkiem = new UC_Timkiem1();
            AddControlsToPanel(uC_Timkiem);
           // animationPanel(pnFlowDownSearch, 200, 268);
        }

        private void customer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            movePanels(btn);

            AddControlsToPanel(new UC_Khachhang());
        }
    }
}
