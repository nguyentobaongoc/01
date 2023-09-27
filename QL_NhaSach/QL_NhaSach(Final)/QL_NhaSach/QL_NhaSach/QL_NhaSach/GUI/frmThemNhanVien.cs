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
namespace QL_NhaSach.GUI
{
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        NhanVienBLL nv = new NhanVienBLL();

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            this.Text = "Cập nhật nhân viên";
            // TODO: This line of code loads data into the 'ql_Sach.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.ql_Sach.CHUCVU);

        }

        private void frmThemNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
        NhanVien gandulieu()
        {
            NhanVien a = new NhanVien();
            a.MANV = txt_MaNV.Text;
            a.HOTEN = txt_HoTen.Text;
            a.SDT = txt_SDT.Text;
            a.TENTAIKHOAN = txt_TenTaiKhoan.Text;
            a.NGAYSINH = DateTime.Parse(mtxt_NgaySinh.Text);
            a.DIACHI = txt_SoNhaDuong.Text;
            return a;
        }
        ChucVu_NhanVien gandulieucvnv()
        {
            ChucVu_NhanVien a = new ChucVu_NhanVien();
            a.MaCV = cbo_ChucVu.SelectedValue.ToString();
            a.MaNV = txt_MaNV.Text;
            return a;
        }
        TaiKhoan gandulieutk()
        {
            TaiKhoan a = new TaiKhoan();
            a.tentaikhoan = txt_TenTaiKhoan.Text ;
            a.matkhau = txt_MatKhau.Text;
            return a;
        }
       

        private void frmThemNhanVien_Shown(object sender, EventArgs e)
        {
            this.cHUCVUTableAdapter.Fill(this.ql_Sach.CHUCVU);
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool kq = nv.Insert(gandulieu(), gandulieutk(), gandulieucvnv());
            if (kq)
            {
                MessageBox.Show("Thêm thành công", "Thông Báo");
                
            }
            else
            {
                MessageBox.Show("Nhân viên hoặc tên tài khoản đã tồn tại. Bạn nên điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
            }
        }

        private void btn_ThemChucVu_Click(object sender, EventArgs e)
        {
            frmThemChucVu frm = new frmThemChucVu();
            frm.ShowDialog();
        }

        private void ptb_LoadSach_Click(object sender, EventArgs e)
        {
            this.cHUCVUTableAdapter.Fill(this.ql_Sach.CHUCVU);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    
    }
}
