using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_ptb2
{
    public partial class PTB2 : Form
    {
        public PTB2()
        {
            InitializeComponent();
        }

        private void PTB2_Load(object sender, EventArgs e)
        {
            this.Text = "PTB2";
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            string Nghiem = "";
            double delta = b * b - 4 * a * c;
            double x1, x2;
            if (a != 0)
            {
                if (delta < 0)
                    Nghiem = "Phương trình vô nghiệm";
                else if (delta == 0)
                    Nghiem = "x1 = x2 = " + (-b / (2 * a)).ToString();
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Nghiem = "x1 = " + x1.ToString() + ". x2= " + x2.ToString();
                }
            }
            if (a == 0)
            {
                if (b != 0)
                    Nghiem = "x= " + (-c / b).ToString();
                else if (c == 0)
                    Nghiem = "Phương trình vô số nghiệm";
                else
                    Nghiem = "Phương trình vô nghiệm";
            }
            txtNghiem.Text = Nghiem;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Ban muon thoat chuong trinh?",
                "Thong bao", MessageBoxButtons.YesNo);
            if (rsl == DialogResult.Yes)
                this.Close();
        }
    }
}
