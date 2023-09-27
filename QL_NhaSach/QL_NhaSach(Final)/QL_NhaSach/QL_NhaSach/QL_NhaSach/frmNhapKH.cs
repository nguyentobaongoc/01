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
    public partial class frmNhapKH : Form
    {
        KhachHangBLL kh;
        KhachHang kh_hientai;
        public frmNhapKH()
        {
            InitializeComponent();
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

        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            frmThemKhachHang new_form = new frmThemKhachHang();
            new_form.Owner = this;
            this.Close();
            new_form.Show();
        }
        KhachHang gandulieu()
        {
            KhachHang a = new KhachHang();
            a.SDT = txt_Sdt.Text;
            a.TENKH = txt_HoTen.Text;
            a.DIACHI = txt_SoNhaDuong.Text;
            return a;
        }
        internal KhachHang thongtinkh()
        {
            return kh_hientai;
        }
        private void btn_chapnhan_Click(object sender, EventArgs e)
        {

            try
            {
                kh_hientai = kh.Thongtinkhachhang(txt_Sdt.Text)[0];
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void frmNhapKH_Load(object sender, EventArgs e)
        {
            kh = new KhachHangBLL();
        }
    }
}
