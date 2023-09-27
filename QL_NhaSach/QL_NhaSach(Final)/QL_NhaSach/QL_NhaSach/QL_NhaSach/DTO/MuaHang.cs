using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
   class MuaHang
    {
            public NhanVien nv { get; set; }
            public HoaDon hd { get; set; }
            public List<HoaDon_Sach> dscthd { get; set; }

            public KhachHang kh { get; set; }
            public MuaHang()
            {
                this.nv = new NhanVien();
                this.hd = new HoaDon();
                this.dscthd = new List<HoaDon_Sach>();
                this.kh = new KhachHang();
            }
            public MuaHang(NhanVien d,HoaDon a, List<HoaDon_Sach> b, KhachHang c)
            {
                nv = d;
                hd = a;
                dscthd = b;
                kh = c;
            }
    }
}
