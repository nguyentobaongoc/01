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
    public partial class frm_ChiTietPhieuNhap : Form
    {
        public frm_ChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        ChiTietPhieuNhapBLL ctpn;
        private void frm_ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            this.pHIEUNHAPTableAdapter.Fill(ql_Sach.PHIEUNHAP);
            this.nHAXUATBANTableAdapter.Fill(this.ql_Sach.NHAXUATBAN);
            this.tHELOAITableAdapter.Fill(this.ql_Sach.THELOAI);
            this.sACHTableAdapter.Fill(this.ql_Sach.SACH);
            ctpn = new ChiTietPhieuNhapBLL();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptb_LoadSach_Click(object sender, EventArgs e)
        {
            this.sACHTableAdapter.Fill(this.ql_Sach.SACH);
        }
        ChiTietPhieuNhap gandulieu()
        {
            ChiTietPhieuNhap a = new ChiTietPhieuNhap();
            a.MaPN = cbo_PhieuNhap.SelectedValue.ToString();
            a.MaSH = cbo_Masach.SelectedValue.ToString();
            a.SL = int.Parse(txt_SL.Text);
            a.DonGia = decimal.Parse(txt_DonGia.Text);
            return a;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool kq = ctpn.Insert(gandulieu());
            if (kq)
            {
                MessageBox.Show("Thêm thành công", "Thông Báo");
                this.cHITIETPHIEUNHAPTableAdapter.FillBy_TheoMa(ql_Sach.CHITIETPHIEUNHAP, cbo_PhieuNhap.SelectedValue.ToString());

            }
            else
            {
                MessageBox.Show("Nhân viên hoặc tên tài khoản đã tồn tại. Bạn nên điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbo_PhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cHITIETPHIEUNHAPTableAdapter.FillBy_TheoMa(ql_Sach.CHITIETPHIEUNHAP, cbo_PhieuNhap.SelectedValue.ToString());
        }

    }
}
