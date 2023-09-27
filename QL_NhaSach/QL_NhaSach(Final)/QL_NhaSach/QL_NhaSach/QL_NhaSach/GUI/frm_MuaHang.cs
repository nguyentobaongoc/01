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
     partial class frm_MuaHang : Form
    {
        TheLoaiBLL tl;
        MuaHang mh = new MuaHang();
        int dong = 0;
        public frm_MuaHang()
        {
            InitializeComponent();
        } 
        public frm_MuaHang(NhanVien i )
        {
            InitializeComponent();
            mh.nv = i;
        }
        void taobuttonloai()
        {
            List<TheLoai> l = tl.Getdata();
            int sl = tl.soluongLoai();
            int x = 20;
            sl = sl / 7;
            int y = 320;
            
            int soloai = 0;
            for (int i = 0; i < sl; i++)
            {
                if (soloai > 0)
                {
                    x += 180;
                }
                for (int j = 0; j < 7; j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.White;
                    btn.Enabled = true;
                    btn.Name = l[soloai].MATL;
                    btn.Text = l[soloai].TENTL;
                    btn.Width = 135;
                    btn.Height = 35;
                    Point a = new Point(x, y);
                    btn.Location = a;
                    if (y <= 520)
                        y += 40;
                    else
                    {
                        y = 320;
                    }
                    soloai++;
                    btn.Click += new EventHandler(btn_click);
                    this.Controls.Add(btn);
                }
            }
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button t = (Button)sender;
            this.sACHTableAdapter.FillBy_TimsachtheomaLoai(this.ql_Sach.SACH, t.Name);
        }
        string mahd;
        private void frm_MuaHang_Load(object sender, EventArgs e)
        {
            tl = new TheLoaiBLL();
            taobuttonloai();
            lbl_thungan.Text = mh.nv.HOTEN;
            mh.hd.MAHD = random();
            mahd = mh.hd.MAHD;
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            this.sACHTableAdapter.FillBy_timsach(this.ql_Sach.SACH, txt_timSH.Text);
        }
        string random()
        {
            string ma = "HD";
            Random autoRand = new Random();
            for (int x = 0; x < 2; x++)
            {
                ma += autoRand.Next(1, 99).ToString();
            }
            return ma;
        }

        private void dgv_mua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void btn_xoaall_Click(object sender, EventArgs e)
        {
            mh.dscthd.RemoveAll(t => t.MaHD == mh.hd.MAHD);
            dgv_mua.DataSource = null;
            dgv_mua.DataSource = mh.dscthd;
        }
         void reset()
        {
            lbl_Tongtien.Text = "";
            lbl_kh.Text = "";
            mh.kh = new KhachHang();
            mh.dscthd = new List<HoaDon_Sach>();
            lbl_Tongtien.Text = "";
            dgv_mua.DataSource = null;

        }
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            frmThanhToan_Login new_from = new frmThanhToan_Login(mh);
            new_from.Owner = this;
            new_from.ShowDialog();
            reset();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(dgv_mua[2, dong].Value.ToString()) >= 1)
                {
                    mh.dscthd.FirstOrDefault(t => t.MaSH == dgv_mua[0, dong].Value.ToString() && t.MaHD == mahd).SlBan -= 1;
                    decimal thanhtien = mh.dscthd.FirstOrDefault(t => t.MaSH == dgv_mua[0, dong].Value.ToString() && t.MaHD == mahd).SlBan * decimal.Parse(dgv_sach[2, b].Value.ToString());
                    mh.dscthd.FirstOrDefault(t => t.MaSH == dgv_mua[0, dong].Value.ToString() && t.MaHD == mahd).DonGiaBan = thanhtien;
                }
                else
                {
                    mh.dscthd.RemoveAll(t => t.MaSH == dgv_mua[0, dong].Value.ToString() && t.MaHD == mahd);
                }
                dgv_mua.DataSource = null;
                dgv_mua.DataSource = mh.dscthd;
            }
            catch
            {
                return;
            }
            
        }
        int b=0;
        private void dgv_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               b = e.RowIndex;

                if (String.Compare(lbl_kh.Text, "__", true) != 0 && String.Compare(lbl_thungan.Text, "__", true) != 0)
                {
                    mh.hd.MaKH = mh.kh.MAKH;
                    mh.hd.MaNV = mh.nv.MANV;
                }
                HoaDon_Sach hds = new HoaDon_Sach();
                hds.MaHD = mh.hd.MAHD;
                hds.MaSH = dgv_sach[0, b].Value.ToString();
                hds.SlBan = 1;
                HoaDon_Sach x = mh.dscthd.FirstOrDefault(t => t.MaSH == hds.MaSH && t.MaHD == mahd);
                if (x == null)
                {
                    mh.dscthd.Add(hds);
                }
                else
                {
                    mh.dscthd.FirstOrDefault(t => t.MaSH == hds.MaSH && t.MaHD == mahd).SlBan += 1;
                }
                decimal thanhtien = mh.dscthd.FirstOrDefault(t => t.MaSH == hds.MaSH && t.MaHD ==mahd ).SlBan * decimal.Parse(dgv_sach[2, b].Value.ToString());
                mh.dscthd.FirstOrDefault(t => t.MaSH == hds.MaSH && t.MaHD == mahd).DonGiaBan = thanhtien;
                dgv_mua.DataSource = null;
                dgv_mua.DataSource = mh.dscthd;
                lbl_Tongtien.Text = mh.dscthd.Where(r=>r.MaHD == mahd).Sum(t => t.SlBan * t.DonGiaBan  ).ToString();

            }
            catch
            {
                MessageBox.Show("Lỗi 44873:");
            }
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            frm_NhapKhachHang new_form = new frm_NhapKhachHang();
            new_form.ShowDialog();
            mh.kh = new_form.thongtinkh();
            this.frm_MuaHang_Shown(sender, e);
        }
        private void frm_MuaHang_Shown(object sender, EventArgs e)
        {
            try
            {
                lbl_kh.Text = mh.kh.TENKH;
            }
            catch
            {
                lbl_kh.Text = "__";
                return;
            }
        }

      
    }
}
