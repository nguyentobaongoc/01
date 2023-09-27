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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
       
        TaiKhoanBLL tk;
        NhanVienBLL nvbll;
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            tk = new TaiKhoanBLL();
            nvbll = new NhanVienBLL();
        }

        private void ptb_DangNhap_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Bạn vui lòng điền mật khẩu");
                return;
            }
            if(String.IsNullOrEmpty(txt_Tendangnhap.Text))
            {
                MessageBox.Show("Bạn chưa điền tên đăng nhập");
                return;
            }
            TaiKhoan a = new TaiKhoan();
            a.tentaikhoan = txt_Tendangnhap.Text;
            a.matkhau = txt_MatKhau.Text;
            NhanVien nva = nvbll.Thongtinnhanvien(a.tentaikhoan)[0]; 
            if(tk.kiemTraDN(a))
            {
                
                    int i = tk.phanquyen(a);
                    frm_Main frm = new frm_Main(nva);
                    this.Hide();
                    frm.Show();
               
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng");
            }

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

       

        private void txt_Tendangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ptb_DangNhap_Click(sender, e);
            }
        }

        private void txt_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ptb_DangNhap_Click(sender, e);
            }
        }


    }
}
