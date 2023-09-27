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
     partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        NhanVien nv;
        public frmSach(NhanVien i)
        {
            InitializeComponent();
            nv = i;
        }
        void phanquyen()
        {
            if (nv.PHANQUYEN == 1)
            {
                bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
                this.dgv_Sach.ReadOnly = true;
                return;
            }
            if (nv.PHANQUYEN == 2)
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                dgv_Sach.ReadOnly = true;
            }
            
        }
        private void frmSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_Sach.NHAXUATBAN' table. You can move, or remove it, as needed.
            this.nHAXUATBANTableAdapter.Fill(this.ql_Sach.NHAXUATBAN);
            // TODO: This line of code loads data into the 'ql_Sach.THELOAI' table. You can move, or remove it, as needed.
            this.tHELOAITableAdapter.Fill(this.ql_Sach.THELOAI);
            // TODO: This line of code loads data into the 'ql_Sach.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.ql_Sach.SACH);
            thongke();
            phanquyen();
            lbl_NguoiThuThi.Text = nv.HOTEN;
        }
        void thongke()
        {
            lbl_TongNV.Text = dgv_Sach.RowCount.ToString();
        }

        private void ptb_Them_Click(object sender, EventArgs e)
        {
            frmNhapSach a = new frmNhapSach();
            a.Owner = this;
            a.Show();
        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.sACHTableAdapter.Fill(this.ql_Sach.SACH);
        }

        private void Luu_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    this.sACHBindingSource.EndEdit();
                    sACHTableAdapter.Update(ql_Sach.SACH);
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
            toExcel(this.sACHTableAdapter.GetData());
        }

        private void ptb_Them_Click_1(object sender, EventArgs e)
        {
            frmNhapSach a = new frmNhapSach();
            a.Owner = this;
            a.ShowDialog();
        }


    }
}
