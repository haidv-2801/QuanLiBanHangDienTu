using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Object;
using BLL;
using Handling;

namespace QLBanHangDienTu
{
    public partial class UC_Hoadonban : UserControl
    {

        DataTable tbnv, tbhh, tbkh, tbTemp;
        List<Obj_CTHoaDonBan> listCTHDBTemp = new List<Obj_CTHoaDonBan>();

        int idOfRowForDel = -1;

        public UC_Hoadonban()
        {
            InitializeComponent();
        }

        private void UC_Hoadonnhap_Paint(object sender, PaintEventArgs e)
        {
            showHDB();
        }

        private void showHDB()
        {
            tbHDN.DataSource = BLL_getData.getTable("pro_getAllHoadonban");
            tbHDN.Columns[0].HeaderText = "Số HĐB";
            tbHDN.Columns[1].HeaderText = "Mã nhân viên";
            tbHDN.Columns[2].HeaderText = "Ngày bán";
            tbHDN.Columns[3].HeaderText = "Mã khách hàng";
            tbHDN.Columns[4].HeaderText = "Tổng tiền";
        }

        private void fillAllCbb()
        {
            tbnv = BLL_getData.getTable("pro_getAllNhanvien");
            fillComboBox(tbnv, cbbManv, "MaNV", "Tennhanvien");

            tbhh = BLL_getData.getTable("pro_getAllHangHoa");
            fillComboBox(tbhh, cbbMahang, "Mahang", "Tenhang");

            /*fill nha cung cap*/

            tbkh = BLL_getData.getTable("pro_getAllKhachhang");
            fillComboBox(tbkh, cbbMaKh, "Makhach", "Tenkhach");
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


        /*Dropdown*/
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
            tbkh = BLL_getData.getTable("pro_getAllKhachhang");
            fillComboBox(tbkh, cbbMaKh, "Makhach", "Tenkhach");
        }

        /*Key press*/
        private void TxtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtSoluong.Text.Length > 8 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            if (listCTHDBTemp.Count > 0)
            {
                DialogResult res = MessageBox.Show("Giỏ hiện thời chưa lưu, Có muốn tiếp tục?", "Thông báo", MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                {
                    listCTHDBTemp.Clear();
                    reset();
                }
                else
                    return;
            }
            tbTemp = new DataTable();

            tbTemp.Columns.Add("Mã hàng");
            tbTemp.Columns.Add("Tên hàng");
            tbTemp.Columns.Add("Số lượng");
            tbTemp.Columns.Add("Đơn giá");
            tbTemp.Columns.Add("Giảm giá");
            tbTemp.Columns.Add("Thành tiền");

            dgvTrolley.DataSource = tbTemp;
            txtSohdb.Text = Automatically.CreateKey("HDB");
            label10.Text = txtSohdb.Text;
        }

        private void tbHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idOfRowForDel = e.RowIndex;
            fillCTHDN(idOfRowForDel);
            if (idOfRowForDel == tbHDN.Rows.Count - 1)
            {
                if (listCTHDBTemp.Count > 0)
                {
                    DialogResult res = MessageBox.Show("Bạn chưa lưu hóa đơn, vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
                    if (res == DialogResult.No)
                        return;
                    else { listCTHDBTemp.Clear(); reset(); return; }
                }
                tbHDN.DataSource = BLL_getData.getTable("pro_getAllHoadonnhap");
            }
        }

        private void reset()
        {
            cbbMahang.Text = "";
            cbbMaKh.Text = "";
            cbbManv.Text = "";
            txtDongia.Text = "";
            txtGiamgia.Text = "";
            txtSohdb.Text = "";
            txtSoluong.Text = "";
            txtTenhang.Text = "";
            txtTongtien.Text = "0";
        }

