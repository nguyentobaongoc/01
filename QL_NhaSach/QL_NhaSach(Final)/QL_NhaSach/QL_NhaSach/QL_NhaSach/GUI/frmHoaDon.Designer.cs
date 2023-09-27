namespace QL_NhaSach
{
    partial class frmHoaDon
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Mon_menuStrip = new System.Windows.Forms.MenuStrip();
            this.In_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_BaoCao = new System.Windows.Forms.DataGridView();
            this.mASACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIABANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOADONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ql_Sach = new QL_NhaSach.DAL.ql_Sach();
            this.lbl_NguoiThuThi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_Logo = new System.Windows.Forms.PictureBox();
            this.hOADON_SACHTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.HOADON_SACHTableAdapter();
            this.lbl_tong = new System.Windows.Forms.Label();
            this.lbl_Tongtien = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.Mon_menuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Mon_menuStrip);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(277, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1305, 787);
            this.panel2.TabIndex = 64;
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
            this.Mon_menuStrip.Size = new System.Drawing.Size(1305, 29);
            this.Mon_menuStrip.TabIndex = 61;
            this.Mon_menuStrip.Text = "MenuMon";
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
            // Tai_toolStripMenuItem
            // 
            this.Tai_toolStripMenuItem.Image = global::QL_NhaSach.Properties.Resources.sync1;
            this.Tai_toolStripMenuItem.Name = "Tai_toolStripMenuItem";
            this.Tai_toolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.Tai_toolStripMenuItem.Text = "Tải lại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Tim);
            this.groupBox2.Controls.Add(this.txt_mahd);
            this.groupBox2.Controls.Add(this.lbl_Tongtien);
            this.groupBox2.Controls.Add(this.lbl_tong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgv_BaoCao);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(19, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1246, 726);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(381, 31);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(91, 28);
            this.btn_Tim.TabIndex = 20;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(142, 31);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(212, 28);
            this.txt_mahd.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã hóa đơn";
            // 
            // dgv_BaoCao
            // 
            this.dgv_BaoCao.AllowUserToAddRows = false;
            this.dgv_BaoCao.AllowUserToDeleteRows = false;
            this.dgv_BaoCao.AutoGenerateColumns = false;
            this.dgv_BaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgv_BaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASACHDataGridViewTextBoxColumn,
            this.mAHDDataGridViewTextBoxColumn,
            this.sOLUONGBANDataGridViewTextBoxColumn,
            this.dONGIABANDataGridViewTextBoxColumn});
            this.dgv_BaoCao.DataSource = this.hOADONSACHBindingSource;
            this.dgv_BaoCao.Location = new System.Drawing.Point(20, 72);
            this.dgv_BaoCao.Name = "dgv_BaoCao";
            this.dgv_BaoCao.ReadOnly = true;
            this.dgv_BaoCao.RowTemplate.Height = 24;
            this.dgv_BaoCao.Size = new System.Drawing.Size(1203, 634);
            this.dgv_BaoCao.TabIndex = 16;
            // 
            // mASACHDataGridViewTextBoxColumn
            // 
            this.mASACHDataGridViewTextBoxColumn.DataPropertyName = "MASACH";
            this.mASACHDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            this.mASACHDataGridViewTextBoxColumn.Name = "mASACHDataGridViewTextBoxColumn";
            this.mASACHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mAHDDataGridViewTextBoxColumn
            // 
            this.mAHDDataGridViewTextBoxColumn.DataPropertyName = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.mAHDDataGridViewTextBoxColumn.Name = "mAHDDataGridViewTextBoxColumn";
            this.mAHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sOLUONGBANDataGridViewTextBoxColumn
            // 
            this.sOLUONGBANDataGridViewTextBoxColumn.DataPropertyName = "SOLUONGBAN";
            this.sOLUONGBANDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sOLUONGBANDataGridViewTextBoxColumn.Name = "sOLUONGBANDataGridViewTextBoxColumn";
            this.sOLUONGBANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dONGIABANDataGridViewTextBoxColumn
            // 
            this.dONGIABANDataGridViewTextBoxColumn.DataPropertyName = "DONGIABAN";
            this.dONGIABANDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dONGIABANDataGridViewTextBoxColumn.Name = "dONGIABANDataGridViewTextBoxColumn";
            this.dONGIABANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOADONSACHBindingSource
            // 
            this.hOADONSACHBindingSource.DataMember = "HOADON_SACH";
            this.hOADONSACHBindingSource.DataSource = this.ql_Sach;
            // 
            // ql_Sach
            // 
            this.ql_Sach.DataSetName = "ql_Sach";
            this.ql_Sach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_NguoiThuThi
            // 
            this.lbl_NguoiThuThi.AutoSize = true;
            this.lbl_NguoiThuThi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NguoiThuThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_NguoiThuThi.Location = new System.Drawing.Point(17, 42);
            this.lbl_NguoiThuThi.Name = "lbl_NguoiThuThi";
            this.lbl_NguoiThuThi.Size = new System.Drawing.Size(28, 18);
            this.lbl_NguoiThuThi.TabIndex = 7;
            this.lbl_NguoiThuThi.Text = "__";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_NguoiThuThi);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(29, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 77);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Người thực thi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.ptb_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 787);
            this.panel1.TabIndex = 63;
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
            // hOADON_SACHTableAdapter
            // 
            this.hOADON_SACHTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_tong
            // 
            this.lbl_tong.AutoSize = true;
            this.lbl_tong.Location = new System.Drawing.Point(836, 35);
            this.lbl_tong.Name = "lbl_tong";
            this.lbl_tong.Size = new System.Drawing.Size(86, 21);
            this.lbl_tong.TabIndex = 17;
            this.lbl_tong.Text = "Tổng tiền:";
            this.lbl_tong.Visible = false;
            // 
            // lbl_Tongtien
            // 
            this.lbl_Tongtien.AutoSize = true;
            this.lbl_Tongtien.Location = new System.Drawing.Point(942, 35);
            this.lbl_Tongtien.Name = "lbl_Tongtien";
            this.lbl_Tongtien.Size = new System.Drawing.Size(28, 21);
            this.lbl_Tongtien.TabIndex = 17;
            this.lbl_Tongtien.Text = "__";
            this.lbl_Tongtien.Visible = false;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 787);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Mon_menuStrip.ResumeLayout(false);
            this.Mon_menuStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.PictureBox ptb_Logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip Mon_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem In_toolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_BaoCao;
        private DAL.ql_Sach ql_Sach;
        private System.Windows.Forms.Label lbl_NguoiThuThi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource hOADONSACHBindingSource;
        private DAL.ql_SachTableAdapters.HOADON_SACHTableAdapter hOADON_SACHTableAdapter;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIABANDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_Tongtien;
        private System.Windows.Forms.Label lbl_tong;
    }
}