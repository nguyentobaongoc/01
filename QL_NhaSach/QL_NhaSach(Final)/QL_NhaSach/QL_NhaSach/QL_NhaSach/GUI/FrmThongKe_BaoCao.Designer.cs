namespace QL_NhaSach
{
    partial class FrmThongKe_BaoCao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_NguoiThuThi = new System.Windows.Forms.Label();
            this.ptb_Logo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tongTien = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_Tuan = new System.Windows.Forms.RadioButton();
            this.rdo_thang = new System.Windows.Forms.RadioButton();
            this.dgv_BaoCao = new System.Windows.Forms.DataGridView();
            this.mASACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ql_Sach = new QL_NhaSach.DAL.ql_Sach();
            this.rdo_Ngay = new System.Windows.Forms.RadioButton();
            this.Mon_menuStrip = new System.Windows.Forms.MenuStrip();
            this.In_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sACHTableAdapter = new QL_NhaSach.DAL.ql_SachTableAdapters.SACHTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).BeginInit();
            this.Mon_menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 60;
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
            this.groupBox1.Location = new System.Drawing.Point(29, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 161);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_Tuan);
            this.groupBox2.Controls.Add(this.rdo_thang);
            this.groupBox2.Controls.Add(this.dgv_BaoCao);
            this.groupBox2.Controls.Add(this.rdo_Ngay);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(19, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1246, 726);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê doanh thu";
            // 
            // rdo_Tuan
            // 
            this.rdo_Tuan.AutoSize = true;
            this.rdo_Tuan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_Tuan.Location = new System.Drawing.Point(171, 37);
            this.rdo_Tuan.Name = "rdo_Tuan";
            this.rdo_Tuan.Size = new System.Drawing.Size(63, 22);
            this.rdo_Tuan.TabIndex = 59;
            this.rdo_Tuan.TabStop = true;
            this.rdo_Tuan.Text = "Tuần";
            this.rdo_Tuan.UseVisualStyleBackColor = true;
            this.rdo_Tuan.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdo_thang
            // 
            this.rdo_thang.AutoSize = true;
            this.rdo_thang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_thang.Location = new System.Drawing.Point(324, 37);
            this.rdo_thang.Name = "rdo_thang";
            this.rdo_thang.Size = new System.Drawing.Size(71, 22);
            this.rdo_thang.TabIndex = 59;
            this.rdo_thang.TabStop = true;
            this.rdo_thang.Text = "Tháng";
            this.rdo_thang.UseVisualStyleBackColor = true;
            this.rdo_thang.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            this.tENSACHDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.SOluong});
            this.dgv_BaoCao.DataSource = this.sACHBindingSource;
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
            // tENSACHDataGridViewTextBoxColumn
            // 
            this.tENSACHDataGridViewTextBoxColumn.DataPropertyName = "TENSACH";
            this.tENSACHDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            this.tENSACHDataGridViewTextBoxColumn.Name = "tENSACHDataGridViewTextBoxColumn";
            this.tENSACHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "Giá bán";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            this.dONGIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SOluong
            // 
            this.SOluong.DataPropertyName = "SoLuong";
            this.SOluong.HeaderText = "Số lượng";
            this.SOluong.Name = "SOluong";
            this.SOluong.ReadOnly = true;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.ql_Sach;
            // 
            // ql_Sach
            // 
            this.ql_Sach.DataSetName = "ql_Sach";
            this.ql_Sach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdo_Ngay
            // 
            this.rdo_Ngay.AutoSize = true;
            this.rdo_Ngay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_Ngay.Location = new System.Drawing.Point(21, 37);
            this.rdo_Ngay.Name = "rdo_Ngay";
            this.rdo_Ngay.Size = new System.Drawing.Size(63, 22);
            this.rdo_Ngay.TabIndex = 59;
            this.rdo_Ngay.TabStop = true;
            this.rdo_Ngay.Text = "Ngày";
            this.rdo_Ngay.UseVisualStyleBackColor = true;
            this.rdo_Ngay.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.Mon_menuStrip.Size = new System.Drawing.Size(1306, 29);
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
            this.Tai_toolStripMenuItem.Click += new System.EventHandler(this.Tai_toolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Mon_menuStrip);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(276, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 787);
            this.panel2.TabIndex = 62;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // FrmThongKe_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1582, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmThongKe_BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê báo cáo";
            this.Load += new System.EventHandler(this.FrmThongKe_BaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_Sach)).EndInit();
            this.Mon_menuStrip.ResumeLayout(false);
            this.Mon_menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox ptb_Logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_soluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tongTien;
        private System.Windows.Forms.ToolStripMenuItem In_toolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_Tuan;
        private System.Windows.Forms.RadioButton rdo_thang;
        private System.Windows.Forms.DataGridView dgv_BaoCao;
        private System.Windows.Forms.RadioButton rdo_Ngay;
        private System.Windows.Forms.MenuStrip Mon_menuStrip;
        private System.Windows.Forms.Panel panel2;
        private DAL.ql_Sach ql_Sach;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private DAL.ql_SachTableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOluong;
        private System.Windows.Forms.Label lbl_NguoiThuThi;


    }
}