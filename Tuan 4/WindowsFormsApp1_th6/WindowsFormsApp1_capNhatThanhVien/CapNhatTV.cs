using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_capNhatThanhVien
{
    public partial class CapNhatTV : Form
    {
        public CapNhatTV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioiTinh = "Gioi tinh: ";
            if (rbtnNam.Checked)
                gioiTinh += "Nam";
            if (rbtnNu.Checked)
                gioiTinh += "Nu";
            string soThich = "So thich: ";
            if (cbAmNhac.Checked)
                soThich += "Am nhac  ";
            if (cbBoiLoi.Checked)
                soThich += "Boi loi  ";
            if (cbDaBong.Checked)
                soThich += "Bong da  ";
            if (cbLeoNui.Checked)
                soThich += "Leo nui  ";
            string honNhan = "Tinh trang hon nhan: ";
            if (rbtnChuaKH.Checked)
                honNhan += "Chua ket hon";
            if (rbtnDaKH.Checked)
                honNhan += "Da ket hon";
            lstCapNhat.Items.Add("Ho ten: " + txtHoTen.Text);
            lstCapNhat.Items.Add(gioiTinh);
            lstCapNhat.Items.Add(honNhan);
            lstCapNhat.Items.Add(soThich);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
