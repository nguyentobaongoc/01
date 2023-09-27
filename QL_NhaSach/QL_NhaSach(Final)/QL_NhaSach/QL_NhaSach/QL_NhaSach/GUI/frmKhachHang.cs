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
    public partial class frmKhachHang : Form
    {
       
        public frmKhachHang()
        {
            InitializeComponent();
        }
        NhanVien nv;
        public frmKhachHang(NhanVien i)
        {
            InitializeComponent();
            nv = i;
        }
        void phanquyen()
        {


            if (nv.PHANQUYEN == 2)
            {
               
                bindingNavigatorDeleteItem.Enabled = false;
                this.dgv_khachHang.ReadOnly = true;
            }
          
        }

       

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_Sach.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.ql_Sach.KHACHHANG);
            // TODO: This line of code loads data into the 'ql_Sach.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.ql_Sach.KHACHHANG);
            // TODO: This line of code loads data into the 'qL_Sach.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.ql_Sach.KHACHHANG);
            thongke();
            phanquyen();
            lbl_NguoiThuThi.Text = nv.HOTEN;
        }

        private void Luu_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                kHACHHANGBindingSource.EndEdit();
                kHACHHANGTableAdapter.Update(ql_Sach.KHACHHANG);
                MessageBox.Show("Lưu thành công", "Thông báo");
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
            toExcel(this.kHACHHANGTableAdapter.GetData());
            
        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.kHACHHANGTableAdapter.Fill(ql_Sach.KHACHHANG);
            thongke();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            this.kHACHHANGTableAdapter.FillBy_TimKiem(ql_Sach.KHACHHANG, toolStripTextBox1.Text);
        }
      

        
        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        void thongke()
        {
            lbl_TongKH.Text = dgv_khachHang.RowCount.ToString() ;
        }

        private void TimkiemtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.kHACHHANGTableAdapter.FillBy_TimKiem(ql_Sach.KHACHHANG, toolStripTextBox1.Text);
            toolStripTextBox1.Clear();
        }



 

    }
}
