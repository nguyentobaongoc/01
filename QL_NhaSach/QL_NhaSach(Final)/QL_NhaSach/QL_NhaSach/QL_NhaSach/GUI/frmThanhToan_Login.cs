using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NhaSach.DTO;
using QL_NhaSach.BLL;
namespace QL_NhaSach
{
     partial class frmThanhToan_Login : Form
    {
        MuaHang mh;
        MuaHangBLL mhbll;
        public frmThanhToan_Login()
        {
            InitializeComponent();
        }
        public frmThanhToan_Login(MuaHang a)
        {
            InitializeComponent();
            this.mh = a;


        }
         void thongke()
        {
            lbl_NhanVien.Text = mh.nv.HOTEN;
            lbl_HotenKH.Text = mh.kh.TENKH;
            lbl_Sdt.Text = mh.kh.SDT;
            lbl_dtl.Text = mh.kh.DIEMTICHLUY.ToString();
            lbl_tongtien.Text = mh.dscthd.Where(t => t.MaHD == mh.hd.MAHD).Sum(r => r.SlBan * r.DonGiaBan).ToString();
            if(mh.kh.DIEMTICHLUY >10)
            {
                double tongtien = double.Parse(mh.dscthd.Sum(t=>t.DonGiaBan).ToString());
                lbl_tongtien.Text =  tongtien.ToString();
                
                    int dtl = mh.kh.DIEMTICHLUY;
                    if(dtl >20)
                    {
                        mh.hd.GIAMGIA = (decimal)(tongtien * 0.1);
                        lbl_Giam.Text = mh.hd.GIAMGIA.ToString();
                    }
                else
                    {
                        if(dtl >30)
                        {
                            mh.hd.GIAMGIA = (decimal)(tongtien * 0.15);
                            lbl_Giam.Text = mh.hd.GIAMGIA.ToString();
                        }
                        else
                        {
                            if(dtl>45)
                            {
                                mh.hd.GIAMGIA = (decimal)( tongtien * 0.2);
                                lbl_Giam.Text = mh.hd.GIAMGIA.ToString();
                            }
                            else
                            {
                                lbl_Giam.Text = "";
                            }
                              
                        }
                    }
                
            }
        }
        private void frmThanhToan_Login_Load(object sender, EventArgs e)
        {
            this.Text = "Thanh toán";
            thongke();
            dgv_Hoadon.DataSource = mh.dscthd;
            mhbll = new MuaHangBLL();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            if (mhbll.Insert(mh))
            {
                MessageBox.Show("Bạn đã thanh toán thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hệ thống bị lỗi");
            }
        }

        private void rdo_TienMat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_ChuyenKhoan.Checked)
            {
                mh.hd.PHUONGTHUC = true;
            }
            else
            {
                mh.hd.PHUONGTHUC = false;
            }
        }

       
       
    }
}
