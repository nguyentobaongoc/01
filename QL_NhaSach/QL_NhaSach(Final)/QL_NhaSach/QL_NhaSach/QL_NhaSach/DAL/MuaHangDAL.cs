using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DTO;
using QL_NhaSach.DAL.ql_SachTableAdapters;
namespace QL_NhaSach.DAL
{
    class MuaHangDAL
    {
        HOADON_SACHTableAdapter hds;
        HOADONTableAdapter hd;
        public MuaHangDAL()
        {
            hds = new HOADON_SACHTableAdapter();
            hd = new HOADONTableAdapter();
        }
        public bool Insert(MuaHang a)
        {
            try
            {
                hd.Insert(a.hd.MAHD, a.hd.MaKH, a.nv.MANV, DateTime.Now, a.hd.PHUONGTHUC, a.hd.GIAMGIA);
                foreach(var item in a.dscthd)
                {
                    hds.Insert(item.MaSH, item.MaHD, item.SlBan);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
