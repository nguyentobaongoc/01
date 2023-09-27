using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL.ql_SachTableAdapters;
using QL_NhaSach.DTO;
namespace QL_NhaSach.DAL
{
    class ChucVuDAL
    {
        CHUCVUTableAdapter nv;
        public ChucVuDAL()
        {
            nv = new CHUCVUTableAdapter();
        }
        public bool Insert(ChucVu a)
        {
            try
            {
                int i = (int)nv.ktraKhoa_ChucVu(a.MaCV);
                if(i==0)
                {
                    nv.Insert(a.MaCV, a.TenCV);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(ChucVu a)
        {
            try
            {
                int i = (int)nv.ktraKhoa_ChucVu(a.MaCV);
                if (i >=1)
                {
                    nv.Delete(a.MaCV);
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
