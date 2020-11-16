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
using Object;

namespace QLBanHangDienTu
{
    public partial class frDangNhap : Form
    {
        public static TaiKhoan taiKhoan = new TaiKhoan();

        public frDangNhap()
        {
            InitializeComponent();
            txtTaikhoan.Focus();
        }

        private void frDangNhap_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtTaikhoan.Focus();
        }

        private bool checkAll()
        {
            if (string.IsNullOrEmpty(txtTaikhoan.Text))
            {
                MessageBox.Show("Nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaikhoan.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaikhoan.Focus();
                return false;
            }

            return true;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (checkAll() == false)
                return;

            DataTable tb = BLL_getData.getTableById("proc_getTaikhoanById", txtTaikhoan.Text);
           

            if(tb.Rows.Count <= 0)
            {
                MessageBox.Show("Tài khoản chưa tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //MessageBox.Show(tb.Rows[0]["MatKhau"].ToString());
                if (txtMatkhau.Text != tb.Rows[0]["MatKhau"].ToString())
                {
                    MessageBox.Show("Mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    string userName = tb.Rows[0][0].ToString();
                    string passWord = tb.Rows[0][1].ToString();
                    string status = tb.Rows[0][2].ToString();
                    string role = tb.Rows[0][3].ToString();

                    taiKhoan.TenTaiKhoan = userName;
                    taiKhoan.MatKhau = passWord;
                    taiKhoan.TrangThai = int.Parse(status);
                    taiKhoan.PhanQuyen = int.Parse(role);

                    // MessageBox.Show("test");
                    this.Hide();
                    frDashBoard frmain = new frDashBoard();
                    frmain.Show();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnDangnhap_Click(null, null);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();   
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            currentTime.Text = DateTime.Now.ToShortTimeString();
            currentDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
