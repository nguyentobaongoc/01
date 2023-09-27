using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
namespace QL_NhaSach.BLL
{
    class TaiKhoanBLL
    {
        TaiKhoanDAL dal;
        public TaiKhoanBLL()
        {
            dal = new TaiKhoanDAL();
        }
        public bool Insert(TaiKhoan a)
        {
            return dal.Insert(a);
        }
         public bool kiemTraDN(TaiKhoan a)
        {
            return dal.kiemTraDN(a);
        }
         public int phanquyen(TaiKhoan a)
         {
             return dal.phanquyen(a);
         }
    }
}
