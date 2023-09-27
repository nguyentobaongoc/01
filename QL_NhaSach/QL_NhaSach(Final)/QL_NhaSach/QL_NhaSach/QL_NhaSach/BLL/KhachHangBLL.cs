using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
namespace QL_NhaSach.BLL
{
    class KhachHangBLL
    {
        KhachHangDAL dal;
        public KhachHangBLL()
        {
            dal = new KhachHangDAL();
        }
        public bool Insert(KhachHang a)
        {
            return dal.Insert(a);
        }
        public bool Check(KhachHang a)
        {
            return dal.ktraKhoa(a);
        }
        public List<KhachHang> Thongtinkhachhang(string ma)
        {
            return dal.Thongtinkhachhang(ma);
        }
    }
}
