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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using QLBN_OnThiHetMon.Models;
using System.Text.RegularExpressions;


namespace QLBN_OnThiHetMon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        QuanLyBenhNhanDBContext db = new QuanLyBenhNhanDBContext();
        private void showData()
        {
            var q = from i in db.BenhNhans
                    join k in db.Khoas on i.MaKhoa equals k.MaKhoa
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
        private void showCbb()
        {
            var q = from i in db.Khoas
                    select i;
            cbb.ItemsSource = q.ToList();
            cbb.SelectedValuePath = "MaKhoa";
            cbb.DisplayMemberPath = "TenKhoa";
        }

        private void Form_Loaded(object sender, RoutedEventArgs e)
        {
            showData();
            showCbb();
            txtID.Focus();
        }
        private bool checkData()
        {
            string ms = "";
            if (txtID.Text == "")
                ms += "\nHãy điền mã bệnh nhân!";
            else if (!Regex.IsMatch(txtID.Text, @"\d+"))
                ms += "\nMã bệnh nhân phải là số!";
            if (txtName.Text == "")
                ms += "\nHãy điền tên bệnh nhân!";
            if (txtNum.Text == "")
                ms += "\nHãy điền số ngày nằm viện!";
            else if (!Regex.IsMatch(txtNum.Text, @"\d+"))
                ms += "\nSố ngày nằm viện phải là số!";
            else if (int.Parse(txtNum.Text) < 1)
                ms += "\nSố ngày nằm viện phải >= 1!";
            if (cbb.Text == "")
                ms += "\nHãy chọn khoa!";
            if (ms == "")
                return true;
            else
            {
                MessageBox.Show(ms, "Thông báo");
                return false;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (checkData())
                {
                    var q = db.BenhNhans.SingleOrDefault(i => i.MaBn.Equals(int.Parse(txtID.Text)));
                    if (q != null)
                        MessageBox.Show("\nMã bệnh nhân đã tồn tại!", "Thông báo");
                    else
                    {
                        BenhNhan bn = new BenhNhan();
                        bn.MaBn = int.Parse(txtID.Text);
                        bn.HoTen = txtName.Text;
                        bn.SoNgayNamVien = int.Parse(txtNum.Text);
                        Khoa k = (Khoa)cbb.SelectedItem;
                        bn.MaKhoa = k.MaKhoa;
                        bn.VienPhi = bn.SoNgayNamVien * 200000;
                        db.BenhNhans.Add(bn);
                        db.SaveChanges();
                        showData();
                        txtID.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void dtg_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                if (dtg.SelectedItems.Count == 1)
                {
                    Type t = dtg.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtID.Text = p[0].GetValue(dtg.SelectedValue).ToString().Trim();
                    txtName.Text = p[1].GetValue(dtg.SelectedValue).ToString();
                    cbb.Text = p[2].GetValue(dtg.SelectedValue).ToString();
                    txtNum.Text = p[3].GetValue(dtg.SelectedValue).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string str = cbb.Text;
            ExtraWindow w = new ExtraWindow(str);
            w.Show();
        }
    }
}
