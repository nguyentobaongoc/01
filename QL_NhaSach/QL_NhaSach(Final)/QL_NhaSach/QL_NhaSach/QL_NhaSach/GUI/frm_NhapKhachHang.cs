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
    public partial class frm_NhapKhachHang : Form
    {
        KhachHangBLL kh;
        KhachHang kh_hientai;
        public frm_NhapKhachHang()
        {
            InitializeComponent();
        }

        private void frm_NhapKhachHang_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng ký khách hàng";
            kh = new KhachHangBLL();
        }

        private void btn_ktra_Click(object sender, EventArgs e)
        {
            bool kq = kh.Check(gandulieu());
            if (kq)
            {
                MessageBox.Show("Chưa tồn tại", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Khách hàng đã tồn tại ! ", "Thông Báo");
            }
        }
        internal KhachHang thongtinkh()
        {
            return kh_hientai;
        }
        KhachHang gandulieu()
        {
            KhachHang a = new KhachHang();
            a.SDT = txt_Sdt.Text;
            a.TENKH = txt_HoTen.Text;
            a.DIACHI = txt_SoNhaDuong.Text;
            return a;
        }
        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            frmThemKhachHang new_form = new frmThemKhachHang();
            new_form.Owner = this;
            new_form.ShowDialog();
        }

        private void btn_chapnhan_Click(object sender, EventArgs e)
        {
            try
            {
                kh_hientai = kh.Thongtinkhachhang(txt_Sdt.Text)[0];
                this.Close();
            }
            catch
            {
                kh_hientai = new KhachHang();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
