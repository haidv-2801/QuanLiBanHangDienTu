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
using System.IO;
using Handling;
using WindowsFormsControlLibrary1;
using Bunifu.Framework.UI;

namespace QLBanHangDienTu
{
    public partial class UC_Hanghoa : UserControl
    {

        int index = -1;
        byte[] curImg = null;

        public UC_Hanghoa()
        {
            InitializeComponent();


            showData();
            cbbMadonvi_DropDown(null, null);
            cbbMadonvi.SelectedIndex = -1;
            cbbMaloai_DropDown(null, null);
            cbbMaloai.SelectedIndex = -1;
            cbbManhom_DropDown(null, null);
            cbbManhom.SelectedIndex = -1;
            cbbManuocsx_DropDown(null, null);
            cbbManuocsx.SelectedIndex = -1;
            cbbMachatlieu_DropDown(null, null);
            cbbMachatlieu.SelectedIndex = -1;

        }

        private Obj_HangHoa newObj_hanghoa()
        {
            try { curImg = toByte(ptbAnh.Image); }
            catch { }
            Obj_HangHoa hangHoaObj = new Obj_HangHoa(
               txtMahang.Text,
               txtTenhang.Text,
               int.Parse(txtSoluong.Text),
               float.Parse(txtDonggianhap.Text),
               float.Parse(txtDongiaban.Text),
               cbbManhom.SelectedValue.ToString(),
               cbbMaloai.SelectedValue.ToString(),
               cbbMadonvi.SelectedValue.ToString(),
               cbbMachatlieu.SelectedValue.ToString(),
               cbbManuocsx.SelectedValue.ToString(),
               int.Parse(txtThoigianbaohanh.Text),
               txtGhichu.Text,
               curImg
           );
            return hangHoaObj;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!checkAll())
                return;

