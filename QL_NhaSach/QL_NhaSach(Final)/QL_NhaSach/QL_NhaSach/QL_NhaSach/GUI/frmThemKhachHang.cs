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
    public partial class frmThemKhachHang : Form
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
            kh = new KhachHangBLL();
        }
        KhachHangBLL kh;
        KhachHang gandulieu()
        {
            KhachHang a = new KhachHang();
            a.MAKH = random();
            a.TENKH = txt_HoTen.Text;
            a.SDT =  txt_SDT.Text;
            a.DIACHI = txt_SoNhaDuong.Text;
            return a;
        }
        string random()
        {
            string ma = "KH";
            Random autoRand = new Random();
            for (int x = 0; x < 2; x++)
            {
                ma += autoRand.Next(1, 99).ToString();
            }
            return ma;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void frmThemKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            this.Hide();
            this.Owner.Show();
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                this.Owner.Show();
            }
            catch
            {
                return;
            }
      
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool kq = kh.Insert(gandulieu());
            if (kq)
            {
                MessageBox.Show("Thêm thành công", "Thông Báo");

            }
            else
            {
                MessageBox.Show("Khách hàng đã tồn tại hoặc bạn chưa điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
            }
        }

       
     
    }
}
