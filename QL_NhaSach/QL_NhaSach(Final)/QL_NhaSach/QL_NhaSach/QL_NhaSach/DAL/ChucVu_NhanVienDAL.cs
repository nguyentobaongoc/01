using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL.ql_SachTableAdapters;
using QL_NhaSach.DTO;
namespace QL_NhaSach.DAL
{
    class ChucVu_NhanVienDAL
    {
        
        CHUCVU_NHANVIENTableAdapter cv;
        public ChucVu_NhanVienDAL()
        {
            cv = new CHUCVU_NHANVIENTableAdapter();
        }
        public bool Insert(ChucVu_NhanVien a)
        {
            try
            {
                    cv.Insert(a.MaCV, a.MaNV,a.NgayNhanChuc);
                    return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(ChucVu_NhanVien a)
        {
            try
            {
                cv.XoaChuVu_NhanVien(a.MaNV);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