        /*Check inputdata*/
        private bool checkInputData()
        {
            if (string.IsNullOrWhiteSpace(txtSohdb.Text))
            {
                MessageBox.Show("Chưa tạo hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cbbMahang.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMahang.Focus();
                return false;
            }

            if (cbbManv.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbManv.Focus();
                return false;
            }

            if (cbbMahang.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMahang.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoluong.Text) == true)
            {
                MessageBox.Show("Nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGiamgia.Text) == true)
            {
                MessageBox.Show("Nhập giảm giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamgia.Focus();
                return false;
            }

            return true;
        }
        private void tbHDN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnThemvaogio_Click(object sender, EventArgs e)
        {
            if (!checkInputData())
                return;

            bool alreadyExists = listCTHDBTemp.Any(x => x.MaHang1 == cbbMahang.SelectedValue.ToString());
           
            if (alreadyExists)
            {
                MessageBox.Show($"Hàng {cbbMahang.Text} đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Obj_CTHoaDonBan obj_CTHoaDonBan = new Obj_CTHoaDonBan(
               txtSohdb.Text,
               cbbMahang.SelectedValue.ToString(),
               int.Parse(txtSoluong.Text),
               float.Parse(txtDongia.Text),
               int.Parse(txtGiamgia.Text),
               float.Parse(txtThanhtien.Text),
               txtTenhang.Text
               );

            listCTHDBTemp.Add(obj_CTHoaDonBan);


            updateTableTemp();
            updateTongtien();
        }

        /*update something*/
        private void updateTableTemp()
        {
            tbTemp.Clear();
            foreach (var data in listCTHDBTemp)
            {
                DataRow row = tbTemp.NewRow();
                row["Mã hàng"] = data.MaHang1;
                row["Tên hàng"] = data.TenHang1;
                row["Số lượng"] = data.SoLuong1;
                row["Đơn giá"] = data.DonGia1;
                row["Giảm giá"] = data.GiamGia1;
                row["Thành tiền"] = (Decimal)data.ThanhTien1;
                tbTemp.Rows.Add(row);
            }
            dgvTrolley.DataSource = tbTemp;
        }
        private void updateTongtien()
        {
            float tongtien = listCTHDBTemp.Sum(x => x.ThanhTien1);
            txtTongtien.Text = ((Decimal)tongtien).ToString();
        }

        private void cbbMahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbMahang.SelectedValue.ToString());
            DataTable tmp = BLL_getData.getTableById("pro_getHanghoaById", cbbMahang.SelectedValue.ToString());
            if (tmp.Rows.Count > 0)
            {
                txtTenhang.Text = tmp.Rows[0]["Tenhang"].ToString();
                txtDongia.Text = tmp.Rows[0]["Dongianhap"].ToString();
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            if (listCTHDBTemp.Count > 0)
            {
                DialogResult res = MessageBox.Show($"Giỏ {txtSohdb.Text} chưa lưu, có muốn tiếp tục?", "Thông báo", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                    return;
                else { listCTHDBTemp.Clear(); tbTemp.Rows.Clear(); }
            }
            reset();
        }


        private void fillCTHDN(int id)
        {
            if (listCTHDBTemp.Count <= 0)
                return;
            cbbMahang.SelectedValue = dgvTrolley.Rows[id].Cells["Mã hàng"].Value.ToString();
            txtSoluong.Text = dgvTrolley.Rows[id].Cells["Số lượng"].Value.ToString();
            txtGiamgia.Text = dgvTrolley.Rows[id].Cells["Giảm giá"].Value.ToString();
            txtTenhang.Text = dgvTrolley.Rows[id].Cells["Tên hàng"].Value.ToString();
            txtDongia.Text = dgvTrolley.Rows[id].Cells["Đơn giá"].Value.ToString();
        }

        private void calculateMoney(object sender, EventArgs e)
        {
            int amount = 0, discount = 0;
            float cost = 0;
            decimal finalCost = 0;

            try { amount = int.Parse(txtSoluong.Text); } catch { }
            try { discount = int.Parse(txtGiamgia.Text); } catch { }
            try { cost = float.Parse(txtDongia.Text); } catch { }

            finalCost = (decimal)(amount * cost - amount * cost * discount * 0.01);

            txtThanhtien.Text = finalCost.ToString();
        }

        private void notChangeAnyValue(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgvTrolley_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idOfRowForDel = e.RowIndex;
            if (e.RowIndex >= 0 && e.RowIndex < dgvTrolley.Rows.Count - 1)
            {
                fillCTHDN(e.RowIndex);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idOfRowForDel >= 0 && idOfRowForDel < dgvTrolley.Rows.Count - 1)
            {
                string mh = dgvTrolley.Rows[idOfRowForDel].Cells["Mã hàng"].Value.ToString();
                var obj = listCTHDBTemp.FirstOrDefault(x => x.MaHang1 == mh);

                if (listCTHDBTemp.Count > 0)
                {
                    obj.SoLuong1 = int.Parse(txtSoluong.Text);
                    obj.GiamGia1 = int.Parse(txtGiamgia.Text);
                }

                updateTableTemp();
                MessageBox.Show($"Sửa thành công mã hàng {mh}!");
            }
        }

        private void UC_Hoadonban_Load(object sender, EventArgs e)
        {
            showHDB();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idOfRowForDel >= 0 && idOfRowForDel < dgvTrolley.Rows.Count - 1)
            {
                if (listCTHDBTemp.Count > 0)
                {
                    DialogResult res = MessageBox.Show($"Bạn muốn xóa hàng {dgvTrolley.Rows[idOfRowForDel].Cells["Mã hàng"].Value.ToString()}", "Thông báo", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        listCTHDBTemp.RemoveAt(idOfRowForDel);
                        dgvTrolley.Rows.RemoveAt(idOfRowForDel);
                        updateTongtien();
                    }
                }
                else { MessageBox.Show("Chỉ có thể xóa trong giỏ hàng!"); }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listCTHDBTemp.Count <= 0)
            {
                MessageBox.Show("Chưa có hàng hóa nào?", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            Obj_HoaDonBan obj_HoaDonBan = new Obj_HoaDonBan(
                 txtSohdb.Text,
                cbbManv.SelectedValue.ToString(),
                dtpNgaytao.Value,
                cbbMaKh.SelectedValue.ToString(),
                float.Parse(txtTongtien.Text)
                );

            BLL_HoaDonBan.insert(obj_HoaDonBan);



            listCTHDBTemp.ForEach(x => BLL_CTHoaDonBan.insert(x));

            tbHDN.DataSource = BLL_getData.getTable("pro_getAllHoadonban");
            MessageBox.Show($"Thêm thành công hóa đơn:{txtSohdb.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listCTHDBTemp.Clear();
            dgvTrolley.DataSource = null;
            reset();
        }

        private void TxtGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtGiamgia.Text.Length > 1 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /*Textchange*/

    } 
}
