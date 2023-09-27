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
namespace QL_NhaSach
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        NhanVien nv;
        public frm_Main(NhanVien i)
        {
            InitializeComponent();
            nv = i;
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            if (nv.PHANQUYEN == 3)
            {
                MessageBox.Show("Bạn đang đăng nhập với quyền của nhân viên kho. Bạn không có quyền thao tác vào mục này", "Thông báo");
                return;
            }
             if(nv.PHANQUYEN >=0)
             {
                 FrmNhanVien frm = new FrmNhanVien(nv);
                 frm.TopLevel = false;
                 this.panel2.Controls.Add(frm);
                 frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                 frm.Dock = DockStyle.Fill;
                 frm.Show();
             }
             else
             {
                 MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
             }
          
        }

        private void Time_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            muaHàngToolStripMenuItem_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Time_ToolStripMenuItem.Text = "";
            Time_ToolStripMenuItem.Text = now.ToString("HH:mm:ss tt");
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear() ;
            if (nv.PHANQUYEN == 3)
            {
                MessageBox.Show("Bạn đang đăng nhập với quyền của nhân viên kho. Bạn không có quyền thao tác vào mục này", "Thông báo");
                return;
            }
            if (nv.PHANQUYEN >= 0)
            {
                frmSach frm = new frmSach(nv);
                frm.TopLevel = false;
                this.panel2.Controls.Add(frm);
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            if (nv.PHANQUYEN >=0)
            {
                FrmThongKe_BaoCao frm = new FrmThongKe_BaoCao(nv);
                frm.TopLevel = false;
                this.panel2.Controls.Add(frm);
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            if (nv.PHANQUYEN == 3)
            {
                MessageBox.Show("Bạn đang đăng nhập với quyền của nhân viên kho. Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            if (nv.PHANQUYEN == 0)
            {
                frmKhachHang frm = new frmKhachHang(nv);
                frm.TopLevel = false;
                this.panel2.Controls.Add(frm);
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
                MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);


           
        }

        private void QL_TaiKhoan_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            if (nv.PHANQUYEN == 3)
            {
                MessageBox.Show("Bạn đang đăng nhập với quyền của nhân viên kho. Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            if (nv.PHANQUYEN == 0)
            {
                frmTaiKhoan frm = new frmTaiKhoan(nv);
                frm.TopLevel = false;
                this.panel2.Controls.Add(frm);
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
                MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
           
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void muaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            if (nv.PHANQUYEN == 3)
            {
                MessageBox.Show("Bạn đang đăng nhập với quyền của nhân viên kho. Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            if (nv.PHANQUYEN >= 0)
            {
                frm_MuaHang frm = new frm_MuaHang(nv);
                frm.TopLevel = false;
                this.panel2.Controls.Add(frm);
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                return;
            }
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.panel2.Controls.Clear();
            if (nv.PHANQUYEN == 3)
            {
                MessageBox.Show("Bạn đang đăng nhập với quyền của nhân viên kho. Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            if (nv.PHANQUYEN >= 0)
            {
                frmHoaDon frm = new frmHoaDon();
                frm.TopLevel = false;
                this.panel2.Controls.Add(frm);
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            if (nv.PHANQUYEN >= 0)
            {
                frmPhieuNhap frm = new frmPhieuNhap();
                frm.TopLevel = false;
                this.panel2.Controls.Add(frm);
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.panel2.Controls.Clear();
                if (nv.PHANQUYEN >= 0)
                {
                    frmThongKe_TonKho frm = new frmThongKe_TonKho(nv);
                    frm.TopLevel = false;
                    this.panel2.Controls.Add(frm);
                    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                }
                else
                    MessageBox.Show("Bạn đang đăng nhập với quyền của nhân viên kho. Bạn không có quyền thao tác vào mục này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                return;
            }
        }
           
    }
}