            bool entryFound = false;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtMahang.Text) { entryFound = true; break; }
            }

           
            if (entryFound == true)
            {
                MessageBox.Show($"Mã {txtMahang.Text} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BLL_DMHangHoa.insertIntoDMHangHoa(newObj_hanghoa());
                showData();
                MessageBox.Show($"Thêm thành công {txtMahang.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Button3_Click(null, null);
            }
        }

        private bool checkAll()
        {
            if (txtMahang.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahang.Focus();
                return false;
            }

            if (txtTenhang.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có tên hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenhang.Focus();
                return false;
            }

            if (txtSoluong.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return false;
            }

            if (txtDonggianhap.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có đơn giá nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonggianhap.Focus();
                return false;
            }

            if (cbbManhom.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn nhóm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbManhom.Focus();
                return false;
            }

            if (cbbMaloai.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMaloai.Focus();
                return false;
            }

            if (cbbMadonvi.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMadonvi.Focus();
                return false;
            }

            if (cbbMachatlieu.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMachatlieu.Focus();
                return false;
            }

            if (cbbManuocsx.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn nước sản suất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbManuocsx.Focus();
                return false;
            }

            if (txtThoigianbaohanh.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có thời gian bảo hành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtThoigianbaohanh.Focus();
                return false;
            }

            if (ptbAnh.Image == null)
            {
                MessageBox.Show("Chưa có ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }



        private void Button5_Click(object sender, EventArgs e)
        {
            txtMahang.Text = Automatically.autoGetKey("select dbo.getKeyHangHoa()").Trim();
        }

        public void showData()
        {

            dataGridView1.DataSource = BLL_getData.getTable("pro_getAllHangHoa");
            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên hàng";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá nhập";
            dataGridView1.Columns[4].HeaderText = "Đơn giá bán";
            dataGridView1.Columns[5].HeaderText = "Mã nhóm";
            dataGridView1.Columns[6].HeaderText = "Mã loại";
            dataGridView1.Columns[7].HeaderText = "Mã đơn vị";
            dataGridView1.Columns[8].HeaderText = "Mã chất liệu";
            dataGridView1.Columns[9].HeaderText = "Mã nước sản xuất";
            dataGridView1.Columns[10].HeaderText = "Thời gian BH";
            dataGridView1.Columns[11].HeaderText = "Ghi chú";
            dataGridView1.Columns[12].HeaderText = "Ảnh";
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (index >= 0 && index < dataGridView1.Rows.Count - 1)
            {
                if (!checkAll())
                    return;
                BLL_DMHangHoa.update(newObj_hanghoa());
                MessageBox.Show("Sửa thành công!");
                showData();
                // dataGridView1.RefreshEdit();
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng!");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dataGridView1.Rows.Count - 1)
            {
                DialogResult res = MessageBox.Show($"Bạn chắc chắn muốn xóa {txtMahang.Text} chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    BLL.BLL_DMHangHoa.deleteFromDMHangHoa(txtMahang.Text);
                    MessageBox.Show($"Xóa thành công {txtMahang.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    showData();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtDonggianhap.Text = "";
            txtDongiaban.Text = "";
            txtGhichu.Text = "";
            txtMahang.Text = "";
            txtSoluong.Text = "";
            txtTenhang.Text = "";
            txtThoigianbaohanh.Text = "";
            cbbMachatlieu.SelectedIndex = -1;
            cbbMadonvi.SelectedIndex = -1;
            cbbMaloai.SelectedIndex = -1;
            cbbManhom.SelectedIndex = -1;
            cbbManuocsx.SelectedIndex = -1;
            ptbAnh.Image = null;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index >= 0)
            {
                txtMahang.Text = dataGridView1.Rows[index].Cells["Mahang"].Value.ToString();
                txtTenhang.Text = dataGridView1.Rows[index].Cells["Tenhang"].Value.ToString();
                txtSoluong.Text = dataGridView1.Rows[index].Cells["Soluong"].Value.ToString();
                txtDonggianhap.Text = dataGridView1.Rows[index].Cells["Dongianhap"].Value.ToString();
                txtDongiaban.Text = dataGridView1.Rows[index].Cells["Dongiaban"].Value.ToString();

                /*show combobox*/
                //  DataGridViewRow canRows = dataGridView1.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => x.Cells[0].Value.ToString() == txtMahang.Text);
                cbbManhom.SelectedValue = dataGridView1.Rows[index].Cells["Manhom"].Value.ToString();
                cbbMadonvi.SelectedValue = dataGridView1.Rows[index].Cells["Madonvi"].Value.ToString();
                cbbMachatlieu.SelectedValue = dataGridView1.Rows[index].Cells["Machatlieu"].Value.ToString();
                cbbManuocsx.SelectedValue = dataGridView1.Rows[index].Cells["MaNuocSX"].Value.ToString();
                cbbMaloai.SelectedValue = dataGridView1.Rows[index].Cells["Maloai"].Value.ToString();
                /**/

                txtGhichu.Text = dataGridView1.Rows[index].Cells["Ghichu"].Value.ToString();
                txtThoigianbaohanh.Text = dataGridView1.Rows[index].Cells["Thoigianbaohanh"].Value.ToString();

                try
                {
                    curImg = (byte[])dataGridView1.Rows[index].Cells["Anh"].Value;
                    ptbAnh.Image = toImage(curImg);
                }
                catch { ptbAnh.Image = null; }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All File (*.*)|*.*";
            OD.FilterIndex = 3;
            OD.RestoreDirectory = true;
            if (OD.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbAnh.Load(OD.FileName);
            }
        }

        private Image toImage(byte[] b)
        {
            using (var ms = new MemoryStream(b))
            {
                return Image.FromStream(ms);
            }
        }
        private byte[] toByte(Image img)
        {
            ImageConverter imageConverter = new ImageConverter();
            byte[] arrByte = (byte[])imageConverter.ConvertTo(img, typeof(byte[]));
            return arrByte;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonggianhap.Text) == false)
            {
                float dongianhap = float.Parse(txtDonggianhap.Text);
                float dongiaban = dongianhap + (dongianhap * 1 / 10);
                txtDongiaban.Text = ((Decimal)dongiaban).ToString();
            }

        }

        DataTable tbnhom, tbloai, tbdv, tbcl, tbnsx;



        private void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        private void cbbMadonvi_DropDown(object sender, EventArgs e)
        {
            tbdv = BLL_getData.getTable("pro_getAllDonvi");
            fillComboBox(tbdv, cbbMadonvi, "Madonvitinh", "Tendonvitinh");
        }

        private void cbbMachatlieu_DropDown(object sender, EventArgs e)
        {
            tbcl = BLL_getData.getTable("pro_getAllChatlieu");
            fillComboBox(tbcl, cbbMachatlieu, "Machatlieu", "Tenchatlieu");
        }

        private void cbbManuocsx_DropDown(object sender, EventArgs e)
        {
            tbnsx = BLL_getData.getTable("pro_getAllNuocSX");
            fillComboBox(tbnsx, cbbManuocsx, "MaNuocSX", "TenNuocSX");
        }

        private void TextBox4_TextChanged(object sender, PaintEventArgs e)
        {

        }

        private void dontChangeValue(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtSoluong.Text.Length > 8 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDonggianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtDonggianhap.Text.Length > 12 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoluong_OnValueChanged(object sender, EventArgs e)
        {
            float dongianhap = 0;
            decimal dongiaban = 0;
            try
            { dongiaban = (decimal)(dongianhap + (dongianhap * 0.1)); }
            catch { }

            txtDongiaban.Text = dongiaban.ToString();
        }

        private void txtThoigianbaohanh_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtThoigianbaohanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            if (txtThoigianbaohanh.Text.Length > 2 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbbManhom_DropDown(object sender, EventArgs e)
        {
            tbnhom = BLL_getData.getTable("pro_getAllNhom");
            fillComboBox(tbnhom, cbbManhom, "Manhom", "Tennhom");
        }

        private void cbbMaloai_DropDown(object sender, EventArgs e)
        {
            tbloai = BLL_getData.getTable("pro_getAllLoai");
            fillComboBox(tbloai, cbbMaloai, "Maloai", "Tenloai");
        }


        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            /*  if (this.MdiChildren.FirstOrDefault() != null)
                  this.MdiChildren.FirstOrDefault().Close();*/
            frTimKiemHang frtk = new frTimKiemHang();
            frtk.Show();
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


    }
}
