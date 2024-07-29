namespace WindowsFormsApp1
{
    partial class FrmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụTùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phụTùngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.phụTùngToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.phụTùngToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.phụTùngToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phụTùngToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem1});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // phụTùngToolStripMenuItem
            // 
            this.phụTùngToolStripMenuItem.Name = "phụTùngToolStripMenuItem";
            this.phụTùngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phụTùngToolStripMenuItem.Text = "Phụ Tùng";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhàCungCấpToolStripMenuItem1,
            this.phụTùngToolStripMenuItem1});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhàCungCấpToolStripMenuItem2,
            this.phụTùngToolStripMenuItem2});
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmToolStripMenuItem.Text = "Thêm ";
            // 
            // nhàCungCấpToolStripMenuItem1
            // 
            this.nhàCungCấpToolStripMenuItem1.Name = "nhàCungCấpToolStripMenuItem1";
            this.nhàCungCấpToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.nhàCungCấpToolStripMenuItem1.Text = "Nhà Cung Cấp";
            // 
            // phụTùngToolStripMenuItem1
            // 
            this.phụTùngToolStripMenuItem1.Name = "phụTùngToolStripMenuItem1";
            this.phụTùngToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.phụTùngToolStripMenuItem1.Text = "Phụ Tùng";
            // 
            // nhàCungCấpToolStripMenuItem2
            // 
            this.nhàCungCấpToolStripMenuItem2.Name = "nhàCungCấpToolStripMenuItem2";
            this.nhàCungCấpToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.nhàCungCấpToolStripMenuItem2.Text = "Nhà Cung Cấp";
            // 
            // phụTùngToolStripMenuItem2
            // 
            this.phụTùngToolStripMenuItem2.Name = "phụTùngToolStripMenuItem2";
            this.phụTùngToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.phụTùngToolStripMenuItem2.Text = "Phụ Tùng";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhàCungCấpToolStripMenuItem3,
            this.phụTùngToolStripMenuItem3});
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhàCungCấpToolStripMenuItem4,
            this.phụTùngToolStripMenuItem4});
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // nhàCungCấpToolStripMenuItem3
            // 
            this.nhàCungCấpToolStripMenuItem3.Name = "nhàCungCấpToolStripMenuItem3";
            this.nhàCungCấpToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.nhàCungCấpToolStripMenuItem3.Text = "Nhà Cung Cấp";
            // 
            // phụTùngToolStripMenuItem3
            // 
            this.phụTùngToolStripMenuItem3.Name = "phụTùngToolStripMenuItem3";
            this.phụTùngToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.phụTùngToolStripMenuItem3.Text = "Phụ Tùng";
            // 
            // nhàCungCấpToolStripMenuItem4
            // 
            this.nhàCungCấpToolStripMenuItem4.Name = "nhàCungCấpToolStripMenuItem4";
            this.nhàCungCấpToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.nhàCungCấpToolStripMenuItem4.Text = "Nhà Cung Cấp";
            // 
            // phụTùngToolStripMenuItem4
            // 
            this.phụTùngToolStripMenuItem4.Name = "phụTùngToolStripMenuItem4";
            this.phụTùngToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.phụTùngToolStripMenuItem4.Text = "Phụ Tùng";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // hóaĐơnToolStripMenuItem1
            // 
            this.hóaĐơnToolStripMenuItem1.Name = "hóaĐơnToolStripMenuItem1";
            this.hóaĐơnToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.hóaĐơnToolStripMenuItem1.Text = "Hóa Đơn";
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.FrmWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
    }
}