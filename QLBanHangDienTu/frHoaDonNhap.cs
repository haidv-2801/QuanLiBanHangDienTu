using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Handling;
using BLL;
using Object;
using System.Timers;

namespace QLBanHangDienTu
{
    public partial class frHoaDonNhap : Form
    {
        DataTable tbnv, tbhh, tbncc;

        public frHoaDonNhap()
        {
            this.WindowState = FormWindowState.Normal;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtSohdn.Text = Automatically.CreateKey("HDN");
            txtTongtien.Text = "0";
            //fillAllCbb();
            btnControl(true);
            txtSoluong.Enabled = false;
            txtGiamgia.Enabled = false;
        }

        private void btnControl(bool status)
        {
            btnLammoi.Enabled = status;
            btnLuu.Enabled = status;
            btnXoa.Enabled = status;
            btnTimkiem.Enabled = status;
            cbbMahang.Enabled = status;
            cbbMaNCC.Enabled = status;
            cbbManv.Enabled = status;
            txtTimkiem.Enabled = status;
            txtSoluong.Enabled = status;
            txtGiamgia.Enabled = status;

        }

        private void boxControl(string content)
        {
            cbbMahang.Text = content;
            cbbMaNCC.Text = content;
            cbbManv.Text = content;
            txtSohdn.Text = content;
        }

        private void FrHoaDonNhap_Load(object sender, EventArgs e)
        {
          
            tbHDN.DataSource = BLL_getData.getTable("pro_getAllHoadonnhap");
            boxControl("");
            btnControl(false);
        }

        private void fillAllCbb()
        {
            tbnv = BLL_getData.getTable("pro_getAllNhanvien");
            fillComboBox(tbnv, cbbManv, "MaNV", "Tennhanvien");
            tbhh = BLL_getData.getTable("pro_getAllHangHoa");
            fillComboBox(tbhh, cbbMahang, "Mahang", "Tenhang");

            /*fill nha cung cap*/

            tbncc = BLL_getData.getTable("pro_getAllNhacungcap");
            fillComboBox(tbncc, cbbMaNCC, "MaNCC", "TenNCC");
        }
        private void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
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

        private void CbbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tmp = BLL_getData.getTableById("pro_getNhacungcapById", cbbMaNCC.SelectedValue.ToString());
            if (tmp.Rows.Count > 0)
            {
                txtTenNCC.Text = tmp.Rows[0]["TenNCC"].ToString();
                txtDiachi.Text = tmp.Rows[0]["Diachi"].ToString();
                txtDienthoai.Text = tmp.Rows[0]["Dienthoai"].ToString();
            }

        }

