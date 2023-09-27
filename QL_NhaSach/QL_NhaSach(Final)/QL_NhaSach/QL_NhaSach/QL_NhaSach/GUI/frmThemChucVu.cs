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
    public partial class frmThemChucVu : Form
    {
        ChucVuBLL cv = new ChucVuBLL();
        public frmThemChucVu()
        {
            InitializeComponent();
        }
        private void frmThemChucVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
        private void frmThemChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_Sach.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.ql_Sach.CHUCVU);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    this.cHUCVUBindingSource.EndEdit();
                    cHUCVUTableAdapter.Update(ql_Sach.CHUCVU);
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        //ChucVu gandulieu()
        //{
        //    ChucVu a = new ChucVu();
        //    a.MaCV = txt_MaCV.Text;
        //    a.TenCV = txt_TenCV.Text;
        //    return a;
        //}
        //private void ptb_Them_Click(object sender, EventArgs e)
        //{
        //    bool kq = cv.Insert(gandulieu());
        //    if (kq)
        //    {
        //        MessageBox.Show("Thêm thành công", "Thông Báo");
        //        ptb_Cancel_Click(sender, e);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Chức vụ hoặc tên tài khoản đã tồn tại. Bạn nên điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
        //    }
        //}

       

        //private void ptb_Cancel_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    frmThemNhanVien new_form = new frmThemNhanVien();
        //    new_form.Show();
        //}

        //private void ptp_remove_Click(object sender, EventArgs e)
        //{
        //    bool kq = cv.Delete(gandulieu());
        //    if (kq)
        //    {
        //        MessageBox.Show("Xóa thành công", "Thông Báo");
        //        ptb_Cancel_Click(sender, e);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Chức vụ hoặc tên tài khoản đã tồn tại. Bạn nên điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
        //    }
        //}

    }
}
