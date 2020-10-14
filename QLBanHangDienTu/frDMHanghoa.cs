using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Object;
using Handling;
using BLL;
using System.IO;


namespace QLBanHangDienTu
{
    public partial class frDMHanghoa : Form
    {
        public frDMHanghoa()
        {
            InitializeComponent();
        }

        private void FrDMHanghoa_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Obj_HangHoa hangHoaObj = new Obj_HangHoa(
                txtMahang.Text,
                txtTenhang.Text,
                int.Parse(txtSoluong.Text),
                float.Parse(txtDonggianhap.Text),
                float.Parse(txtDongiaban.Text),
                cbbManhom.Text,
                cbbMaloai.Text,
                cbbMadonvi.Text,
                cbbMachatlieu.Text,
                cbbManuocsx.Text,
                int.Parse(txtThoigianbaohanh.Text),
                txtGhichu.Text,
                null
            );

            BLL_DMHangHoa.insertIntoDMHangHoa(hangHoaObj);
            showData();
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
            // dataGridView1.Columns[5].Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            BLL.BLL_DMHangHoa.deleteFromDMHangHoa(txtMahang.Text);
            showData();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtMahang.ResetText();
            txtTenhang.ResetText();
            txtSoluong.ResetText();
            txtDonggianhap.ResetText();
            txtDongiaban.ResetText();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMahang.Text = dataGridView1.Rows[index].Cells["Mahang"].Value.ToString();
                txtTenhang.Text = dataGridView1.Rows[index].Cells["Tenhang"].Value.ToString();
                txtSoluong.Text = dataGridView1.Rows[index].Cells["Soluong"].Value.ToString();
                txtDonggianhap.Text = dataGridView1.Rows[index].Cells["Dongianhap"].Value.ToString();
                txtDongiaban.Text = dataGridView1.Rows[index].Cells["Dongiaban"].Value.ToString();

                try
                {
                    byte[] img = (byte[])dataGridView1.Rows[index].Cells["Anh"].Value;
                    ptbAnh.Image = Image.FromStream(new MemoryStream(img));
                }
                catch (Exception) { }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported image|*jpg;*jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbAnh.Load(OD.FileName);
            }

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtDonggianhap.Text) == false)
            {
                float dongianhap = float.Parse(txtDonggianhap.Text);
                float dongiaban = dongianhap + (dongianhap * 1 / 10);
                txtDongiaban.Text = ((Decimal)dongiaban).ToString();
            }
           
        }

        DataTable tbnhom, tbloai;

        private void fillAllCbb()
        {
            tbnhom = BLL_getData.getTable("pro_getAllNhom");
            fillComboBox(tbnhom, cbbManhom, "Manhom", "Tennhom");
            tbloai = BLL_getData.getTable("pro_getAllLoai");
            fillComboBox(tbloai, cbbMaloai, "Maloai", "Tenloai");

        }

        private void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
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
          //  frtk.MdiParent = this;

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
