using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class HoaDon
    {
        public string MAHD { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public DateTime NGAYIN { get; set; }
        public bool PHUONGTHUC { get; set; }
        public decimal GIAMGIA { get; set; }
    }
}
