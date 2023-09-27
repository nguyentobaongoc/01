using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL.ql_SachTableAdapters;
using QL_NhaSach.DTO;

namespace QL_NhaSach.DAL
{
    class PhieuNhapDAL
    {
        PHIEUNHAPTableAdapter pn;
        public PhieuNhapDAL()
        {
            pn = new PHIEUNHAPTableAdapter();
        }
        public bool Insert(PhieuNhap a)
        {
            //try
            //{
            //    int i = (int)pn.ktraKhoa_PhieuNhap(a.MaPN);
            //    if (i == 0)
            //    {
            //        pn.Insert(a.MaPN, a.MaNCC, a.MaNV, a.TenPN, a.NgayNhap);
            //        return true;
            //    }
            //    return false;
            //}
            //catch
            //{
            //    return false;
            //}
            return true;
        }
    }
}
