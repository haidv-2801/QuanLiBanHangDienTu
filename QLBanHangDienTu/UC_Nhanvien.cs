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
    public partial class UC_Nhanvien : UserControl
    {
        int index = -1;

        public UC_Nhanvien()
        {
            InitializeComponent();
        }

        private void UC_Nhanvien_Load(object sender, EventArgs e)
        {
            rdbNu.Checked = true;
            cbbMaca_DropDown(null, null);
            cbbMacv_DropDown(null, null);

            tbCongviec.DataSource = BLL_getData.getTable("pro_getAllCongviec");
            tbCongviec.Columns[0].HeaderText = "Mã công việc";
            tbCongviec.Columns[1].HeaderText = "Tên công việc";

            tbCalam.DataSource = BLL_getData.getTable("pro_getAllCalam");
            tbCalam.Columns[0].HeaderText = "Mã ca làm";
            tbCalam.Columns[1].HeaderText = "Tên ca làm";

            showTableNhanvien();
        }

        private void showTableNhanvien()
        {
            dgvNhanvien.DataSource = BLL_getData.getTable("proc_getDataFromNhanvien");
            dgvNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanvien.Columns[2].HeaderText = "Giới tính";
            dgvNhanvien.Columns[3].HeaderText = "Ngày sinh";
            dgvNhanvien.Columns[4].HeaderText = "Điện thoại";
            dgvNhanvien.Columns[5].HeaderText = "Địa chỉ";
            dgvNhanvien.Columns[6].HeaderText = "Mã ca";
            dgvNhanvien.Columns[7].HeaderText = "Mã công việc";
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtManv.Text = Automatically.autoGetKey("select dbo.getKeyNhanvien()").Trim();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {
            txtManv.Text = "";
            txtTennv.Text = "";
            cbbMaca.SelectedIndex = -1;
            cbbMacv.SelectedIndex = -1;
            txtDienthoai.Text = "";
            txtDiachi.Text = "";
            rdbNu.Checked = true;
        }

        private bool checkAll()
        {
            if (txtManv.Text.Trim() == "")
            {
                MessageBox.Show("Tạo mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnTaomoi.Focus();
                return false;
            }

            if (txtTennv.Text.Trim() == "")
            {
                MessageBox.Show("Nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTennv.Focus();
                return false;
            }

            if (cbbMacv.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMacv.Focus();
                return false;
            }

            if (txtDienthoai.Text.Trim() == "")
            {
                MessageBox.Show("Nhập điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienthoai.Focus();
                return false;
            }

            if (txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return false;
            }

            if (cbbMaca.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn ca!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMaca.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkAll() == false)
                return;

            //bool entryFound = dgvNhanvien.Rows.Cast<DataGridViewRow>().Any(x => (x.Cells[0].Value == DBNull.Value ? null : x.Cells[0].Value.ToString()) == txtManv.Text);

            bool entryFound = false;

            for (int i = 0; i < dgvNhanvien.Rows.Count - 1; i++)
            {
                if (dgvNhanvien.Rows[i].Cells[0].Value.ToString() == txtManv.Text) { entryFound = true; break; }
            }

            if (entryFound == true)
            {
                MessageBox.Show($"Đã tồn tại nhân viên {txtManv.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Obj_NhanVien obj_NhanVien = new Obj_NhanVien(
               txtManv.Text,
               txtTennv.Text,
               rdbNam.Checked ? "Nam" : "Nữ",
               dtpNgaysinh.Value,
               txtDienthoai.Text,
               txtDiachi.Text,
               cbbMaca.SelectedValue.ToString(),
               cbbMacv.SelectedValue.ToString()
               );

                BLL_NhanVien.insert(obj_NhanVien);
                showTableNhanvien();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Obj_NhanVien obj_NhanVien = new Obj_NhanVien(
                txtManv.Text,
                txtTennv.Text,
                rdbNam.Checked ? "Nam" : "Nữ",
                dtpNgaysinh.Value,
                txtDienthoai.Text,
                txtDiachi.Text,
                cbbMaca.SelectedValue.ToString(),
                cbbMacv.SelectedValue.ToString()
                );

            BLL_NhanVien.update(obj_NhanVien);
            showTableNhanvien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dgvNhanvien.Rows.Count - 1)
            {
                string id = dgvNhanvien.Rows[index].Cells[0].Value.ToString();
                DialogResult res = MessageBox.Show($"Muốn xóa nhân viên {id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    BLL_NhanVien.delete(id);
                    dgvNhanvien.Rows.RemoveAt(index);
                }
            }
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

        private void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index >= 0 && index < dgvNhanvien.Rows.Count - 1)
            {
                txtManv.Text = dgvNhanvien.Rows[index].Cells[0].Value.ToString();
                txtTennv.Text = dgvNhanvien.Rows[index].Cells[1].Value.ToString();
                rdbNam.Checked = dgvNhanvien.Rows[index].Cells[2].Value.ToString() == "Nam" ? true : false;
                rdbNu.Checked = dgvNhanvien.Rows[index].Cells[2].Value.ToString() == "Nữ" ? true : false;
                dtpNgaysinh.Value = (DateTime)dgvNhanvien.Rows[index].Cells[3].Value;
                txtDienthoai.Text = dgvNhanvien.Rows[index].Cells[4].Value.ToString();
                txtDiachi.Text = dgvNhanvien.Rows[index].Cells[5].Value.ToString();
                cbbMaca.SelectedValue = dgvNhanvien.Rows[index].Cells[6].Value.ToString();
                cbbMacv.SelectedValue = dgvNhanvien.Rows[index].Cells[7].Value.ToString();
            }

        }

        private void cbbMaca_DropDown(object sender, EventArgs e)
        {
            DataTable tbca = BLL_getData.getTable("pro_getAllCalam");
            fillComboBox(tbca, cbbMaca, "Maca", "Tenca");
        }

        private void cbbMacv_DropDown(object sender, EventArgs e)
        {
            DataTable tbcv = BLL_getData.getTable("getAllCongviec");
            fillComboBox(tbcv, cbbMacv, "Macongvec", "Tencongviec");
        }
    }
}
