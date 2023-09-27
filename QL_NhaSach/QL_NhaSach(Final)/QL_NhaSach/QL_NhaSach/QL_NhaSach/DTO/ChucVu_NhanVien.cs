using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    class ChucVu_NhanVien
    {
        public string MaNV { get; set; }
        public string MaCV { get; set; }
        public DateTime NgayNhanChuc { get; set; }
        public ChucVu_NhanVien()
        {
            this.NgayNhanChuc = DateTime.Now;
            MaNV = "";
            MaCV = "";
        }
    }
}
