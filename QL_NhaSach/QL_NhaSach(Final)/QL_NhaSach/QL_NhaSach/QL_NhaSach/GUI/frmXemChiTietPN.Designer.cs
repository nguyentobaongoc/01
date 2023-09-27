namespace QL_NhaSach
{
    partial class frmXemChiTietPN
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
            this.sACHTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.SACHTableAdapter();
            this.cHITIETPHIEUNHAPTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.CHITIETPHIEUNHAPTableAdapter();
            this.cHITIETPHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ql_Sach = new QL_NhaSach.DAL.ql_Sach();
            this.dONGIANHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGNHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nHACUNGCAPTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.NHACUNGCAPTableAdapter();
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.NHANVIENTableAdapter();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_Phieunhap = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_Sach = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pHIEUNHAPTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.PHIEUNHAPTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETPHIEUNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // cHITIETPHIEUNHAPTableAdapter
            // 
            this.cHITIETPHIEUNHAPTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASACHDataGridViewTextBoxColumn,
            this.mAPNDataGridViewTextBoxColumn,
            this.sOLUONGNHAPDataGridViewTextBoxColumn,
            this.dONGIANHAPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cHITIETPHIEUNHAPBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(480, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(587, 291);
            this.dataGridView1.TabIndex = 52;
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource.DataSource = this.ql_Sach;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.ql_Sach;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(28, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Đơn giá nhập:";
            // 
            // txt_SL
            // 
            this.txt_SL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHITIETPHIEUNHAPBindingSource, "SOLUONGNHAP", true));
            this.txt_SL.Location = new System.Drawing.Point(188, 118);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(223, 26);
            this.txt_SL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phiếu nhập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label8.Location = new System.Drawing.Point(28, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 44;
            this.label8.Text = "Sách:";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHITIETPHIEUNHAPBindingSource, "DONGIANHAP", true));
            this.txt_DonGia.Location = new System.Drawing.Point(188, 168);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(223, 26);
            this.txt_DonGia.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label7.Location = new System.Drawing.Point(28, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Số lượng nhập:";
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            this.pHIEUNHAPBindingSource.DataSource = this.ql_Sach;
            // 
            // cbo_Phieunhap
            // 
            this.cbo_Phieunhap.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.pHIEUNHAPBindingSource, "TENPN", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbo_Phieunhap.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cHITIETPHIEUNHAPBindingSource, "MAPN", true));
            this.cbo_Phieunhap.DataSource = this.pHIEUNHAPBindingSource;
            this.cbo_Phieunhap.DisplayMember = "TENPN";
            this.cbo_Phieunhap.FormattingEnabled = true;
            this.cbo_Phieunhap.Location = new System.Drawing.Point(188, 32);
            this.cbo_Phieunhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Phieunhap.Name = "cbo_Phieunhap";
            this.cbo_Phieunhap.Size = new System.Drawing.Size(223, 26);
            this.cbo_Phieunhap.TabIndex = 1;
            this.cbo_Phieunhap.ValueMember = "MAPN";
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.ql_Sach;
            // 
            // cbo_Sach
            // 
            this.cbo_Sach.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.sACHBindingSource, "TENSACH", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbo_Sach.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cHITIETPHIEUNHAPBindingSource, "MASACH", true));
            this.cbo_Sach.DataSource = this.sACHBindingSource;
            this.cbo_Sach.DisplayMember = "TENSACH";
            this.cbo_Sach.FormattingEnabled = true;
            this.cbo_Sach.Location = new System.Drawing.Point(188, 71);
            this.cbo_Sach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Sach.Name = "cbo_Sach";
            this.cbo_Sach.Size = new System.Drawing.Size(223, 26);
            this.cbo_Sach.TabIndex = 2;
            this.cbo_Sach.ValueMember = "MASACH";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbo_Sach);
            this.groupBox1.Controls.Add(this.cbo_Phieunhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_SL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 211);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PHIẾU NHẬP";
            // 
            // pHIEUNHAPTableAdapter
            // 
            this.pHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_HoanTat);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 291);
            this.panel1.TabIndex = 53;
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.BackColor = System.Drawing.Color.White;
            this.btn_HoanTat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_HoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_HoanTat.Location = new System.Drawing.Point(327, 236);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(109, 43);
            this.btn_HoanTat.TabIndex = 72;
            this.btn_HoanTat.Text = "Trở về";
            this.btn_HoanTat.UseVisualStyleBackColor = false;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // frmXemChiTietPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 291);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXemChiTietPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem chi tiết phiếu nhập";
            this.Load += new System.EventHandler(this.frmXemChiTietPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETPHIEUNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DAL.ql_SachTableAdapters.SACHTableAdapter sACHTableAdapter;
        private DAL.ql_SachTableAdapters.CHITIETPHIEUNHAPTableAdapter cHITIETPHIEUNHAPTableAdapter;
        private System.Windows.Forms.BindingSource cHITIETPHIEUNHAPBindingSource;
        private DAL.ql_Sach ql_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIANHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGNHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DAL.ql_SachTableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private DAL.ql_SachTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
        private System.Windows.Forms.ComboBox cbo_Phieunhap;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private System.Windows.Forms.ComboBox cbo_Sach;
        private System.Windows.Forms.GroupBox groupBox1;
        private DAL.ql_SachTableAdapters.PHIEUNHAPTableAdapter pHIEUNHAPTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_HoanTat;
    }
}