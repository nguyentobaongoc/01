using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL.ql_SachTableAdapters;
using QL_NhaSach.DTO;
namespace QL_NhaSach.DAL
{
    class TheLoaiDAL
    {
        THELOAITableAdapter loai;
        DataConnect con;
        public TheLoaiDAL()
        {
            loai = new THELOAITableAdapter();
            con = new DataConnect();
        }
       public int soluongloai()
        {
            return int.Parse(loai.TongTheLoai().ToString());
        }
        public List<TheLoai> Getdata()
        {
            DataConnect con = new DataConnect();
            return con.ListTable<TheLoai>(loai.GetData());
        }
    }
}
