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
    public partial class frm_NXB : Form
    {
        public frm_NXB()
        {
            InitializeComponent();
        }

        private void frm_NXB_Load(object sender, EventArgs e)
        {
            this.Text = "Nhà xuất bản";
            // TODO: This line of code loads data into the 'ql_Sach.NHAXUATBAN' table. You can move, or remove it, as needed.
            this.nHAXUATBANTableAdapter.Fill(this.ql_Sach.NHAXUATBAN);

        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (this.Validate())
                {
                    this.nHAXUATBANBindingSource.EndEdit();
                    this.nHAXUATBANTableAdapter.Update(ql_Sach.NHAXUATBAN);
                    MessageBox.Show("Lưu thành công", "Thông báo");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.nHAXUATBANTableAdapter.Fill(this.ql_Sach.NHAXUATBAN);
        }
    }
}
