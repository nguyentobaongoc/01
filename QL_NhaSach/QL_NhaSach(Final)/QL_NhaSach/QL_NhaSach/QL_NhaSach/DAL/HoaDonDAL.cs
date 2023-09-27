using System;
using System.Collections.Generic;
using QL_NhaSach.DTO;
using QL_NhaSach.DAL.ql_SachTableAdapters;
using System.Data;
using System.Data.SqlClient;


namespace QL_NhaSach.DAL
{
    public class HoaDonDAL
    {
        HOADONTableAdapter dshd;
        DataConnect con;
        public HoaDonDAL()
        {
            con = new DataConnect();
            dshd = new HOADONTableAdapter();
        }
        private HoaDon GetStudentFromDataRow(DataRow row)
        {
            HoaDon hd = new HoaDon();
            hd.MAHD = row["MAHD"].ToString().Trim();
            hd.NGAYIN = DateTime.Parse(row["NGAYIN"].ToString().Trim());
            return hd;
        }
        //public void LoadNgay()
        //{
        //    DataSet ds = new DataSet();
        //    string sql = "select SACH.MASACH,TENSACH,DONGIABAN, count(SACH.MASACH) as SoLuong from HOADON_SACH,SACH,HOADON where HOADON_SACH.MASACH=SACH.MASACH and NGAYIN=GETDATE() group by SACH.MASACH,TENSACH,DONGIABAN";
        //    SqlDataAdapter da = new SqlDataAdapter(sql, con);
        //    da.Fill(ds, "HoaDon_Sach");

        //}
        public List<HoaDon> GetList()
        {
            DataTable dt = dshd.GetData();
            List<HoaDon> list_hd = con.ListTable<HoaDon>(dt);
            return list_hd;
        }
    }
}
