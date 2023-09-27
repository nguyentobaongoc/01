using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
using QL_NhaSach.DAL.ql_SachTableAdapters;

namespace QL_NhaSach.BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL dal = new HoaDonDAL();
        public List<HoaDon> GetList()
        {
            return dal.GetList();
        }
        
    }
}
