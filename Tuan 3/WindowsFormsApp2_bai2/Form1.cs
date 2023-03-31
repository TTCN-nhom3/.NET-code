using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_bai2
{
    public partial class Form1 : Form
    {
        List<NhanVien> DSNV = new List<NhanVien>();
        int row;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "NHÂN VIÊN";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rst = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo",
             MessageBoxButtons.YesNo);
            if (rst == DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            string ten = txtHoTen.Text;
            double tien_luong_ngay = double.Parse(txtTienLuongNgay.Text);
            float so_ngay = float.Parse(txtSoNgayLV.Text);
            NhanVien nv = new NhanVien();
            nv.nhap(ma, ten, tien_luong_ngay, so_ngay);
            DSNV.Add(nv);
            btnHienThi_Click(sender, e);
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtTienLuongNgay.Clear();
            txtSoNgayLV.Clear();
            txtMaNV.Focus();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (var i in DSNV)
            {
                row = listView1.Items.Count;
                listView1.Items.Add(i.maNV);
                listView1.Items[row].SubItems.Add(i.hoTen);
                listView1.Items[row].SubItems.Add(i.tienLuongNgay.ToString());
                listView1.Items[row].SubItems.Add(i.soNgayLV.ToString());
                listView1.Items[row].SubItems.Add(i.luong().ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.SelectedIndices.IndexOf(i) >= 0)
                {
                    DSNV.RemoveAt(i);
                    listView1.Items.RemoveAt(i);
                    i--;
                }
            }
        }
        private void listView1_ItemSelectionChanged_1(object sender,
            ListViewItemSelectionChangedEventArgs e)
        {
            row = e.ItemIndex;
            txtMaNV.Text = listView1.Items[row].SubItems[0].Text;
            txtHoTen.Text = listView1.Items[row].SubItems[1].Text;
            txtTienLuongNgay.Text = listView1.Items[row].SubItems[2].Text;
            txtSoNgayLV.Text = listView1.Items[row].SubItems[3].Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.SelectedIndices.IndexOf(i) >= 0)
                {
                    string ma = txtMaNV.Text;
                    string ten = txtHoTen.Text;
                    double tien_luong_ngay = double.Parse(txtTienLuongNgay.Text);
                    float so_ngay = float.Parse(txtSoNgayLV.Text);
                    DSNV[i].maNV = ma;
                    DSNV[i].hoTen = ten;
                    DSNV[i].tienLuongNgay = tien_luong_ngay;
                    DSNV[i].soNgayLV = so_ngay;

                    btnHienThi_Click(sender, e);
                }
            }
        }
    }
}
