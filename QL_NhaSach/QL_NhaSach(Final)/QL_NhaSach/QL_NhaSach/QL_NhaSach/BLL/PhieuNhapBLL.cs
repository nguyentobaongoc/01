using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
namespace QL_NhaSach.BLL
{
    class PhieuNhapBLL
    {
        PhieuNhapDAL dal;
        public PhieuNhapBLL()
        {
            dal = new PhieuNhapDAL();
        }
        public bool Insert(PhieuNhap a)
        {
            return dal.Insert(a);
        }
    }
}
