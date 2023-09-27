namespace QL_NhaSach.GUI
{
    partial class frmThemNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ql_Sach = new QL_NhaSach.DAL.ql_Sach();
            this.cHUCVUTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.CHUCVUTableAdapter();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb_TTNV = new System.Windows.Forms.GroupBox();
            this.ptb_LoadSach = new System.Windows.Forms.PictureBox();
            this.btn_ThemChucVu = new System.Windows.Forms.Button();
            this.txt_SoNhaDuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_ChucVu = new System.Windows.Forms.ComboBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxt_NgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).BeginInit();
            this.panel1.SuspendLayout();
            this.grb_TTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_LoadSach)).BeginInit();
            this.SuspendLayout();
            // 
            // cHUCVUBindingSource
            // 
            this.cHUCVUBindingSource.DataMember = "CHUCVU";
            this.cHUCVUBindingSource.DataSource = this.ql_Sach;
            // 
            // ql_Sach
            // 
            this.ql_Sach.DataSetName = "ql_Sach";
            this.ql_Sach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHUCVUTableAdapter
            // 
            this.cHUCVUTableAdapter.ClearBeforeFill = true;
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.BackColor = System.Drawing.Color.White;
            this.btn_HoanTat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_HoanTat.Location = new System.Drawing.Point(283, 546);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(109, 31);
            this.btn_HoanTat.TabIndex = 71;
            this.btn_HoanTat.Text = "Hoàn tất";
            this.btn_HoanTat.UseVisualStyleBackColor = false;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.Location = new System.Drawing.Point(152, 546);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(109, 31);
            this.btn_them.TabIndex = 72;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.grb_TTNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 529);
            this.panel1.TabIndex = 73;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grb_TTNV
            // 
            this.grb_TTNV.BackColor = System.Drawing.Color.Transparent;
            this.grb_TTNV.Controls.Add(this.ptb_LoadSach);
            this.grb_TTNV.Controls.Add(this.btn_ThemChucVu);
            this.grb_TTNV.Controls.Add(this.txt_SoNhaDuong);
            this.grb_TTNV.Controls.Add(this.label8);
            this.grb_TTNV.Controls.Add(this.cbo_ChucVu);
            this.grb_TTNV.Controls.Add(this.txt_MatKhau);
            this.grb_TTNV.Controls.Add(this.txt_TenTaiKhoan);
            this.grb_TTNV.Controls.Add(this.txt_MaNV);
            this.grb_TTNV.Controls.Add(this.txt_HoTen);
            this.grb_TTNV.Controls.Add(this.label4);
            this.grb_TTNV.Controls.Add(this.label6);
            this.grb_TTNV.Controls.Add(this.mtxt_NgaySinh);
            this.grb_TTNV.Controls.Add(this.label7);
            this.grb_TTNV.Controls.Add(this.label1);
            this.grb_TTNV.Controls.Add(this.txt_SDT);
            this.grb_TTNV.Controls.Add(this.label11);
            this.grb_TTNV.Controls.Add(this.label2);
            this.grb_TTNV.Controls.Add(this.label5);
            this.grb_TTNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_TTNV.Location = new System.Drawing.Point(27, 21);
            this.grb_TTNV.Name = "grb_TTNV";
            this.grb_TTNV.Size = new System.Drawing.Size(501, 494);
            this.grb_TTNV.TabIndex = 10;
            this.grb_TTNV.TabStop = false;
            this.grb_TTNV.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // ptb_LoadSach
            // 
            this.ptb_LoadSach.Image = global::QL_NhaSach.Properties.Resources.sync1;
            this.ptb_LoadSach.Location = new System.Drawing.Point(457, 29);
            this.ptb_LoadSach.Name = "ptb_LoadSach";
            this.ptb_LoadSach.Size = new System.Drawing.Size(30, 29);
            this.ptb_LoadSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_LoadSach.TabIndex = 40;
            this.ptb_LoadSach.TabStop = false;
            this.ptb_LoadSach.Click += new System.EventHandler(this.ptb_LoadSach_Click);
            // 
            // btn_ThemChucVu
            // 
            this.btn_ThemChucVu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemChucVu.Location = new System.Drawing.Point(283, 79);
            this.btn_ThemChucVu.Name = "btn_ThemChucVu";
            this.btn_ThemChucVu.Size = new System.Drawing.Size(168, 36);
            this.btn_ThemChucVu.TabIndex = 11;
            this.btn_ThemChucVu.Text = "Cập nhật chức vụ";
            this.btn_ThemChucVu.UseVisualStyleBackColor = true;
            this.btn_ThemChucVu.Click += new System.EventHandler(this.btn_ThemChucVu_Click);
            // 
            // txt_SoNhaDuong
            // 
            this.txt_SoNhaDuong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoNhaDuong.Location = new System.Drawing.Point(192, 444);
            this.txt_SoNhaDuong.Name = "txt_SoNhaDuong";
            this.txt_SoNhaDuong.Size = new System.Drawing.Size(259, 28);
            this.txt_SoNhaDuong.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(25, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Địa chỉ:";
            // 
            // cbo_ChucVu
            // 
            this.cbo_ChucVu.DataSource = this.cHUCVUBindingSource;
            this.cbo_ChucVu.DisplayMember = "TENCV";
            this.cbo_ChucVu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_ChucVu.FormattingEnabled = true;
            this.cbo_ChucVu.Location = new System.Drawing.Point(192, 27);
            this.cbo_ChucVu.Name = "cbo_ChucVu";
            this.cbo_ChucVu.Size = new System.Drawing.Size(259, 29);
            this.cbo_ChucVu.TabIndex = 1;
            this.cbo_ChucVu.ValueMember = "MACV";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MatKhau.Location = new System.Drawing.Point(192, 189);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(259, 28);
            this.txt_MatKhau.TabIndex = 3;
            // 
            // txt_TenTaiKhoan
            // 
            this.txt_TenTaiKhoan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenTaiKhoan.Location = new System.Drawing.Point(192, 138);
            this.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            this.txt_TenTaiKhoan.Size = new System.Drawing.Size(259, 28);
            this.txt_TenTaiKhoan.TabIndex = 2;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaNV.Location = new System.Drawing.Point(192, 240);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(259, 28);
            this.txt_MaNV.TabIndex = 4;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_HoTen.Location = new System.Drawing.Point(192, 291);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(259, 28);
            this.txt_HoTen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(25, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ và tên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(25, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh:";
            // 
            // mtxt_NgaySinh
            // 
            this.mtxt_NgaySinh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mtxt_NgaySinh.Location = new System.Drawing.Point(192, 393);
            this.mtxt_NgaySinh.Mask = "00/00/0000";
            this.mtxt_NgaySinh.Name = "mtxt_NgaySinh";
            this.mtxt_NgaySinh.Size = new System.Drawing.Size(259, 28);
            this.mtxt_NgaySinh.TabIndex = 7;
            this.mtxt_NgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(25, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "SĐT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(25, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SDT.Location = new System.Drawing.Point(192, 342);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(259, 28);
            this.txt_SDT.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(25, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Chức vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(25, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã NV:";
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_HoanTat);
            this.Controls.Add(this.btn_them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThemNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmThemNhanVien_Load);
            this.Shown += new System.EventHandler(this.frmThemNhanVien_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grb_TTNV.ResumeLayout(false);
            this.grb_TTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_LoadSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DAL.ql_Sach ql_Sach;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private DAL.ql_SachTableAdapters.CHUCVUTableAdapter cHUCVUTableAdapter;
        private System.Windows.Forms.Button btn_HoanTat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grb_TTNV;
        private System.Windows.Forms.Button btn_ThemChucVu;
        private System.Windows.Forms.TextBox txt_SoNhaDuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_ChucVu;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TenTaiKhoan;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxt_NgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ptb_LoadSach;
    }
}