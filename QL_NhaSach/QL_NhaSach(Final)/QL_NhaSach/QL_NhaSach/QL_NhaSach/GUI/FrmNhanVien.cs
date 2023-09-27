using QL_NhaSach.GUI;
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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        NhanVien nv;
        public FrmNhanVien(NhanVien i)
        {
            InitializeComponent();
            nv = i;
        }
        void phanquyen()
        {
            if (nv.PHANQUYEN == 2)
            {
                ptp_Them.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                this.dgv_NhanVien.ReadOnly = true;
            }
        }

        private void KhachHang_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhachHang khachHang = new frmKhachHang();
            khachHang.ShowDialog();
            this.Close();
        }

        public void FrmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_Sach.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.ql_Sach.NHANVIEN);
            phanquyen();
            lbl_NguoiThuThi.Text = nv.HOTEN;

        }


     

        private void Luu_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    nHANVIENBindingSource.EndEdit();
                    nHANVIENTableAdapter.Update(ql_Sach.NHANVIEN);
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        void  thongke()
        {
            lbl_TongNV.Text = dgv_NhanVien.RowCount.ToString();
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
            toExcel(this.nHANVIENTableAdapter.GetData());
        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.nHANVIENTableAdapter.Fill(this.ql_Sach.NHANVIEN);
        }

        private void TimkiemtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //this.nHANVIENTableAdapter.FillBy_TimKiem(ql_Sach.NHANVIEN, Text_toolStripTextBox.Text);
        }

        private void FrmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn thoát chứ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void FrmNhanVien_Shown(object sender, EventArgs e)
        {
            this.nHANVIENTableAdapter.Fill(this.ql_Sach.NHANVIEN);
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan new_Form = new frmTaiKhoan();
            this.Hide();
            new_Form.Show();
        }

        private void ThemNV_Click(object sender, EventArgs e)
        {
            frmThemNhanVien new_form = new frmThemNhanVien();
            new_form.Owner = this;
            new_form.ShowDialog();
        }


    

    }
}
