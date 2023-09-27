using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL.ql_SachTableAdapters;
using QL_NhaSach.DTO;
namespace QL_NhaSach.DAL
{
    class TaiKhoanDAL
    {
        TAIKHOANTableAdapter tk;
        public TaiKhoanDAL()
        {
            tk = new TAIKHOANTableAdapter();
        }
        public bool Insert(TaiKhoan a)
        {
            try
            {
                int i = (int)tk.ktraKhoa_TaiKhoan(a.tentaikhoan);
                if(i==0)
                {
                    tk.Insert(a.tentaikhoan, a.matkhau);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool kiemTraDN(TaiKhoan a)
        {
            try
            {
                int i = int.Parse(tk.Kiemtra_DangNhap(a.matkhau, a.tentaikhoan).ToString());
                if (i == 1)
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
        public int phanquyen(TaiKhoan a)
        {
            try
            {
                int i = (int)tk.ScalarQuery_PhanQuyen(a.tentaikhoan);
                return i;
            }
            catch
            {
                return 0;
            }
        }
        public bool Delete(TaiKhoan a)
        {
            try
            {
                int i = (int)tk.ktraKhoa_TaiKhoan(a.tentaikhoan);
                if (i == 0)
                {
                    tk.XoaTaiKhoan_NhanVien(a.tentaikhoan);
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
