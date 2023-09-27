using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL.ql_SachTableAdapters;
using QL_NhaSach.DTO;
using System.Data;
namespace QL_NhaSach.DAL
{
    class KhachHangDAL
    {
        KHACHHANGTableAdapter kh;
        DataConnect con;
        public KhachHangDAL()
        {
            kh = new KHACHHANGTableAdapter();
            con = new DataConnect();
        }
        public List<KhachHang> Thongtinkhachhang(string ma)
        {
            DataTable dt = kh.GetDataBy_Thongtinkhachang(ma);
            List<KhachHang> k = con.ListTable<KhachHang>(dt);
            return k;
        }
        public bool Insert(KhachHang a)
        {
            try
            {
                int i = (int)kh.ktraKhoa_KhachHang(a.MAKH);
                if(i==0)
                {
                    kh.Insert(a.MAKH, a.TENKH, 0, a.SDT, DateTime.Now, a.DIACHI);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool ktraKhoa(KhachHang a)
        {
            try
            {
                int i = (int)kh.ktraKhoa(a.SDT);
                if (i == 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
