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
using System.Text.RegularExpressions;
using QLSV_02_NLT_8162.Models;
using System.Reflection;
using System.Data.SqlClient;

namespace QLSV_02_NLT_8162
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
        QLSVContext db = new QLSVContext();
        private bool checkData() // Bắt các ngoại lệ
        {
            string ms = "";
            if (txtName.Text == "" || txtID.Text == "" || txtNum.Text == "" || cbb.SelectedItem == null)
                ms += "\nHãy điền đầy đủ thông tin!";
            if (txtNum.Text != "")
            {
                if (!Regex.IsMatch(txtNum.Text, @"\d+"))
                    ms += "\nSố lần xuất sắc phải là số!";
                else if (Int32.Parse(txtNum.Text) < 0)
                    ms += "\nSố lần xuất sắc phải lớn hơn -1!";
            }
            if (ms == "")
                return true;
            else
            {
                MessageBox.Show(ms, "Thông báo");
                return false;
            }
        }
        private void showData() // Hiển thị danh sách lên DataGrid
        {
            var q = from s in db.Svs
                    join k in db.KhoaTts on s.MaKtt equals k.MaKtt
                    select new
                    {
                        s.MaSv,
                        s.TenSv,
                        s.SoLanXs,
                        k.TenKtt,
                        s.TienThuong
                    };
            dtg.ItemsSource = q.ToList();
        }
        private void showCB() // Đưa dữ liệu và hiển thị ComboBox
        {
            var q = db.KhoaTts.Select(k => k);
            cbb.ItemsSource = q.ToList();
            cbb.DisplayMemberPath = "TenKtt";
            cbb.SelectedValuePath = "MaKtt";
            cbb.SelectedIndex = 0;
        }
        private void clearAllText() // Clear các textbox và combobox
        {
            txtID.Clear();
            txtName.Clear();
            txtNum.Clear();
            cbb.Text = "";
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e) // Click nút "Thêm"
        {
            if (checkData())
            {
                try
                {
                    var q = db.Svs.SingleOrDefault(s => s.MaSv.Equals(txtID.Text));
                    if (q != null)
                        MessageBox.Show("Mã SV này đã tồn tại", "Thông báo");
                    else
                    {
                        Sv s = new Sv();
                        s.MaSv = txtID.Text;
                        s.TenSv = txtName.Text;
                        s.SoLanXs = int.Parse(txtNum.Text);
                        KhoaTt k = (KhoaTt)cbb.SelectedItem;
                        s.MaKtt = k.MaKtt;
                        if (s.SoLanXs >= 5)
                            s.TienThuong = "500.000";
                        else if (s.SoLanXs > 1)
                            s.TienThuong = "200.000";
                        else
                            s.TienThuong = "0";
                        db.Svs.Add(s);
                        db.SaveChanges();
                        showData();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
                txtID.Focus();
                dtg.SelectedItems.Clear();
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtID.Focus();
            showCB();
            showData();
        }
        private void btnRemove_Click(object sender, RoutedEventArgs e) // Click nút "Xóa"
        {
            if (dtg.SelectedItems.Count != 0) // Xóa 1 sinh viên ứng với dòng đã chọn trên DataGrid 
            {
                Type t = dtg.SelectedItem.GetType();
                PropertyInfo[] p = t.GetProperties();
                string id = p[0].GetValue(dtg.SelectedValue).ToString();
                string name = p[1].GetValue(dtg.SelectedValue).ToString();
                string k = p[3].GetValue(dtg.SelectedValue).ToString();
                var r = db.Svs.SingleOrDefault(s => s.MaSv.Equals(id));
                MessageBoxResult ms = MessageBox.Show("Bạn muốn xóa sinh viên '"
                    + id.Trim() + " - " + name.Trim() + " - " + k.Trim() +
                    "'?", "Thông báo", MessageBoxButton.YesNo);
                if (ms == MessageBoxResult.Yes)
                {
                    db.Svs.Remove(r);
                    db.SaveChanges();
                    showData();
                    clearAllText();
                    dtg.SelectedItems.Clear();
                }
            }
            else // Xóa toàn bộ sinh viên khi không có dòng nào được chọn trên DataGrid
            {
                MessageBoxResult ms = MessageBox.Show("Bạn muốn xóa tất cả sinh viên?",
                    "Thông báo", MessageBoxButton.YesNo);
                if (ms == MessageBoxResult.Yes)
                {
                    var q = (from s in db.Svs
                             select s).ToList();
                    foreach (var s in q)
                        db.Svs.Remove(s);
                    db.SaveChanges();
                    showData();
                    clearAllText();
                }
            }
            txtID.Focus();
        }
        private void dtg_SelectionChanged(object sender, SelectionChangedEventArgs e) // Chọn 1 dòng trong DataGrid
        {
                Type t = dtg.SelectedItem.GetType();
                PropertyInfo[] p = t.GetProperties();
                txtID.Text = p[0].GetValue(dtg.SelectedValue).ToString();
                txtName.Text = p[1].GetValue(dtg.SelectedValue).ToString();
                txtNum.Text = p[2].GetValue(dtg.SelectedValue).ToString();
                cbb.SelectedValue = p[3].GetValue(dtg.SelectedValue).ToString();
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e) // Click nút "Tìm"
        {
            if (txtID.Text != "") // Khi txtID có dữ liệu thì tìm theo maSV
            {
                var q = from s in db.Svs
                        join k in db.KhoaTts on s.MaKtt equals k.MaKtt
                        where s.MaSv == txtID.Text
                        select new
                        {
                            s.MaSv, s.TenSv, s.SoLanXs, k.TenKtt, s.TienThuong
                        };
                dtg.ItemsSource = q.ToList();
            }
            else if (txtName.Text != "") // Khi txtID không có dữ liệu mà txtName có thì tìm theo tenSV
            {
                var q = from s in db.Svs
                        join k in db.KhoaTts on s.MaKtt equals k.MaKtt
                        where s.TenSv == txtName.Text
                        select new
                        {
                            s.MaSv, s.TenSv, s.SoLanXs, k.TenKtt, s.TienThuong
                        };
                dtg.ItemsSource = q.ToList();
            }
            else if (txtNum.Text != "") // Khi txtID, txtName không có dữ liệu mà txtNum có thì tìm theo slXS
            {
                var q = from s in db.Svs
                        join k in db.KhoaTts on s.MaKtt equals k.MaKtt
                        where s.SoLanXs == int.Parse(txtNum.Text)
                        select new
                        {
                            s.MaSv, s.TenSv, s.SoLanXs, k.TenKtt, s.TienThuong
                        };
                dtg.ItemsSource = q.ToList();
            }
            else if (cbb.SelectedItem != null) // Khi txtID, txtName, txtNum không có dữ liệu mà cbb có thì tìm theo KTT
            {
                //var q = from s in db.Svs
                //        join k in db.KhoaTts on s.MaKtt equals k.MaKtt
                //        where k.MaKtt == cbb.SelectedValue
                //        select new
                //        {
                //            s.MaSv, s.TenSv, s.SoLanXs, k.TenKtt, s.TienThuong
                //        };
                dtg.ItemsSource = q.ToList();
            }
            txtID.Focus();
            dtg.SelectedItems.Clear();
        }
        private void btnChange_Click(object sender, RoutedEventArgs e) // Click nút "Sửa"
        {
            var q = db.Svs.SingleOrDefault(s => s.MaSv.Equals(txtID.Text));
            if (q != null)
            {
                q.TenSv = txtName.Text;
                q.SoLanXs = int.Parse(txtNum.Text);
                KhoaTt k = (KhoaTt)cbb.SelectedItem;
                q.MaKtt = k.MaKtt;
                if (q.SoLanXs >= 5)
                    q.TienThuong = "500.000";
                else if (q.SoLanXs > 1)
                    q.TienThuong = "200.000";
                else
                    q.TienThuong = "0";
                db.SaveChanges();
                showData();
                clearAllText();
                dtg.SelectedItems.Clear();
            }
            else
            {
                MessageBox.Show("Không tồn tại mã sinh viên '" + txtID.Text + "'!", "Thông báo");
            }
        }
        private void btnShow_Click(object sender, RoutedEventArgs e) // Click nút "Thêm"
        {
            showData();
            clearAllText();
            txtID.Focus();
            dtg.SelectedItems.Clear();
        }
        //private void cbb_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    dtg.SelectedItems.Clear();
        //}
        //private void txtNum_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    dtg.SelectedItems.Clear();
        //}
        //private void txtName_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    dtg.SelectedItems.Clear();
        //}
        //private void btnAdd_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    dtg.SelectedItems.Clear();
        //}
    }
}