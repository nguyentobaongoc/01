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
    public partial class frmNhapSach : Form
    {
        SachBLL s;
        public frmNhapSach()
        {
            InitializeComponent();
        }

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_Sach.NHAXUATBAN' table. You can move, or remove it, as needed.
            this.nHAXUATBANTableAdapter.Fill(this.ql_Sach.NHAXUATBAN);
            // TODO: This line of code loads data into the 'ql_Sach.THELOAI' table. You can move, or remove it, as needed.
            this.tHELOAITableAdapter.Fill(this.ql_Sach.THELOAI);
            s = new SachBLL();
        }
        Sach gandulieu()
        {
            Sach a = new Sach();
            a.MASACH = txt_MaSH.Text;
            a.TENSACH = txt_tensach.Text;
            a.MATL = cbo_TheLoai.SelectedValue.ToString();
            a.NAMXB = int.Parse(txt_NamXuatBan.Text);
            a.DONGIA = decimal.Parse(txt_Gia.Text);
            return a;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool kq = s.Insert(gandulieu());
            if (kq)
            {
                MessageBox.Show("Thêm thành công", "Thông Báo");

            }
            else
            {
                MessageBox.Show("Nhân viên hoặc tên tài khoản đã tồn tại. Bạn nên điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
            }
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_NamXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_Gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_ThemTL_Click(object sender, EventArgs e)
        {
            frm_ThemTheLoai frm = new frm_ThemTheLoai();
            frm.Owner = this;
            frm.ShowDialog();
            this.tHELOAITableAdapter.Fill(this.ql_Sach.THELOAI);

        }

        private void btn_ThemNSX_Click(object sender, EventArgs e)
        {
            frm_NXB frm = new frm_NXB();
            frm.ShowDialog();
            this.nHAXUATBANTableAdapter.Fill(this.ql_Sach.NHAXUATBAN);
        }

    }
}
