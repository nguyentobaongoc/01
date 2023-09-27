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
     class SachBLL
    {
        SachDAL dal = new SachDAL();
        public List<Sach> GetList()
        {
            return dal.GetList();
        }
        public List<Sach> GetList_MaSach(string masach)
        {
            return dal.GetList_MaSach(masach);
        }
        public List<Sach> DoanhThuNgay()
        {
            return dal.DoanhThuNgay();
        }
        public List<Sach> TongDoanhThu()
        {
            return dal.TongDoanhThu();
        }
        public List<Sach> DoanhThuThang()
        {
            return dal.DoanhThuThang();
        }
        public List<Sach> DoanhThuTuan()
        {
            return dal.DoanhThuTuan();
        }
        public List<Sach> TonKho()
        {
            return dal.TonKho();
        }
        public List<Sach> GetDataSach()
        {
            return dal.GetDataSach();
        }
        public bool Check(Sach a)
        {
            return dal.ktraKhoa(a);
        }
        public bool Insert(Sach a)
        {
            return dal.Insert(a);
        }
    }
}
