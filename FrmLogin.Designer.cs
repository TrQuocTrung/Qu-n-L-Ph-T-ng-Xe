namespace WindowsFormsApp1
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTendangnhap = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblLoaiTk = new System.Windows.Forms.Label();
            this.cobLoaiTK = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblID = new System.Windows.Forms.Label();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.ForeColor = System.Drawing.Color.Navy;
            this.btnDangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangnhap.Location = new System.Drawing.Point(172, 278);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(96, 39);
            this.btnDangnhap.TabIndex = 0;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Navy;
            this.btnexit.Location = new System.Drawing.Point(493, 278);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 39);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(768, 346);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblTendangnhap
            // 
            this.lblTendangnhap.Location = new System.Drawing.Point(169, 148);
            this.lblTendangnhap.Name = "lblTendangnhap";
            this.lblTendangnhap.Size = new System.Drawing.Size(120, 23);
            this.lblTendangnhap.TabIndex = 2;
            this.lblTendangnhap.Text = "Tên Đăng Nhập :";
            this.lblTendangnhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(169, 198);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(73, 16);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password :";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(295, 148);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(235, 22);
            this.txtuser.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(295, 192);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(235, 22);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // lblLoaiTk
            // 
            this.lblLoaiTk.AutoSize = true;
            this.lblLoaiTk.Location = new System.Drawing.Point(169, 57);
            this.lblLoaiTk.Name = "lblLoaiTk";
            this.lblLoaiTk.Size = new System.Drawing.Size(97, 16);
            this.lblLoaiTk.TabIndex = 6;
            this.lblLoaiTk.Text = "Loại Tài Khoản";
            this.lblLoaiTk.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cobLoaiTK
            // 
            this.cobLoaiTK.DisplayMember = "Quản Lý";
            this.cobLoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobLoaiTK.FormattingEnabled = true;
            this.cobLoaiTK.Items.AddRange(new object[] {
            "Quản lý ",
            "Nhân viên"});
            this.cobLoaiTK.Location = new System.Drawing.Point(295, 57);
            this.cobLoaiTK.Name = "cobLoaiTK";
            this.cobLoaiTK.Size = new System.Drawing.Size(235, 24);
            this.cobLoaiTK.TabIndex = 7;
            this.cobLoaiTK.SelectedIndexChanged += new System.EventHandler(this.cobLoaiTK_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(295, 104);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(235, 22);
            this.txtID.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(170, 107);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 16);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID  : ";
            // 
            // picLogin
            // 
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.Location = new System.Drawing.Point(696, 12);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(115, 86);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogin.TabIndex = 11;
            this.picLogin.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(68, 57);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(95, 69);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 12;
            this.picUser.TabStop = false;
            this.picUser.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(823, 371);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cobLoaiTK);
            this.Controls.Add(this.lblLoaiTk);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblTendangnhap);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnDangnhap);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhập Xuất Phụ Tùng Xe";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblTendangnhap;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblLoaiTk;
        private System.Windows.Forms.ComboBox cobLoaiTK;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox picUser;
    }
}

