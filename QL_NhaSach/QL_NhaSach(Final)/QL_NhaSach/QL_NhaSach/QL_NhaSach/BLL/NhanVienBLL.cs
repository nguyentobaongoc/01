using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
namespace QL_NhaSach.BLL
{
    class NhanVienBLL
    {
         NhanVienDAL dal;
         public NhanVienBLL()
        {
            dal = new NhanVienDAL();
        }
         public bool Insert(NhanVien a, TaiKhoan b, ChucVu_NhanVien c)
        {
            return dal.Insert(a, b, c);
        }
         public List<NhanVien> Thongtinnhanvien(string tendn)
         {
             return dal.Thongtinnhanvien(tendn);
         }
    }
}
