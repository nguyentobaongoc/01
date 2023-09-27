namespace QL_NhaSach
{
    partial class frm_ChiTietPhieuNhap
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
            this.cHITIETPHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ql_Sach = new QL_NhaSach.DAL.ql_Sach();
            this.dONGIANHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGNHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mAPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cHITIETPHIEUNHAPTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.CHITIETPHIEUNHAPTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptb_LoadSach = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbo_Masach = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_PhieuNhap = new System.Windows.Forms.ComboBox();
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tHELOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHELOAITableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.THELOAITableAdapter();
            this.nHAXUATBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHAXUATBANTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.NHAXUATBANTableAdapter();
            this.sACHTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.SACHTableAdapter();
            this.pHIEUNHAPTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.PHIEUNHAPTableAdapter();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETPHIEUNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_LoadSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAXUATBANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cHITIETPHIEUNHAPBindingSource
            // 
            this.cHITIETPHIEUNHAPBindingSource.DataMember = "CHITIETPHIEUNHAP";
            this.cHITIETPHIEUNHAPBindingSource.DataSource = this.ql_Sach;
            // 
            // ql_Sach
            // 
            this.ql_Sach.DataSetName = "ql_Sach";
            this.ql_Sach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dONGIANHAPDataGridViewTextBoxColumn
            // 
            this.dONGIANHAPDataGridViewTextBoxColumn.DataPropertyName = "DONGIANHAP";
            this.dONGIANHAPDataGridViewTextBoxColumn.HeaderText = "Đơn giá nhập";
            this.dONGIANHAPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dONGIANHAPDataGridViewTextBoxColumn.Name = "dONGIANHAPDataGridViewTextBoxColumn";
            // 
            // sOLUONGNHAPDataGridViewTextBoxColumn
            // 
            this.sOLUONGNHAPDataGridViewTextBoxColumn.DataPropertyName = "SOLUONGNHAP";
            this.sOLUONGNHAPDataGridViewTextBoxColumn.HeaderText = "Số lượng nhập";
            this.sOLUONGNHAPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sOLUONGNHAPDataGridViewTextBoxColumn.Name = "sOLUONGNHAPDataGridViewTextBoxColumn";
            // 
            // txt_SL
            // 
            this.txt_SL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHITIETPHIEUNHAPBindingSource, "SOLUONGNHAP", true));
            this.txt_SL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SL.Location = new System.Drawing.Point(594, 43);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(219, 28);
            this.txt_SL.TabIndex = 3;
            this.txt_SL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SL_KeyPress);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHITIETPHIEUNHAPBindingSource, "DONGIANHAP", true));
            this.txt_DonGia.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DonGia.Location = new System.Drawing.Point(594, 97);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(219, 28);
            this.txt_DonGia.TabIndex = 4;
            this.txt_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonGia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(458, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá nhập:";
            // 
            // mAPNDataGridViewTextBoxColumn
            // 
            this.mAPNDataGridViewTextBoxColumn.DataPropertyName = "MAPN";
            this.mAPNDataGridViewTextBoxColumn.HeaderText = "Mã phiếu nhập";
            this.mAPNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mAPNDataGridViewTextBoxColumn.Name = "mAPNDataGridViewTextBoxColumn";
            // 
            // mASACHDataGridViewTextBoxColumn
            // 
            this.mASACHDataGridViewTextBoxColumn.DataPropertyName = "MASACH";
            this.mASACHDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            this.mASACHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mASACHDataGridViewTextBoxColumn.Name = "mASACHDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASACHDataGridViewTextBoxColumn,
            this.mAPNDataGridViewTextBoxColumn,
            this.sOLUONGNHAPDataGridViewTextBoxColumn,
            this.dONGIANHAPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cHITIETPHIEUNHAPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(814, 285);
            this.dataGridView1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(458, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sách:";
            // 
            // cHITIETPHIEUNHAPTableAdapter
            // 
            this.cHITIETPHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.ptb_LoadSach);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbo_Masach);
            this.groupBox1.Controls.Add(this.cbo_PhieuNhap);
            this.groupBox1.Controls.Add(this.txt_SL);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(839, 183);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Phiếu Nhập";
            // 
            // ptb_LoadSach
            // 
            this.ptb_LoadSach.Image = global::QL_NhaSach.Properties.Resources.sync1;
            this.ptb_LoadSach.Location = new System.Drawing.Point(407, 91);
            this.ptb_LoadSach.Name = "ptb_LoadSach";
            this.ptb_LoadSach.Size = new System.Drawing.Size(30, 29);
            this.ptb_LoadSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_LoadSach.TabIndex = 39;
            this.ptb_LoadSach.TabStop = false;
            this.ptb_LoadSach.Click += new System.EventHandler(this.ptb_LoadSach_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(159, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "Tạo sách mới";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbo_Masach
            // 
            this.cbo_Masach.DataSource = this.sACHBindingSource;
            this.cbo_Masach.DisplayMember = "TENSACH";
            this.cbo_Masach.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_Masach.FormattingEnabled = true;
            this.cbo_Masach.Location = new System.Drawing.Point(159, 91);
            this.cbo_Masach.Name = "cbo_Masach";
            this.cbo_Masach.Size = new System.Drawing.Size(242, 29);
            this.cbo_Masach.TabIndex = 2;
            this.cbo_Masach.ValueMember = "MASACH";
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.ql_Sach;
            // 
            // cbo_PhieuNhap
            // 
            this.cbo_PhieuNhap.DataSource = this.pHIEUNHAPBindingSource;
            this.cbo_PhieuNhap.DisplayMember = "TENPN";
            this.cbo_PhieuNhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_PhieuNhap.FormattingEnabled = true;
            this.cbo_PhieuNhap.Location = new System.Drawing.Point(159, 38);
            this.cbo_PhieuNhap.Name = "cbo_PhieuNhap";
            this.cbo_PhieuNhap.Size = new System.Drawing.Size(242, 29);
            this.cbo_PhieuNhap.TabIndex = 1;
            this.cbo_PhieuNhap.ValueMember = "MAPN";
            this.cbo_PhieuNhap.SelectedIndexChanged += new System.EventHandler(this.cbo_PhieuNhap_SelectedIndexChanged);
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            this.pHIEUNHAPBindingSource.DataSource = this.ql_Sach;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 223);
            this.panel1.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(22, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(839, 339);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
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
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // pHIEUNHAPTableAdapter
            // 
            this.pHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.Location = new System.Drawing.Point(605, 606);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(109, 31);
            this.btn_them.TabIndex = 70;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.BackColor = System.Drawing.Color.White;
            this.btn_HoanTat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_HoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_HoanTat.Location = new System.Drawing.Point(736, 606);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(109, 31);
            this.btn_HoanTat.TabIndex = 69;
            this.btn_HoanTat.Text = "Hoàn tất";
            this.btn_HoanTat.UseVisualStyleBackColor = false;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // frm_ChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 651);
            this.Controls.Add(this.btn_HoanTat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_ChiTietPhieuNhap";
            this.Text = "Cập nhật phiếu nhập";
            this.Load += new System.EventHandler(this.frm_ChiTietPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETPHIEUNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_LoadSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAXUATBANBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cHITIETPHIEUNHAPBindingSource;
        private DAL.ql_Sach ql_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIANHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGNHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DAL.ql_SachTableAdapters.CHITIETPHIEUNHAPTableAdapter cHITIETPHIEUNHAPTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource tHELOAIBindingSource;
        private DAL.ql_SachTableAdapters.THELOAITableAdapter tHELOAITableAdapter;
        private System.Windows.Forms.BindingSource nHAXUATBANBindingSource;
        private DAL.ql_SachTableAdapters.NHAXUATBANTableAdapter nHAXUATBANTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbo_Masach;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private DAL.ql_SachTableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.PictureBox ptb_LoadSach;
        private System.Windows.Forms.ComboBox cbo_PhieuNhap;
        private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
        private DAL.ql_SachTableAdapters.PHIEUNHAPTableAdapter pHIEUNHAPTableAdapter;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_HoanTat;
    }
}