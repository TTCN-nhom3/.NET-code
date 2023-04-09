using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_ChonSach
{
    public partial class ChonSach : Form
    {
        public ChonSach()
        {
            InitializeComponent();
        }

        private void ChonSach_Load(object sender, EventArgs e)
        {
            this.Text = "Chon Sach";
            lstDanhSach.Items.Add("Nhập môn tin học");
            lstDanhSach.Items.Add("Tin văn phòng");
            lstDanhSach.Items.Add("Lập trình trên Windows");
            lstDanhSach.Items.Add("Công nghệ thực tại ảo");
            lstDanhSach.Items.Add("Phân tích thiết kế hệ thống");
            lstDanhSach.Items.Add("Lập trình hướng đối tượng");
            lstDanhSach.Items.Add("Thiết kế trang Web");
            lstDanhSach.Items.Add("Đảm bảo chất lượng phần mềm");
            lstDanhSach.Items.Add("Giải thuật di truyền và ứng dụng");
            lstDanhSach.Items.Add("Hệ chuyên gia");
            lstDanhSach.Items.Add("Lập trình căn bản");
            lstDanhSach.Items.Add("Một số phương pháp tính toán mềm");
            lstDanhSach.Items.Add("Phân tích và thống kê số liệu");
            lstDanhSach.Items.Add("Thiết kế Cơ sở dữ liệu");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Ban muon thoat chuong trinh?", "Thong bao",
                MessageBoxButtons.YesNo);
            if (rsl == DialogResult.Yes)
                this.Close();
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            lstSachChon.Items.Add(lstDanhSach.SelectedItem);
        }

        private void btnThemNhieu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDanhSach.Items.Count; i++)
                lstSachChon.Items.Add(lstDanhSach.Items[i]);
        }

        private void btxXoa1_Click(object sender, EventArgs e)
        {
            lstSachChon.Items.Remove(lstSachChon.SelectedItem);
        }

        private void btnXoaNhieu_Click(object sender, EventArgs e)
        {         
                lstSachChon.Items.Clear();
        }
    }
}
