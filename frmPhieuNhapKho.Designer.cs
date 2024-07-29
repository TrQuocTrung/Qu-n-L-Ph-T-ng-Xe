namespace WindowsFormsApp1
{
    partial class frmPhieuNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhapKho));
            this.lblPT = new System.Windows.Forms.Label();
            this.lblMaPN = new System.Windows.Forms.Label();
            this.lblNgaynhap = new System.Windows.Forms.Label();
            this.lblNhaCC = new System.Windows.Forms.Label();
            this.lblTongSL = new System.Windows.Forms.Label();
            this.lblToonggiatri = new System.Windows.Forms.Label();
            this.lblngaytao = new System.Windows.Forms.Label();
            this.lblnguoitao = new System.Windows.Forms.Label();
            this.txtTongGT = new System.Windows.Forms.TextBox();
            this.txtNguoitao = new System.Windows.Forms.TextBox();
            this.txtTongSL = new System.Windows.Forms.TextBox();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.mtbNgaytao = new System.Windows.Forms.MaskedTextBox();
            this.mtbNgaynhap = new System.Windows.Forms.MaskedTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPT
            // 
            this.lblPT.AutoSize = true;
            this.lblPT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPT.ForeColor = System.Drawing.Color.Navy;
            this.lblPT.Location = new System.Drawing.Point(225, 9);
            this.lblPT.Name = "lblPT";
            this.lblPT.Size = new System.Drawing.Size(298, 23);
            this.lblPT.TabIndex = 11;
            this.lblPT.Text = "THÔNG TIN PHIẾU NHẬP KHO";
            // 
            // lblMaPN
            // 
            this.lblMaPN.AutoSize = true;
            this.lblMaPN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPN.Location = new System.Drawing.Point(30, 101);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(112, 17);
            this.lblMaPN.TabIndex = 12;
            this.lblMaPN.Text = "Mã Phiếu Nhập : ";
            // 
            // lblNgaynhap
            // 
            this.lblNgaynhap.AutoSize = true;
            this.lblNgaynhap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaynhap.Location = new System.Drawing.Point(30, 156);
            this.lblNgaynhap.Name = "lblNgaynhap";
            this.lblNgaynhap.Size = new System.Drawing.Size(87, 17);
            this.lblNgaynhap.TabIndex = 12;
            this.lblNgaynhap.Text = "Ngày Nhập : ";
            // 
            // lblNhaCC
            // 
            this.lblNhaCC.AutoSize = true;
            this.lblNhaCC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCC.Location = new System.Drawing.Point(30, 214);
            this.lblNhaCC.Name = "lblNhaCC";
            this.lblNhaCC.Size = new System.Drawing.Size(103, 17);
            this.lblNhaCC.TabIndex = 12;
            this.lblNhaCC.Text = "Nhà Cung Cấp :";
            // 
            // lblTongSL
            // 
            this.lblTongSL.AutoSize = true;
            this.lblTongSL.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSL.Location = new System.Drawing.Point(30, 271);
            this.lblTongSL.Name = "lblTongSL";
            this.lblTongSL.Size = new System.Drawing.Size(111, 17);
            this.lblTongSL.TabIndex = 12;
            this.lblTongSL.Text = "Tổng Số Lượng : ";
            // 
            // lblToonggiatri
            // 
            this.lblToonggiatri.AutoSize = true;
            this.lblToonggiatri.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToonggiatri.Location = new System.Drawing.Point(489, 214);
            this.lblToonggiatri.Name = "lblToonggiatri";
            this.lblToonggiatri.Size = new System.Drawing.Size(86, 17);
            this.lblToonggiatri.TabIndex = 12;
            this.lblToonggiatri.Text = "Tổng giá trị : ";
            // 
            // lblngaytao
            // 
            this.lblngaytao.AutoSize = true;
            this.lblngaytao.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaytao.Location = new System.Drawing.Point(489, 101);
            this.lblngaytao.Name = "lblngaytao";
            this.lblngaytao.Size = new System.Drawing.Size(78, 17);
            this.lblngaytao.TabIndex = 12;
            this.lblngaytao.Text = "Ngày Tạo : ";
            // 
            // lblnguoitao
            // 
            this.lblnguoitao.AutoSize = true;
            this.lblnguoitao.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnguoitao.Location = new System.Drawing.Point(489, 156);
            this.lblnguoitao.Name = "lblnguoitao";
            this.lblnguoitao.Size = new System.Drawing.Size(78, 17);
            this.lblnguoitao.TabIndex = 12;
            this.lblnguoitao.Text = "Người tạo : ";
            // 
            // txtTongGT
            // 
            this.txtTongGT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongGT.Location = new System.Drawing.Point(600, 208);
            this.txtTongGT.Name = "txtTongGT";
            this.txtTongGT.Size = new System.Drawing.Size(146, 25);
            this.txtTongGT.TabIndex = 13;
            // 
            // txtNguoitao
            // 
            this.txtNguoitao.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoitao.Location = new System.Drawing.Point(600, 156);
            this.txtNguoitao.Name = "txtNguoitao";
            this.txtNguoitao.Size = new System.Drawing.Size(146, 25);
            this.txtNguoitao.TabIndex = 13;
            // 
            // txtTongSL
            // 
            this.txtTongSL.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSL.Location = new System.Drawing.Point(157, 266);
            this.txtTongSL.Name = "txtTongSL";
            this.txtTongSL.Size = new System.Drawing.Size(146, 25);
            this.txtTongSL.TabIndex = 13;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaCC.Location = new System.Drawing.Point(157, 208);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(146, 25);
            this.txtNhaCC.TabIndex = 13;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(157, 102);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(146, 25);
            this.txtMaPN.TabIndex = 13;
            // 
            // mtbNgaytao
            // 
            this.mtbNgaytao.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNgaytao.Location = new System.Drawing.Point(600, 99);
            this.mtbNgaytao.Mask = "00/00/0000";
            this.mtbNgaytao.Name = "mtbNgaytao";
            this.mtbNgaytao.Size = new System.Drawing.Size(146, 25);
            this.mtbNgaytao.TabIndex = 14;
            // 
            // mtbNgaynhap
            // 
            this.mtbNgaynhap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNgaynhap.Location = new System.Drawing.Point(157, 153);
            this.mtbNgaynhap.Name = "mtbNgaynhap";
            this.mtbNgaynhap.Size = new System.Drawing.Size(146, 25);
            this.mtbNgaynhap.TabIndex = 14;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Navy;
            this.btnLuu.Location = new System.Drawing.Point(157, 345);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 43);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Navy;
            this.btnBack.Location = new System.Drawing.Point(492, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 43);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.mtbNgaynhap);
            this.Controls.Add(this.mtbNgaytao);
            this.Controls.Add(this.txtMaPN);
            this.Controls.Add(this.txtNhaCC);
            this.Controls.Add(this.txtTongSL);
            this.Controls.Add(this.txtNguoitao);
            this.Controls.Add(this.txtTongGT);
            this.Controls.Add(this.lblnguoitao);
            this.Controls.Add(this.lblngaytao);
            this.Controls.Add(this.lblToonggiatri);
            this.Controls.Add(this.lblTongSL);
            this.Controls.Add(this.lblNhaCC);
            this.Controls.Add(this.lblNgaynhap);
            this.Controls.Add(this.lblMaPN);
            this.Controls.Add(this.lblPT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhieuNhapKho";
            this.Text = "Thông tin phiếu nhập kho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPT;
        private System.Windows.Forms.Label lblMaPN;
        private System.Windows.Forms.Label lblNgaynhap;
        private System.Windows.Forms.Label lblNhaCC;
        private System.Windows.Forms.Label lblTongSL;
        private System.Windows.Forms.Label lblToonggiatri;
        private System.Windows.Forms.Label lblngaytao;
        private System.Windows.Forms.Label lblnguoitao;
        private System.Windows.Forms.TextBox txtTongGT;
        private System.Windows.Forms.TextBox txtNguoitao;
        private System.Windows.Forms.TextBox txtTongSL;
        private System.Windows.Forms.TextBox txtNhaCC;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.MaskedTextBox mtbNgaytao;
        private System.Windows.Forms.MaskedTextBox mtbNgaynhap;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBack;
    }
}