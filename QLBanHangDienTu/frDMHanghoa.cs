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
                float.Parse(txtDongiaban.Text)
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
    }
}
