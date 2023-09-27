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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_Sach.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.ql_Sach.PHIEUNHAP);

        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pHIEUNHAPTableAdapter.Fill(this.ql_Sach.PHIEUNHAP);
        }

        private void Luu_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    pHIEUNHAPBindingSource.EndEdit();
                    pHIEUNHAPTableAdapter.Update(ql_Sach.PHIEUNHAP);
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void toExcel(DataTable a, string excelFilePath = null)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;
            // Start Excel and get Application object.  
            excel = new Microsoft.Office.Interop.Excel.Application();
            // for making Excel visible  
            excel.Visible = false;
            excel.DisplayAlerts = false;
            // Creation a new Workbook  
            excelworkBook = excel.Workbooks.Add(Type.Missing);
            // Workk sheet  
            excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
            excelSheet.Name = "Test work sheet";
            excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[a.Rows.Count + 1, a.Columns.Count]];
            excelCellrange.EntireColumn.AutoFit();
            Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            border.Weight = 2d;
            int ColumnsCount = a.Columns.Count;
            object[] Header = new object[ColumnsCount];

            // column headings               
            for (int i = 0; i < ColumnsCount; i++)
                Header[i] = a.Columns[i].ColumnName;

            Microsoft.Office.Interop.Excel.Range HeaderRange = excelSheet.get_Range((Microsoft.Office.Interop.Excel.Range)(excelSheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(excelSheet.Cells[1, ColumnsCount]));
            HeaderRange.Value = Header;
            HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            HeaderRange.Font.Bold = true;
            // rows
            for (var i = 0; i < a.Rows.Count; i++)
            {
                // to do: format datetime values before printing
                for (var j = 0; j < a.Columns.Count; j++)
                {
                    excelSheet.Cells[i + 2, j + 1] = a.Rows[i][j];
                }
            }
            if (!string.IsNullOrEmpty(excelFilePath))
            {
                try
                {
                    excelSheet.SaveAs(excelFilePath);
                    excel.Quit();
                    MessageBox.Show("Excel file saved!");
                }
                catch (Exception ex)
                {
                    throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                        + ex.Message);
                }
            }
            else
            { // no file path is given
                excel.Visible = true;
            }
        }
        private void In_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            toExcel(this.pHIEUNHAPTableAdapter.GetData());
        }
        void thongke()
        {
            lbl_TongPN.Text = (dgv_PN.RowCount).ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ChiTietPhieuNhap a = new frm_ChiTietPhieuNhap();
            a.ShowDialog();

        }
        int dong = 0;
        private void dgv_PN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            frmXemChiTietPN new_form = new frmXemChiTietPN(dgv_PN[0, dong].Value.ToString());
            new_form.Owner = this;
            new_form.ShowDialog();
        }

        private void btn_NCC_Click(object sender, EventArgs e)
        {
            frmNCC frm = new frmNCC();
            frm.ShowDialog();
        }
    }
}
