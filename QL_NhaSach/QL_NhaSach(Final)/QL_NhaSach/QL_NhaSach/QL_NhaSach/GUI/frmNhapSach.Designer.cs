namespace QL_NhaSach
{
    partial class frmNhapSach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThemTL = new System.Windows.Forms.Button();
            this.btn_ThemNSX = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NamXuatBan = new System.Windows.Forms.TextBox();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.cbo_NXB = new System.Windows.Forms.ComboBox();
            this.cbo_TheLoai = new System.Windows.Forms.ComboBox();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaSH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.ql_Sach = new QL_NhaSach.DAL.ql_Sach();
            this.tHELOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHELOAITableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.THELOAITableAdapter();
            this.nHAXUATBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHAXUATBANTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.NHAXUATBANTableAdapter();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAXUATBANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_ThemTL);
            this.groupBox2.Controls.Add(this.btn_ThemNSX);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_NamXuatBan);
            this.groupBox2.Controls.Add(this.txt_Gia);
            this.groupBox2.Controls.Add(this.cbo_NXB);
            this.groupBox2.Controls.Add(this.cbo_TheLoai);
            this.groupBox2.Controls.Add(this.txt_tensach);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_MaSH);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(16, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 238);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(412, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Năm xuất bản:";
            // 
            // btn_ThemTL
            // 
            this.btn_ThemTL.BackColor = System.Drawing.Color.White;
            this.btn_ThemTL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThemTL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemTL.Location = new System.Drawing.Point(145, 69);
            this.btn_ThemTL.Name = "btn_ThemTL";
            this.btn_ThemTL.Size = new System.Drawing.Size(94, 31);
            this.btn_ThemTL.TabIndex = 68;
            this.btn_ThemTL.Text = "Thêm";
            this.btn_ThemTL.UseVisualStyleBackColor = false;
            this.btn_ThemTL.Click += new System.EventHandler(this.btn_ThemTL_Click);
            // 
            // btn_ThemNSX
            // 
            this.btn_ThemNSX.BackColor = System.Drawing.Color.White;
            this.btn_ThemNSX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThemNSX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemNSX.Location = new System.Drawing.Point(145, 188);
            this.btn_ThemNSX.Name = "btn_ThemNSX";
            this.btn_ThemNSX.Size = new System.Drawing.Size(95, 31);
            this.btn_ThemNSX.TabIndex = 68;
            this.btn_ThemNSX.Text = "Thêm";
            this.btn_ThemNSX.UseVisualStyleBackColor = false;
            this.btn_ThemNSX.Click += new System.EventHandler(this.btn_ThemNSX_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(425, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Giá bán:";
            // 
            // txt_NamXuatBan
            // 
            this.txt_NamXuatBan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NamXuatBan.Location = new System.Drawing.Point(533, 109);
            this.txt_NamXuatBan.Name = "txt_NamXuatBan";
            this.txt_NamXuatBan.Size = new System.Drawing.Size(219, 26);
            this.txt_NamXuatBan.TabIndex = 47;
            this.txt_NamXuatBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NamXuatBan_KeyPress);
            // 
            // txt_Gia
            // 
            this.txt_Gia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Gia.Location = new System.Drawing.Point(533, 160);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(219, 26);
            this.txt_Gia.TabIndex = 47;
            this.txt_Gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Gia_KeyPress);
            // 
            // cbo_NXB
            // 
            this.cbo_NXB.DataSource = this.nHAXUATBANBindingSource;
            this.cbo_NXB.DisplayMember = "TENNXB";
            this.cbo_NXB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_NXB.FormattingEnabled = true;
            this.cbo_NXB.Location = new System.Drawing.Point(144, 156);
            this.cbo_NXB.Name = "cbo_NXB";
            this.cbo_NXB.Size = new System.Drawing.Size(219, 26);
            this.cbo_NXB.TabIndex = 48;
            this.cbo_NXB.ValueMember = "MANXB";
            // 
            // cbo_TheLoai
            // 
            this.cbo_TheLoai.DataSource = this.tHELOAIBindingSource;
            this.cbo_TheLoai.DisplayMember = "TENTL";
            this.cbo_TheLoai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_TheLoai.FormattingEnabled = true;
            this.cbo_TheLoai.Location = new System.Drawing.Point(145, 37);
            this.cbo_TheLoai.Name = "cbo_TheLoai";
            this.cbo_TheLoai.Size = new System.Drawing.Size(219, 26);
            this.cbo_TheLoai.TabIndex = 49;
            this.cbo_TheLoai.ValueMember = "MATL";
            // 
            // txt_tensach
            // 
            this.txt_tensach.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tensach.Location = new System.Drawing.Point(538, 37);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(219, 26);
            this.txt_tensach.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(19, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Nhà sản xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(417, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tên Sách:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(21, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Thể loại:";
            // 
            // txt_MaSH
            // 
            this.txt_MaSH.Location = new System.Drawing.Point(145, 115);
            this.txt_MaSH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaSH.Name = "txt_MaSH";
            this.txt_MaSH.Size = new System.Drawing.Size(219, 26);
            this.txt_MaSH.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã Sách:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 271);
            this.panel1.TabIndex = 66;
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.BackColor = System.Drawing.Color.White;
            this.btn_HoanTat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_HoanTat.Location = new System.Drawing.Point(681, 289);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(109, 31);
            this.btn_HoanTat.TabIndex = 67;
            this.btn_HoanTat.Text = "Hoàn tất";
            this.btn_HoanTat.UseVisualStyleBackColor = false;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.Location = new System.Drawing.Point(549, 289);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(109, 31);
            this.btn_them.TabIndex = 68;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // ql_Sach
            // 
            this.ql_Sach.DataSetName = "ql_Sach";
            this.ql_Sach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHELOAIBindingSource
            // 
            this.tHELOAIBindingSource.DataMember = "THELOAI";
            this.tHELOAIBindingSource.DataSource = this.ql_Sach;
            // 
            // tHELOAITableAdapter
            // 
            this.tHELOAITableAdapter.ClearBeforeFill = true;
            // 
            // nHAXUATBANBindingSource
            // 
            this.nHAXUATBANBindingSource.DataMember = "NHAXUATBAN";
            this.nHAXUATBANBindingSource.DataSource = this.ql_Sach;
            // 
            // nHAXUATBANTableAdapter
            // 
            this.nHAXUATBANTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 338);
            this.Controls.Add(this.btn_HoanTat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhapSach";
            this.Load += new System.EventHandler(this.frmNhapSach_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAXUATBANBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_HoanTat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.ComboBox cbo_NXB;
        private System.Windows.Forms.ComboBox cbo_TheLoai;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MaSH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NamXuatBan;
        private System.Windows.Forms.Button btn_ThemTL;
        private System.Windows.Forms.Button btn_ThemNSX;
        private DAL.ql_Sach ql_Sach;
        private System.Windows.Forms.BindingSource tHELOAIBindingSource;
        private DAL.ql_SachTableAdapters.THELOAITableAdapter tHELOAITableAdapter;
        private System.Windows.Forms.BindingSource nHAXUATBANBindingSource;
        private DAL.ql_SachTableAdapters.NHAXUATBANTableAdapter nHAXUATBANTableAdapter;
    }
}