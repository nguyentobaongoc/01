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
    public partial class frmNCC : Form
    {
        public frmNCC()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_Sach.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.ql_Sach.NHACUNGCAP);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    this.nHACUNGCAPBindingSource.EndEdit();
                    this.nHACUNGCAPTableAdapter.Update(ql_Sach.NHACUNGCAP);
                    MessageBox.Show("Lưu thành công", "Thông báo");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.nHACUNGCAPTableAdapter.Fill(this.ql_Sach.NHACUNGCAP);
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
