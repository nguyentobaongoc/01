namespace QL_NhaSach
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TenDangNhap = new System.Windows.Forms.Label();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.txt_Tendangnhap = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.ptb_DangNhap = new System.Windows.Forms.PictureBox();
            this.ptb_Logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ptb_Logo);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 346);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(544, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 86);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // lbl_TenDangNhap
            // 
            this.lbl_TenDangNhap.AutoSize = true;
            this.lbl_TenDangNhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(540, 144);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(121, 21);
            this.lbl_TenDangNhap.TabIndex = 5;
            this.lbl_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(583, 207);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(78, 21);
            this.lbl_MatKhau.TabIndex = 5;
            this.lbl_MatKhau.Text = "Mật khẩu";
            // 
            // txt_Tendangnhap
            // 
            this.txt_Tendangnhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Tendangnhap.Location = new System.Drawing.Point(691, 137);
            this.txt_Tendangnhap.Name = "txt_Tendangnhap";
            this.txt_Tendangnhap.Size = new System.Drawing.Size(334, 28);
            this.txt_Tendangnhap.TabIndex = 1;
            this.txt_Tendangnhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Tendangnhap_KeyDown);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MatKhau.Location = new System.Drawing.Point(691, 200);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(334, 28);
            this.txt_MatKhau.TabIndex = 2;
            this.txt_MatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MatKhau_KeyDown);
            // 
            // ptb_DangNhap
            // 
            this.ptb_DangNhap.Image = global::QL_NhaSach.Properties.Resources.DangNhap;
            this.ptb_DangNhap.Location = new System.Drawing.Point(760, 268);
            this.ptb_DangNhap.Name = "ptb_DangNhap";
            this.ptb_DangNhap.Size = new System.Drawing.Size(171, 42);
            this.ptb_DangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_DangNhap.TabIndex = 6;
            this.ptb_DangNhap.TabStop = false;
            this.ptb_DangNhap.Click += new System.EventHandler(this.ptb_DangNhap_Click);
            // 
            // ptb_Logo
            // 
            this.ptb_Logo.Image = global::QL_NhaSach.Properties.Resources.Logo___;
            this.ptb_Logo.Location = new System.Drawing.Point(87, 46);
            this.ptb_Logo.Name = "ptb_Logo";
            this.ptb_Logo.Size = new System.Drawing.Size(296, 215);
            this.ptb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Logo.TabIndex = 0;
            this.ptb_Logo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1071, 340);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_Tendangnhap);
            this.Controls.Add(this.ptb_DangNhap);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_TenDangNhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TenDangNhap;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.PictureBox ptb_DangNhap;
        private System.Windows.Forms.TextBox txt_Tendangnhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
    }
}

