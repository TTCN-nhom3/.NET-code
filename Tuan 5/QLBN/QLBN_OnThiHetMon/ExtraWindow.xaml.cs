using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using QLBN_OnThiHetMon.Models;

namespace QLBN_OnThiHetMon
{
    /// <summary>
    /// Interaction logic for ExtraWindow.xaml
    /// </summary>
    public partial class ExtraWindow : Window
    {
        string str = "";
        public ExtraWindow()
        {
            InitializeComponent();
        }
        public ExtraWindow(string str)
        {
            this.str = str;
            InitializeComponent();
        }
        QuanLyBenhNhanDBContext db = new QuanLyBenhNhanDBContext();
        private void Form_Loaded(object sender, RoutedEventArgs e)
        {
            
            var q = from i in db.BenhNhans
                    join k in db.Khoas on i.MaKhoa equals k.MaKhoa
                    where k.TenKhoa == str
                    orderby i.SoNgayNamVien descending
                    select new
                    {
                        i.MaBn,
                        i.HoTen,
                        k.TenKhoa,
                        i.SoNgayNamVien,
                        Fee = string.Format("{0:0,0}", i.VienPhi)
                    };
            dtg.ItemsSource = q.ToList();

        }
    }
}
