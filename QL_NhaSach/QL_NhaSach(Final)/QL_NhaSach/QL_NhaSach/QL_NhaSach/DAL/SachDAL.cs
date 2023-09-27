using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL_NhaSach.DTO;
using QL_NhaSach.DAL.ql_SachTableAdapters;

namespace QL_NhaSach.DAL
{
     class SachDAL
    {
        SACHTableAdapter dssach;
        DataConnect con;
        public SachDAL()
        {
            con = new DataConnect();
            dssach = new SACHTableAdapter();
        }
        public List<Sach> GetList()
        {
            DataTable dt = dssach.GetData();
            List<Sach> list_sach = con.ListTable<Sach>(dt);
            return list_sach;
        }
        public List<Sach> GetList_MaSach(string masach)
        {
            DataTable dt = dssach.GetDataByMaSach(masach);
            List<Sach> list_sach = con.ListTable<Sach>(dt);
            return list_sach;
        }

        public List<Sach> DoanhThuNgay()
        {
            DataTable dt = dssach.TongDoanhThu();
            List<Sach> list_sh = con.ListTable<Sach>(dt);
            return list_sh;
        }
        public List<Sach> TongDoanhThu()
        {
            DataTable dt = dssach.TongDoanhThu();
            List<Sach> list_sh = con.ListTable<Sach>(dt);
            return list_sh;
        }
        public List<Sach> DoanhThuThang()
        {
            DataTable dt = dssach.DoanhThuThang();
            List<Sach> list_sh = con.ListTable<Sach>(dt);
            return list_sh;
        }
        public List<Sach> DoanhThuTuan()
        {
            DataTable dt = dssach.DoanhThuTuan();
            List<Sach> list_sh = con.ListTable<Sach>(dt);
            return list_sh;
        }
        public List<Sach> TonKho()
        {
            DataTable dt = dssach.TonKho();
            List<Sach> list_sh = con.ListTable<Sach>(dt);
            return list_sh;
        }
        public List<Sach> GetDataSach()
        {
            DataTable dt = dssach.GetDataSach();
            List<Sach> list_sh = con.ListTable<Sach>(dt);
            return list_sh;
        }
        public bool ktraKhoa(Sach a)
        {
            try
            {
                int i = (int)dssach.ktraKhoa_Sach(a.MASACH);
                if (i == 0)
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
        public bool Insert(Sach a)
        {
            try
            {
                int i = (int)dssach.ktraKhoa_Sach(a.MASACH);
                if (i == 0)
                {
                    dssach.Insert(a.MASACH, a.MANXB,a.MATL, a.TENSACH, a.NAMXB, a.DONGIA, a.TACGIA);
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
