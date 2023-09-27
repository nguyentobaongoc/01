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
    public partial class frmXemChiTietPN : Form
    {
        string mapn;
        public frmXemChiTietPN()
        {
            InitializeComponent();
        }
        public frmXemChiTietPN(string ma)
        {
            InitializeComponent();
            this.mapn = ma;
        }
        private void frmXemChiTietPN_Load(object sender, EventArgs e)
        {
            this.pHIEUNHAPTableAdapter.Fill(ql_Sach.PHIEUNHAP);
            this.sACHTableAdapter.Fill(ql_Sach.SACH);
            this.cHITIETPHIEUNHAPTableAdapter.FillBy_TheoMa(this.ql_Sach.CHITIETPHIEUNHAP, mapn);
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