        private void TbHDN_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TbHDN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index <= tbHDN.Rows.Count)
            {
                try
                {
                    string id = tbHDN.Rows[index].Cells["SoHDN"].Value.ToString();
                    //MessageBox.Show(id);
                    tbHDN.DataSource = BLL_getData.getTableById("pro_getCTHDN_ById", id);
                    tbHDN.Columns[0].HeaderText = "Mã hàng";
                    tbHDN.Columns[1].HeaderText = "Tên hàng";
                    tbHDN.Columns[2].HeaderText = "Số lượng";
                    tbHDN.Columns[3].HeaderText = "Đơn giá";
                    tbHDN.Columns[4].HeaderText = "Giảm giá";
                    tbHDN.Columns[5].HeaderText = "Thành tiền";
                }
                catch (Exception)
                {

                }
            }
        }

        private void TbHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == tbHDN.Rows.Count - 1)
            {
                tbHDN.DataSource = BLL_getData.getTable("pro_getAllHoadonnhap");
            }
        }

        private void LblQuaylai_Click(object sender, EventArgs e)
        {
            tbHDN.DataSource = BLL_getData.getTable("pro_getAllHoadonnhap");
        }

        private void TxtSoluong_TextChanged(object sender, EventArgs e)
        {
            int giamgia = 0;

            if (string.IsNullOrWhiteSpace(txtGiamgia.Text) == false)
                giamgia = int.Parse(txtGiamgia.Text);
            if (string.IsNullOrWhiteSpace(txtSoluong.Text) == false)
            {
                int soluong = int.Parse(txtSoluong.Text);
                double dongia = float.Parse(txtDongia.Text);
                double thanhtien = dongia * soluong - 1.0 * (dongia * soluong) * giamgia / 100;
                txtThanhtien.Text = thanhtien.ToString();
            }
            else txtThanhtien.Text = "0";
        }

        private void TxtGiamgia_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            txtGiamgia.Text = int.TryParse(txtGiamgia.Text, out i) == false || i < 0 || i > 100 ? "" : i.ToString();

            if (string.IsNullOrWhiteSpace(txtSoluong.Text) == false)
            {
                if (string.IsNullOrWhiteSpace(txtGiamgia.Text) == false)
                {
                    int giamgia = int.Parse(txtGiamgia.Text);
                    int soluong = int.Parse(txtSoluong.Text);
                    double dongia = double.Parse(txtDongia.Text);
                    double thanhtien = dongia * soluong - 1.0 * (dongia * soluong) * giamgia / 100;
                    txtThanhtien.Text = thanhtien.ToString();
                }

            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {

            if (cbbMaNCC.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMaNCC.Focus();
                return;
            }

            if (cbbManv.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbManv.Focus();
                return;
            }

            if (cbbMahang.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMahang.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoluong.Text) == true)
            {
                MessageBox.Show("Nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGiamgia.Text) == true)
            {
                MessageBox.Show("Nhập giảm giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamgia.Focus();
                return;
            }

            

           
            Obj_HoaDonNhap obj_HoaDonNhap = new Obj_HoaDonNhap(
                txtSohdn.Text,
                cbbManv.SelectedValue.ToString(),
                dtpNgaytao.Value,
                cbbMaNCC.SelectedValue.ToString(),
                float.Parse(txtTongtien.Text)
                );

            BLL_HoaDonNhap.insertIntoHoadonnhap(obj_HoaDonNhap);


            if(BLL_CTHoaDonNhap.isDuplicateMahanghoa(txtSohdn.Text, cbbMahang.SelectedValue.ToString()))
            {
                MessageBox.Show($"Mã hàng {cbbMahang.SelectedValue.ToString()} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Obj_CTHoaDonNhap obj_CTHoaDonNhap = new Obj_CTHoaDonNhap(
               txtSohdn.Text,
               cbbMahang.SelectedValue.ToString(),
               int.Parse(txtSoluong.Text),
               float.Parse(txtDongia.Text),
               int.Parse(txtGiamgia.Text),
               float.Parse(txtThanhtien.Text)
               );
            BLL_CTHoaDonNhap.insertIntoCTHoadonnhap(obj_CTHoaDonNhap);

            tbHDN.DataSource = BLL_getData.getTable("pro_getAllHoadonnhap");
            MessageBox.Show($"Thêm thành công {txtSoluong.Text} {txtTenhang.Text} Mã hóa đơn:{txtSohdn.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void BtnLammoi_Click(object sender, EventArgs e)
        {
            txtSoluong.Enabled = false;
            txtGiamgia.Enabled = false;
            reset();
        }

        private void reset()
        {
            cbbMahang.Text = "";
            cbbMaNCC.Text = "";
            cbbManv.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtDongia.Text = "";
            txtGiamgia.Text = "";
            txtSohdn.Text = "";
            txtSoluong.Text = "";
            txtNameEmp.Text = "";
            txtTenhang.Text = "";
            txtTenNCC.Text = "";
            txtTongtien.Text = "0";
            btnLuu.Enabled = false;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtSoluong.Text.Length > 8 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtGiamgia.Text.Length > 1 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void CbbManv_DropDown(object sender, EventArgs e)
        {
            tbnv = BLL_getData.getTable("pro_getAllNhanvien");
            fillComboBox(tbnv, cbbManv, "MaNV", "Tennhanvien");
        }

        private void CbbMahang_DropDown(object sender, EventArgs e)
        {
            tbhh = BLL_getData.getTable("pro_getAllHangHoa");
            fillComboBox(tbhh, cbbMahang, "Mahang", "Tenhang");
        }

        private void CbbMaNCC_DropDown(object sender, EventArgs e)
        {
            tbncc = BLL_getData.getTable("pro_getAllNhacungcap");
            fillComboBox(tbncc, cbbMaNCC, "MaNCC", "TenNCC");
        }

        private void CbbTenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiamgia.Enabled = true;
            txtSoluong.Enabled = true;
            DataTable tmp = BLL_getData.getTableById("pro_getHanghoaById", cbbMahang.SelectedValue.ToString());
            if (tmp.Rows.Count > 0)
            {
                txtTenhang.Text = tmp.Rows[0]["Tenhang"].ToString();
                txtDongia.Text = tmp.Rows[0]["Dongianhap"].ToString();
            }
        }

        private void CbbManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tmp = BLL_getData.getTableById("pro_getNhanvienById", cbbManv.SelectedValue.ToString());
            if (tmp.Rows.Count > 0)
                txtNameEmp.Text = tmp.Rows[0]["Tennhanvien"].ToString();
        }


    }
}
