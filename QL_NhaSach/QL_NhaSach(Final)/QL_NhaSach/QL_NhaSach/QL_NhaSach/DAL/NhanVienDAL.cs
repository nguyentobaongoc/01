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
    class NhanVienDAL
    {
        NHANVIENTableAdapter nv;
        DataConnect con;
        public NhanVienDAL()
        {
            nv = new NHANVIENTableAdapter();
            con = new DataConnect();
        }
        TaiKhoanDAL taikhoan;
        ChucVu_NhanVienDAL chucvu;
        public bool Insert(NhanVien a, TaiKhoan tk, ChucVu_NhanVien b)
        {
            try
            {
                    taikhoan = new TaiKhoanDAL();
                    chucvu = new ChucVu_NhanVienDAL();
                    bool kqTaiKhoan = taikhoan.Insert(tk);
                    if (!kqTaiKhoan)
                        return false;
                int i = (int)nv.ktraKhoa_NhanVien(a.MANV);
                if(i==0)
                {
                    nv.Insert(a.MANV, a.TENTAIKHOAN, a.HOTEN, a.NGAYSINH, a.SDT,a.DIACHI);
                    chucvu.Insert(b);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public List<NhanVien> Thongtinnhanvien(string tendn)
        {
             DataTable dt = nv.ThongTin_Nhanvien_TenDN(tendn);
             List<NhanVien> k = con.ListTable<NhanVien>(dt);
            return k;
        }
    }
}
