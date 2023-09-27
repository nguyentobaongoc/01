using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL;
using QL_NhaSach.DTO;

namespace QL_NhaSach.BLL
{
    class ChiTietPhieuNhapBLL
    {
        ChiTietPhieuNhapDAL dal;
        public ChiTietPhieuNhapBLL()
        {
            dal = new ChiTietPhieuNhapDAL();
        }
        public bool Insert(ChiTietPhieuNhap a)
        {
            return dal.Insert(a);
        }
    }
}
