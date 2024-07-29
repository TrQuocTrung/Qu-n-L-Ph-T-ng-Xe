namespace WindowsFormsApp1
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comeBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaXuatHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnĐặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.quanLyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comeBackToolStripMenuItem,
            this.shutDownToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // comeBackToolStripMenuItem
            // 
            this.comeBackToolStripMenuItem.Name = "comeBackToolStripMenuItem";
            this.comeBackToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.comeBackToolStripMenuItem.Text = "Come Back";
            this.comeBackToolStripMenuItem.Click += new System.EventHandler(this.comeBackToolStripMenuItem_Click);
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.shutDownToolStripMenuItem.Text = "Shut Down";
            this.shutDownToolStripMenuItem.Click += new System.EventHandler(this.shutDownToolStripMenuItem_Click);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngHóaToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.nhanVienToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quanLyToolStripMenuItem.Text = "Quản Lý";
            this.quanLyToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hàngHóaToolStripMenuItem.Text = "Phụ Tùng ";
            this.hàngHóaToolStripMenuItem.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnNhậpToolStripMenuItem,
            this.hóaXuatHangToolStripMenuItem,
            this.hóaĐơnBanToolStripMenuItem1,
            this.hóaĐơnĐặtHàngToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // hóaĐơnNhậpToolStripMenuItem
            // 
            this.hóaĐơnNhậpToolStripMenuItem.Name = "hóaĐơnNhậpToolStripMenuItem";
            this.hóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.hóaĐơnNhậpToolStripMenuItem.Text = "Hóa Đơn Nhập Hàng";
            this.hóaĐơnNhậpToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnNhậpToolStripMenuItem_Click);
            // 
            // hóaXuatHangToolStripMenuItem
            // 
            this.hóaXuatHangToolStripMenuItem.Name = "hóaXuatHangToolStripMenuItem";
            this.hóaXuatHangToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.hóaXuatHangToolStripMenuItem.Text = "Hóa Đơn Xuất Hàng";
            this.hóaXuatHangToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnBánHàngToolStripMenuItem_Click);
            // 
            // hóaĐơnBanToolStripMenuItem1
            // 
            this.hóaĐơnBanToolStripMenuItem1.Name = "hóaĐơnBanToolStripMenuItem1";
            this.hóaĐơnBanToolStripMenuItem1.Size = new System.Drawing.Size(232, 26);
            this.hóaĐơnBanToolStripMenuItem1.Text = "Hóa Đơn Bán Hàng";
            this.hóaĐơnBanToolStripMenuItem1.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem1_Click);
            // 
            // hóaĐơnĐặtHàngToolStripMenuItem
            // 
            this.hóaĐơnĐặtHàngToolStripMenuItem.Name = "hóaĐơnĐặtHàngToolStripMenuItem";
            this.hóaĐơnĐặtHàngToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.hóaĐơnĐặtHàngToolStripMenuItem.Text = "Hóa Đơn Đặt Hàng";
            this.hóaĐơnĐặtHàngToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnĐặtHàngToolStripMenuItem_Click);
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhanVienToolStripMenuItem.Text = "Nhân Viên";
            this.nhanVienToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo Cáo Thống Kê";
            this.báoCáoThốngKêToolStripMenuItem.Click += new System.EventHandler(this.báoCáoThốngKêToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comeBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaXuatHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnĐặtHàngToolStripMenuItem;
    }
}