using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class NhanVien
    {
        public string MANV { get; set; }
        public string TENTAIKHOAN { get; set; }
        public string HOTEN { get; set; }
        public string SDT { get; set; }
        public string DIACHI { get; set; }
        public DateTime NGAYSINH { get; set; }
        public int  PHANQUYEN { get; set; }
    }
}
