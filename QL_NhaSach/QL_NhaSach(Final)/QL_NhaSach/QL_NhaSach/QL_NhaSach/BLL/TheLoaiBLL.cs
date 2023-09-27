using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DTO;
using QL_NhaSach.DAL;
namespace QL_NhaSach.BLL
{
    class TheLoaiBLL
    {
         TheLoaiDAL lm;
         public TheLoaiBLL()
        {
            lm = new TheLoaiDAL();
        }
         public int soluongLoai()
         {
             return lm.soluongloai();
         }
        public List<TheLoai> Getdata()
        {
            return lm.Getdata();
        }
    }
}
