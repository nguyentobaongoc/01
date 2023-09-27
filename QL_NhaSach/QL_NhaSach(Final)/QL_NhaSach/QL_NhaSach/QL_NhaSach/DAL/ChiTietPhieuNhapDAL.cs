using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL.ql_SachTableAdapters;
using QL_NhaSach.DTO;

namespace QL_NhaSach.DAL
{
    class ChiTietPhieuNhapDAL
    {
        CHITIETPHIEUNHAPTableAdapter ctpn;
        public ChiTietPhieuNhapDAL()
        {
            ctpn = new CHITIETPHIEUNHAPTableAdapter();
        }
        public bool Insert(ChiTietPhieuNhap a)
        {
            try
            {
                ctpn.Insert(a.MaSH, a.MaPN, a.SL, a.DonGia);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
