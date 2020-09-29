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
                textBox1.Text,
                textBox2.Text,
                int.Parse(textBox3.Text),
                float.Parse(textBox4.Text),
                float.Parse(textBox5.Text)
            );

            BLL_DMHangHoa.insertIntoDMHangHoa(hangHoaObj);
            showData();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Automatically.autoGetKey("select dbo.getKey()");
        }

        public void showData()
        {
            dataGridView1.DataSource = BLL_getData.getTable("pro_getAllHangHoa");
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            BLL.BLL_DMHangHoa.deleteFromDMHangHoa(textBox1.Text);
            showData();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                textBox1.Text = dataGridView1.Rows[index].Cells["Mahang"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[index].Cells["Tenhang"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[index].Cells["Soluong"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[index].Cells["Dongianhap"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[index].Cells["Dongiaban"].Value.ToString();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }
    }
}
