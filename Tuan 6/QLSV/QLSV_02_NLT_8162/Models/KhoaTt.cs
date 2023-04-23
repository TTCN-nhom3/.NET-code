using System;
using System.Collections.Generic;

#nullable disable

namespace QLSV_02_NLT_8162.Models
{
    public partial class KhoaTt
    {
        public KhoaTt()
        {
            Svs = new HashSet<Sv>();
        }

        public string MaKtt { get; set; }
        public string TenKtt { get; set; }

        public virtual ICollection<Sv> Svs { get; set; }
    }
}
