using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_QLNV
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            this.Text = "QLNV";
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nu");
            cmbGioiTinh.Items.Add("Khac");
            cmbPhongBan.Items.Add("Phong tai vu");
            cmbPhongBan.Items.Add("Phong hanh chinh");
            cmbPhongBan.Items.Add("Phong kinh doanh");
            cmbPhongBan.Items.Add("Phong dao tao");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string str = txtHoTen.Text + " - " + cmbGioiTinh.Text + " - " + cmbPhongBan.Text;
            lstDSNV.Items.Add(str);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Ban muon thoat chuong trinh?", "Thong bao",
                MessageBoxButtons.YesNo);
            if (rsl == DialogResult.Yes)
                this.Close();
        }
    }
}
