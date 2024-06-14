//Hoàng Lê
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace đồ_án_chdan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void XoaTTGiaoDien1()
        {
            txtTenMon.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHoaDon.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void Khoa()
        {
            txtTen.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtGia1.ReadOnly = true;
            cbGioiTinh.
        }*/
        private void btnDat_Click(object sender, EventArgs e)  // hậu , hyhy
        {
            try
            {
                int a = Convert.ToInt32(txtSoLuong1.Text);
                for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                {
                    if (txtMonAn1.Text == dataGridViewKho[0, i].Value.ToString())
                    {
                        if (Convert.ToInt32(dataGridViewKho[1, i].Value) - Convert.ToInt32(txtSoLuong1.Text) >= 0)
                        {
                            btnHoaDon.Enabled = true;
                            MessageBox.Show("Dat thành công");
                        }
                        else
                        {
                            MessageBox.Show("Mặt hàng còn " + Convert.ToInt32(dataGridViewKho[1, i].Value));
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhap sai DL So Luong");
            }
        }
        private void btnHoaDon_Click(object sender, EventArgs e) // đan , trầm 
        {
            if (txtTen.Text != "" && txtDiaChi.Text != "" && txtGia1.Text != "" && cbGioiTinh.Text != "")
            {
                try
                {
                    int gia = Convert.ToInt32(txtGia1.Text);
                    for (int i = 0; i < dataGridViewKho.Rows.Count - 1; i++)
                    {
                        if (txtMonAn1.Text == dataGridViewKho[0, i].Value.ToString())
                        {
                            if (Convert.ToInt32(dataGridViewKho[1, i].Value) - Convert.ToInt32(txtSoLuong1.Text) >= 0)
                            {
                                int gia1 = Convert.ToInt32(dataGridViewKho[2, i].Value) / Convert.ToInt32(dataGridViewKho[1, i].Value);
                                int gia2 = Convert.ToInt32(txtGia1.Text) / Convert.ToInt32(txtSoLuong1.Text);
                                int gia3 = (gia2-gia1) * Convert.ToInt32(txtSoLuong1.Text);
                                
                                dataGridViewBan.Rows.Add(txtTen.Text, cbGioiTinh.Text, txtDiaChi.Text, txtMonAn1.Text, txtSoLuong1.Text, dateTimePicker2.Text, gia3.ToString());
                                dataGridViewKho[1, i].Value = Convert.ToInt32(dataGridViewKho[1, i].Value) - Convert.ToInt32(txtSoLuong1.Text);
                                dataGridViewKho[2, i].Value = gia1 * Convert.ToInt32(dataGridViewKho[1, i].Value);
                                btnHoaDon.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Mặt hàng còn " + Convert.ToInt32(dataGridViewKho[1, i].Value));
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Sai dữ liệu giá");
                }
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnNhap11_Click(object sender, EventArgs e) // vy
        {
            if (txtTenMon1.Text != "" && txtSoLuong11.Text != "" && txtGia11.Text != "")
            {
                try
                {
                    int soluong = Convert.ToInt32(txtSoLuong11.Text);
                    try
                    {
                        int gia = Convert.ToInt32(txtGia11.Text);
                        dataGridViewKho.Rows.Add(txtTenMon1.Text, txtSoLuong11.Text, txtGia11.Text, dateTimePicker1.Text);
                        XoaTTGiaoDien1();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Sai dữ liệu giá");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Sai dữ liệu số lượng");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void button1_Click(object sender, EventArgs e) // btnThongKe  // thinh
        {
            if (radioButton1.Checked)
            {
                dataGridViewThongKe.Rows.Clear();
                for (int i = 0; i < dataGridViewBan.Rows.Count - 1; i++)
                {
                    if (txtTenMon2.Text == dataGridViewBan[3, i].Value.ToString())
                    {
                        dataGridViewThongKe.Rows.Add(dataGridViewBan[3, 1].Value, dataGridViewBan[1, i].Value, dataGridViewBan[4, i].Value, dataGridViewBan[6, i].Value, dataGridViewBan[5,i].Value);
                    }
                }
            }
            else if (radioButton3.Checked) // radioButton2.Checked
            {

                dataGridViewThongKe.Rows.Clear();
                for (int i = 0; i < dataGridViewBan.Rows.Count - 1; i++)
                {
                    if (dateTimePicker3.Text == dataGridViewBan[5, i].Value.ToString())
                    {
                        dataGridViewThongKe.Rows.Add(dataGridViewBan[3, 1].Value, dataGridViewBan[1, i].Value, dataGridViewBan[4, i].Value, dataGridViewBan[6, i].Value, dataGridViewBan[5, i].Value);
                    }
                }
            }
        }
    }
}


