using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Handling;
using Object;

namespace QLBanHangDienTu
{
    public partial class UC_Khachhang : UserControl
    {
        int index = -1;
        public UC_Khachhang()
        {
            InitializeComponent();
        }

        private void txtMakh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMakh.Text = Automatically.autoGetKey("select dbo.getKeyKhachhang()").Trim();
        }

        private void showTableKhachhang()
        {
            dgvKhachang.DataSource = BLL_getData.getTable("pro_getAllKhachhang");
            dgvKhachang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachang.Columns[3].HeaderText = "Điện thoại";
        }

        private void frKhachHang_Load(object sender, EventArgs e)
        {
            showTableKhachhang();
        }

        private bool checkAll()
        {
            if (txtMakh.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có mã khách hàng?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakh.Focus();
                return false;
            }

            if (txtTenkh.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có tên khách hàng?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenkh.Focus();
                return false;
            }

            if (rtbDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có địa chỉ khách hàng?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbDiachi.Focus();
                return false;
            }

            if (txtDienthoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có SĐT khách hàng?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienthoai.Focus();
                return false;
            }

            return true;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dgvKhachang.Rows.Count - 1)
            {
                string id = dgvKhachang.Rows[index].Cells[0].Value.ToString();
                DialogResult res = MessageBox.Show($"Muốn xóa khách hàng {id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    BLL_KhachHang.delete(id);
                    dgvKhachang.Rows.RemoveAt(index);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dgvKhachang.Rows.Count - 1)
            {
                if (checkAll() == false)
                    return;

                Obj_KhachHang obj_KhachHang
                   = new Obj_KhachHang(txtMakh.Text, txtTenkh.Text, rtbDiachi.Text, txtDienthoai.Text);
                BLL_KhachHang.update(obj_KhachHang);
                showTableKhachhang();

            }
            else
            {
                MessageBox.Show($"Chọn khách hàng để sửa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvKhachang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && index < dgvKhachang.Rows.Count - 1)
            {
                txtMakh.Text = dgvKhachang.Rows[index].Cells[0].Value.ToString();
                txtTenkh.Text = dgvKhachang.Rows[index].Cells[1].Value.ToString();
                rtbDiachi.Text = dgvKhachang.Rows[index].Cells[2].Value.ToString();
                txtDienthoai.Text = dgvKhachang.Rows[index].Cells[3].Value.ToString();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkAll() == false)
                return;

            bool entryFound = false;

            for (int i = 0; i < dgvKhachang.Rows.Count - 1; i++)
            {
                if (dgvKhachang.Rows[i].Cells[0].Value.ToString() == txtMakh.Text) { entryFound = true; break; }
            }

            if(entryFound == true)
            {
                MessageBox.Show($"Tồn tại khách hàng {txtMakh.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Obj_KhachHang obj_KhachHang = new Obj_KhachHang(
               txtMakh.Text,
               txtTenkh.Text,
               rtbDiachi.Text,
               txtDienthoai.Text
               );
                BLL_KhachHang.insert(obj_KhachHang);
                showTableKhachhang();
                MessageBox.Show($"Thêm thành công khách hàng {txtMakh.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }


        private void btnRefesh_Click(object sender, EventArgs e)
        {
            txtTenkh.Text = "";
            txtMakh.Text = "";
            txtDienthoai.Text = "";
            rtbDiachi.Text = "";
        }
    }
}
