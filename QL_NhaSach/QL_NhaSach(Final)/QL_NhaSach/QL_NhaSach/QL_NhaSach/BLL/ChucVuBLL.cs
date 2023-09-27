using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
namespace QL_NhaSach.BLL
{
    class ChucVuBLL
    {
          ChucVuDAL dal;
          public ChucVuBLL()
        {
            dal = new ChucVuDAL();
        }
        public bool Insert(ChucVu a)
        {
            return dal.Insert(a);
        }
        public bool Delete(ChucVu a)
        {
            return dal.Delete(a);
        }
    }
}
