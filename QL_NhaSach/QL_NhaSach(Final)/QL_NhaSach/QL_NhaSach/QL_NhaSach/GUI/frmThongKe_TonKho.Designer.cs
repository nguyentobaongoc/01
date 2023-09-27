namespace QL_NhaSach
{
    partial class frmThongKe_TonKho
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
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.In_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mon_menuStrip = new System.Windows.Forms.MenuStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Tonkho = new System.Windows.Forms.DataGridView();
            this.ql_Sach = new QL_NhaSach.DAL.ql_Sach();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tongTien = new System.Windows.Forms.Label();
            this.ptb_Logo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_NguoiThuThi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ql_Sach1 = new QL_NhaSach.DAL.ql_Sach();
            this.cHITIETPHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETPHIEUNHAPTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.CHITIETPHIEUNHAPTableAdapter();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mon_menuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tonkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETPHIEUNHAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tai_toolStripMenuItem
            // 
            this.Tai_toolStripMenuItem.Image = global::QL_NhaSach.Properties.Resources.sync1;
            this.Tai_toolStripMenuItem.Name = "Tai_toolStripMenuItem";
            this.Tai_toolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.Tai_toolStripMenuItem.Text = "Tải lại";
            this.Tai_toolStripMenuItem.Click += new System.EventHandler(this.Tai_toolStripMenuItem_Click);
            // 
            // In_toolStripMenuItem
            // 
            this.In_toolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.In_toolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.In_toolStripMenuItem.Image = global::QL_NhaSach.Properties.Resources.printing;
            this.In_toolStripMenuItem.Name = "In_toolStripMenuItem";
            this.In_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.In_toolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.In_toolStripMenuItem.Text = "In";
            this.In_toolStripMenuItem.Click += new System.EventHandler(this.In_toolStripMenuItem_Click);
            // 
            // Mon_menuStrip
            // 
            this.Mon_menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.Mon_menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mon_menuStrip.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Mon_menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Mon_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mon_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.In_toolStripMenuItem,
            this.Tai_toolStripMenuItem});
            this.Mon_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Mon_menuStrip.Name = "Mon_menuStrip";
            this.Mon_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Mon_menuStrip.Size = new System.Drawing.Size(1247, 29);
            this.Mon_menuStrip.TabIndex = 61;
            this.Mon_menuStrip.Text = "MenuMon";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Tonkho);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(15, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1192, 726);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê tồn kho";
            // 
            // dgv_Tonkho
            // 
            this.dgv_Tonkho.AllowUserToAddRows = false;
            this.dgv_Tonkho.AllowUserToDeleteRows = false;
            this.dgv_Tonkho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tonkho.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Tonkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tonkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.dongia,
            this.dataGridViewTextBoxColumn3});
            this.dgv_Tonkho.Location = new System.Drawing.Point(15, 27);
            this.dgv_Tonkho.Name = "dgv_Tonkho";
            this.dgv_Tonkho.ReadOnly = true;
            this.dgv_Tonkho.RowTemplate.Height = 24;
            this.dgv_Tonkho.Size = new System.Drawing.Size(1158, 681);
            this.dgv_Tonkho.TabIndex = 65;
            // 
            // ql_Sach
            // 
            this.ql_Sach.DataSetName = "ql_Sach";
            this.ql_Sach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soluong.ForeColor = System.Drawing.Color.Black;
            this.lbl_soluong.Location = new System.Drawing.Point(134, 46);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(24, 18);
            this.lbl_soluong.TabIndex = 64;
            this.lbl_soluong.Text = "__";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Tổng tiền:";
            // 
            // lbl_tongTien
            // 
            this.lbl_tongTien.AutoSize = true;
            this.lbl_tongTien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tongTien.ForeColor = System.Drawing.Color.Black;
            this.lbl_tongTien.Location = new System.Drawing.Point(134, 88);
            this.lbl_tongTien.Name = "lbl_tongTien";
            this.lbl_tongTien.Size = new System.Drawing.Size(24, 18);
            this.lbl_tongTien.TabIndex = 62;
            this.lbl_tongTien.Text = "__";
            // 
            // ptb_Logo
            // 
            this.ptb_Logo.Image = global::QL_NhaSach.Properties.Resources.Logo___;
            this.ptb_Logo.Location = new System.Drawing.Point(42, 26);
            this.ptb_Logo.Name = "ptb_Logo";
            this.ptb_Logo.Size = new System.Drawing.Size(192, 157);
            this.ptb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Logo.TabIndex = 2;
            this.ptb_Logo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_soluong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_tongTien);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(29, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 161);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_NguoiThuThi);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(29, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 73);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Người thực thi";
            // 
            // lbl_NguoiThuThi
            // 
            this.lbl_NguoiThuThi.AutoSize = true;
            this.lbl_NguoiThuThi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NguoiThuThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_NguoiThuThi.Location = new System.Drawing.Point(17, 42);
            this.lbl_NguoiThuThi.Name = "lbl_NguoiThuThi";
            this.lbl_NguoiThuThi.Size = new System.Drawing.Size(28, 18);
            this.lbl_NguoiThuThi.TabIndex = 6;
            this.lbl_NguoiThuThi.Text = "__";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.ptb_Logo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 787);
            this.panel1.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Mon_menuStrip);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 787);
            this.panel2.TabIndex = 64;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ql_Sach1
            // 
            this.ql_Sach1.DataSetName = "ql_Sach";
            this.ql_Sach1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHITIETPHIEUNHAPBindingSource
            // 
            this.cHITIETPHIEUNHAPBindingSource.DataMember = "CHITIETPHIEUNHAP";
            this.cHITIETPHIEUNHAPBindingSource.DataSource = this.ql_Sach1;
            // 
            // cHITIETPHIEUNHAPTableAdapter
            // 
            this.cHITIETPHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "MASACH";
            this.masach.HeaderText = "Mã sách";
            this.masach.Name = "masach";
            this.masach.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "DONGIA";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "soluong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // frmThongKe_TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmThongKe_TonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tồn kho";
            this.Load += new System.EventHandler(this.frmThongKe_TonKho_Load);
            this.Mon_menuStrip.ResumeLayout(false);
            this.Mon_menuStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tonkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETPHIEUNHAPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem In_toolStripMenuItem;
        private System.Windows.Forms.MenuStrip Mon_menuStrip;
        private DAL.ql_Sach ql_Sach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_soluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tongTien;
        private System.Windows.Forms.PictureBox ptb_Logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Tonkho;
        private System.Windows.Forms.Label lbl_NguoiThuThi;
        private DAL.ql_Sach ql_Sach1;
        private System.Windows.Forms.BindingSource cHITIETPHIEUNHAPBindingSource;
        private DAL.ql_SachTableAdapters.CHITIETPHIEUNHAPTableAdapter cHITIETPHIEUNHAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}