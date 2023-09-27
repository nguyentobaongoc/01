using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaSach
{
    public partial class frm_ThemTheLoai : Form
    {
        public frm_ThemTheLoai()
        {
            InitializeComponent();
        }

        private void frm_ThemTheLoai_Load(object sender, EventArgs e)
        {
            this.Text = "Thể loại";
            // TODO: This line of code loads data into the 'ql_Sach.THELOAI' table. You can move, or remove it, as needed.
            this.tHELOAITableAdapter.Fill(this.ql_Sach.THELOAI);


        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    this.tHELOAIBindingSource.EndEdit();
                    this.tHELOAITableAdapter.Update(ql_Sach.THELOAI);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.tHELOAITableAdapter.Fill(this.ql_Sach.THELOAI);
        }
    }
}
