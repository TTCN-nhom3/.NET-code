using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2_bai2
{
    internal class NhanVien
    {
        public string maNV { get; set; }
        public string hoTen { get; set; }
        public double tienLuongNgay { get; set; }
        public float soNgayLV { get; set; }

        public void nhap(string manv, string ht, double tln, float snlv)
        {
            maNV = manv.ToUpper();
            hoTen = ht.ToUpper();
            tienLuongNgay = tln;
            soNgayLV = snlv;
        }

        public double luong()
        {
            double kq = 0;
            if (soNgayLV <= 24)
                kq = soNgayLV * tienLuongNgay;         
            else
                kq = (24 + (soNgayLV - 24) * 2) * tienLuongNgay;
            return kq;
        }

    }
}
