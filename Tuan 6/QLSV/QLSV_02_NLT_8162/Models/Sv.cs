using System;
using System.Collections.Generic;

#nullable disable

namespace QLSV_02_NLT_8162.Models
{
    public partial class Sv
    {
        public string MaSv { get; set; }
        public string TenSv { get; set; }
        public int? SoLanXs { get; set; }
        public string MaKtt { get; set; }
        public string TienThuong { get; set; }

        public virtual KhoaTt MaKttNavigation { get; set; }
    }
}
