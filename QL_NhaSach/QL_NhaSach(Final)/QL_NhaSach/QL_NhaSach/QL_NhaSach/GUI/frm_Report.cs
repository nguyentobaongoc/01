using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NhaSach.GUI;
namespace QL_NhaSach
{
    public partial class frm_Report : Form
    {
        public frm_Report()
        {
            InitializeComponent();
        }
        string ma;
        public frm_Report(string mahd)
        {
            InitializeComponent();
            ma = mahd;
        }
        private void frm_Report_Load(object sender, EventArgs e)
        {
            InHoaDon rpt = new InHoaDon();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}
