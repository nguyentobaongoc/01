using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DTO;
using QL_NhaSach.DAL;
namespace QL_NhaSach.BLL
{
    class MuaHangBLL
    {
        MuaHangDAL dal;
        public MuaHangBLL()
        {
            dal = new MuaHangDAL();
        }
        public bool Insert(MuaHang a)
        {
            return dal.Insert(a);
        }
    }
}
