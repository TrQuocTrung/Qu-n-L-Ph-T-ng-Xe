namespace WindowsFormsApp1
{
    partial class frmPhieuBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuBanHang));
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblngayban = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblTenSp = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lbldongia = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.lbLtitlePBH = new System.Windows.Forms.Label();
            this.lblPTTT = new System.Windows.Forms.Label();
            this.lblNguoithuchien = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtPhuongthucTT = new System.Windows.Forms.TextBox();
            this.txtNguoiTH = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.mtbNgayban = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(26, 76);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(82, 15);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã Hóa Đơn :";
            this.lblMaHD.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(26, 165);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(101, 15);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã Khách Hàng :";
            // 
            // lblngayban
            // 
            this.lblngayban.AutoSize = true;
            this.lblngayban.Location = new System.Drawing.Point(26, 118);
            this.lblngayban.Name = "lblngayban";
            this.lblngayban.Size = new System.Drawing.Size(69, 15);
            this.lblngayban.TabIndex = 0;
            this.lblngayban.Text = "Ngày Bán : ";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(26, 215);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(107, 15);
            this.lblTenKH.TabIndex = 1;
            this.lblTenKH.Text = "Tên Khách Hàng : ";
            // 
            // lblTenSp
            // 
            this.lblTenSp.AutoSize = true;
            this.lblTenSp.Location = new System.Drawing.Point(26, 265);
            this.lblTenSp.Name = "lblTenSp";
            this.lblTenSp.Size = new System.Drawing.Size(92, 15);
            this.lblTenSp.TabIndex = 0;
            this.lblTenSp.Text = "Tên Sản Phẩm : ";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(354, 76);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(68, 15);
            this.lblSoluong.TabIndex = 1;
            this.lblSoluong.Text = "Số Lượng : ";
            // 
            // lbldongia
            // 
            this.lbldongia.AutoSize = true;
            this.lbldongia.Location = new System.Drawing.Point(354, 118);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(56, 15);
            this.lbldongia.TabIndex = 0;
            this.lbldongia.Text = "Đơn Giá :";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(354, 165);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(72, 15);
            this.lblTongtien.TabIndex = 1;
            this.lblTongtien.Text = "Tổng Tiền : ";
            // 
            // lbLtitlePBH
            // 
            this.lbLtitlePBH.AutoSize = true;
            this.lbLtitlePBH.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbLtitlePBH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLtitlePBH.ForeColor = System.Drawing.Color.Navy;
            this.lbLtitlePBH.Location = new System.Drawing.Point(208, 8);
            this.lbLtitlePBH.Name = "lbLtitlePBH";
            this.lbLtitlePBH.Size = new System.Drawing.Size(299, 23);
            this.lbLtitlePBH.TabIndex = 12;
            this.lbLtitlePBH.Text = "THÔNG TIN PHIẾU BÁN HÀNG";
            // 
            // lblPTTT
            // 
            this.lblPTTT.AutoSize = true;
            this.lblPTTT.Location = new System.Drawing.Point(350, 215);
            this.lblPTTT.Name = "lblPTTT";
            this.lblPTTT.Size = new System.Drawing.Size(146, 15);
            this.lblPTTT.TabIndex = 1;
            this.lblPTTT.Text = "Phương thức thanh toán : ";
            // 
            // lblNguoithuchien
            // 
            this.lblNguoithuchien.AutoSize = true;
            this.lblNguoithuchien.Location = new System.Drawing.Point(350, 265);
            this.lblNguoithuchien.Name = "lblNguoithuchien";
            this.lblNguoithuchien.Size = new System.Drawing.Size(105, 15);
            this.lblNguoithuchien.TabIndex = 1;
            this.lblNguoithuchien.Text = "Người thực hiện  : ";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(428, 73);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(157, 22);
            this.txtSoluong.TabIndex = 13;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(428, 115);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(157, 22);
            this.txtDongia.TabIndex = 13;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(428, 158);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(157, 22);
            this.txtTongtien.TabIndex = 13;
            // 
            // txtPhuongthucTT
            // 
            this.txtPhuongthucTT.Location = new System.Drawing.Point(490, 212);
            this.txtPhuongthucTT.Name = "txtPhuongthucTT";
            this.txtPhuongthucTT.Size = new System.Drawing.Size(157, 22);
            this.txtPhuongthucTT.TabIndex = 13;
            this.txtPhuongthucTT.TextChanged += new System.EventHandler(this.txtPhuongthucTT_TextChanged);
            // 
            // txtNguoiTH
            // 
            this.txtNguoiTH.Location = new System.Drawing.Point(461, 262);
            this.txtNguoiTH.Name = "txtNguoiTH";
            this.txtNguoiTH.Size = new System.Drawing.Size(157, 22);
            this.txtNguoiTH.TabIndex = 13;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(133, 73);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(157, 22);
            this.txtMaHD.TabIndex = 13;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(133, 158);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(157, 22);
            this.txtMaKH.TabIndex = 13;
            this.txtMaKH.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(133, 208);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(157, 22);
            this.txtTenKH.TabIndex = 13;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(133, 258);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(157, 22);
            this.txtTensp.TabIndex = 13;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Navy;
            this.btnLuu.Location = new System.Drawing.Point(145, 317);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 49);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Navy;
            this.btnBack.Location = new System.Drawing.Point(464, 317);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 49);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // mtbNgayban
            // 
            this.mtbNgayban.Location = new System.Drawing.Point(133, 118);
            this.mtbNgayban.Name = "mtbNgayban";
            this.mtbNgayban.Size = new System.Drawing.Size(157, 22);
            this.mtbNgayban.TabIndex = 16;
            // 
            // frmPhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.mtbNgayban);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtNguoiTH);
            this.Controls.Add(this.txtPhuongthucTT);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtTensp);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.lbLtitlePBH);
            this.Controls.Add(this.lblNguoithuchien);
            this.Controls.Add(this.lblPTTT);
            this.Controls.Add(this.lblTongtien);
            this.Controls.Add(this.lbldongia);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.lblTenSp);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblngayban);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.lblMaHD);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhieuBanHang";
            this.Text = "Thông Tin Phiếu Bán Hàng";
            this.Load += new System.EventHandler(this.frmPhieuBanHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblngayban;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblTenSp;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lbldongia;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lbLtitlePBH;
        private System.Windows.Forms.Label lblPTTT;
        private System.Windows.Forms.Label lblNguoithuchien;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtPhuongthucTT;
        private System.Windows.Forms.TextBox txtNguoiTH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MaskedTextBox mtbNgayban;
    }
}