using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Object;

namespace QLBanHangDienTu
{
    public partial class frDoiMatKhau : Form
    {
        public frDoiMatKhau()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool checkAll()
        {
            if (string.IsNullOrEmpty(txtMkcu.Text))
            {
                MessageBox.Show("Nhập mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMkcu.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtMkmoi4.Text))
            {
                MessageBox.Show("Nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMkmoi4.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtRemk.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRemk.Focus();
                return false;
            }

            return true;
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            if (!checkAll())
                return;
        
            DataTable tb = BLL_getData.getTableById("proc_getTaikhoanById", txtTaikhoan.Text);
     
            if(tb.Rows.Count > 0)
            {
                string userName = tb.Rows[0][0].ToString();
                string passWord = tb.Rows[0][1].ToString();
                string status = tb.Rows[0][2].ToString();
                string role = tb.Rows[0][3].ToString();

                if (passWord != txtMkcu.Text)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMkcu.Focus();
                    txtMkcu.Text = string.Empty;
                    return;
                }
              
                if (txtMkmoi4.Text != txtRemk.Text)
                {
                    MessageBox.Show("Mật khẩu mới phải giống nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMkmoi4.Focus();
                    return;
                }

                TaiKhoan taiKhoan = new TaiKhoan(
                    txtTaikhoan.Text,
                    txtMkmoi4.Text,
                    int.Parse(status),
                    int.Parse(role)
                    );
                BLL_TaiKhoan.update(taiKhoan);
                MessageBox.Show($"Cập nhật thành công {txtTaikhoan.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            clear();
            
        }
        private void clear()
        {
            txtMkcu.Text = "";
            txtMkmoi4.Text = "";
            txtRemk.Text = "";
            txtTaikhoan.Text = "";
        }
    }
}
