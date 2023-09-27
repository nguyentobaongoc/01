namespace QL_NhaSach
{
    partial class frm_MuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MuaHang));
            this.sACHTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.SACHTableAdapter();
            this.lbl_kh = new System.Windows.Forms.Label();
            this.lbl_Tongtien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_thungan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.btn_nhap = new System.Windows.Forms.Button();
            this.btn_xoaall = new System.Windows.Forms.Button();
            this.txt_timSH = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ql_Sach = new QL_NhaSach.DAL.ql_Sach();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_mua = new System.Windows.Forms.DataGridView();
            this.tENSACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_sach = new System.Windows.Forms.DataGridView();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mua)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_kh
            // 
            this.lbl_kh.AutoSize = true;
            this.lbl_kh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_kh.ForeColor = System.Drawing.Color.Black;
            this.lbl_kh.Location = new System.Drawing.Point(196, 110);
            this.lbl_kh.Name = "lbl_kh";
            this.lbl_kh.Size = new System.Drawing.Size(28, 21);
            this.lbl_kh.TabIndex = 23;
            this.lbl_kh.Text = "__";
            // 
            // lbl_Tongtien
            // 
            this.lbl_Tongtien.AutoSize = true;
            this.lbl_Tongtien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Tongtien.ForeColor = System.Drawing.Color.Black;
            this.lbl_Tongtien.Location = new System.Drawing.Point(1434, 74);
            this.lbl_Tongtien.Name = "lbl_Tongtien";
            this.lbl_Tongtien.Size = new System.Drawing.Size(24, 18);
            this.lbl_Tongtien.TabIndex = 23;
            this.lbl_Tongtien.Text = "__";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1301, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "TỔNG TIỀN:";
            // 
            // lbl_thungan
            // 
            this.lbl_thungan.AutoSize = true;
            this.lbl_thungan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_thungan.ForeColor = System.Drawing.Color.Black;
            this.lbl_thungan.Location = new System.Drawing.Point(152, 50);
            this.lbl_thungan.Name = "lbl_thungan";
            this.lbl_thungan.Size = new System.Drawing.Size(28, 21);
            this.lbl_thungan.TabIndex = 23;
            this.lbl_thungan.Text = "__";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(29, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Thu ngân:";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.Location = new System.Drawing.Point(1305, 289);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(228, 53);
            this.btn_thanhtoan.TabIndex = 19;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // btn_nhap
            // 
            this.btn_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhap.Location = new System.Drawing.Point(1305, 115);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(228, 53);
            this.btn_nhap.TabIndex = 19;
            this.btn_nhap.Text = "Nhập thông tin khách hàng";
            this.btn_nhap.UseVisualStyleBackColor = true;
            this.btn_nhap.Click += new System.EventHandler(this.btn_nhap_Click);
            // 
            // btn_xoaall
            // 
            this.btn_xoaall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaall.Location = new System.Drawing.Point(1305, 231);
            this.btn_xoaall.Name = "btn_xoaall";
            this.btn_xoaall.Size = new System.Drawing.Size(228, 53);
            this.btn_xoaall.TabIndex = 19;
            this.btn_xoaall.Text = "Xóa tất cả";
            this.btn_xoaall.UseVisualStyleBackColor = true;
            this.btn_xoaall.Click += new System.EventHandler(this.btn_xoaall_Click);
            // 
            // txt_timSH
            // 
            this.txt_timSH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_timSH.Location = new System.Drawing.Point(104, 48);
            this.txt_timSH.Name = "txt_timSH";
            this.txt_timSH.Size = new System.Drawing.Size(205, 27);
            this.txt_timSH.TabIndex = 8;
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_tim.Location = new System.Drawing.Point(140, 108);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(101, 28);
            this.btn_tim.TabIndex = 9;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(13, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Từ Khóa";
            // 
            // ql_Sach
            // 
            this.ql_Sach.DataSetName = "ql_Sach";
            this.ql_Sach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.ql_Sach;
            // 
            // dgv_mua
            // 
            this.dgv_mua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mua.BackgroundColor = System.Drawing.Color.White;
            this.dgv_mua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mua.Location = new System.Drawing.Point(386, 35);
            this.dgv_mua.Name = "dgv_mua";
            this.dgv_mua.RowTemplate.Height = 24;
            this.dgv_mua.Size = new System.Drawing.Size(873, 313);
            this.dgv_mua.TabIndex = 7;
            this.dgv_mua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mua_CellClick);
            // 
            // tENSACHDataGridViewTextBoxColumn
            // 
            this.tENSACHDataGridViewTextBoxColumn.DataPropertyName = "TENSACH";
            this.tENSACHDataGridViewTextBoxColumn.HeaderText = "TENSACH";
            this.tENSACHDataGridViewTextBoxColumn.Name = "tENSACHDataGridViewTextBoxColumn";
            // 
            // mASACHDataGridViewTextBoxColumn
            // 
            this.mASACHDataGridViewTextBoxColumn.DataPropertyName = "MASACH";
            this.mASACHDataGridViewTextBoxColumn.HeaderText = "MASACH";
            this.mASACHDataGridViewTextBoxColumn.Name = "mASACHDataGridViewTextBoxColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_timSH);
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(16, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 185);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Sách";
            // 
            // dgv_sach
            // 
            this.dgv_sach.AutoGenerateColumns = false;
            this.dgv_sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sach.BackgroundColor = System.Drawing.Color.White;
            this.dgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASACHDataGridViewTextBoxColumn,
            this.tENSACHDataGridViewTextBoxColumn,
            this.DONGIA});
            this.dgv_sach.DataSource = this.sACHBindingSource;
            this.dgv_sach.Location = new System.Drawing.Point(483, 399);
            this.dgv_sach.Name = "dgv_sach";
            this.dgv_sach.RowTemplate.Height = 24;
            this.dgv_sach.Size = new System.Drawing.Size(1033, 361);
            this.dgv_sach.TabIndex = 12;
            this.dgv_sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sach_CellClick);
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "DONGIA";
            this.DONGIA.Name = "DONGIA";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbl_kh);
            this.panel1.Controls.Add(this.lbl_Tongtien);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_thungan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_thanhtoan);
            this.panel1.Controls.Add(this.btn_nhap);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_xoaall);
            this.panel1.Controls.Add(this.dgv_mua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1542, 374);
            this.panel1.TabIndex = 11;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(1305, 173);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(228, 53);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // frm_MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 787);
            this.Controls.Add(this.dgv_sach);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MuaHang";
            this.Load += new System.EventHandler(this.frm_MuaHang_Load);
            this.Shown += new System.EventHandler(this.frm_MuaHang_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DAL.ql_SachTableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.Label lbl_kh;
        private System.Windows.Forms.Label lbl_Tongtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_thungan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.Button btn_nhap;
        private System.Windows.Forms.Button btn_xoaall;
        private System.Windows.Forms.TextBox txt_timSH;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label label4;
        private DAL.ql_Sach ql_Sach;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private System.Windows.Forms.DataGridView dgv_mua;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Xoa;


    }
}