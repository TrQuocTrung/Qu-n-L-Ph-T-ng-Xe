using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }
        public void hidemenustripNhanVien()
        {
            nhanVienToolStripMenuItem.Visible = false;
        }
        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachNhanVien frmDanhSachNhanvien = new frmDanhSachNhanVien();
            this.Hide();
            frmDanhSachNhanvien.ShowDialog();
            this.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comeBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();  
            this.Show();
        }

        private void shutDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tắt Ứng Dụng?","Confirm", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhsachPhuTung frmDanhsachPhuTung = new frmDanhsachPhuTung();
            this.Hide();
            frmDanhsachPhuTung.ShowDialog();
            this.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachNhaCC frmDanhSachNhaCC = new frmDanhSachNhaCC();
            this.Hide();
            frmDanhSachNhaCC.ShowDialog();  
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachKhachHang frmDanhSachKhachHang= new frmDanhSachKhachHang();
            this.Hide();
            frmDanhSachKhachHang.ShowDialog();
            this.Show();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdanhsachPhieuXuatHang frmdanhsachPhieuXuatHang = new frmdanhsachPhieuXuatHang();
            this.Hide();
            frmdanhsachPhieuXuatHang.ShowDialog();
            this.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDanhSachPhieuBanHang frm = new frmDanhSachPhieuBanHang();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSPhieuNhapKho frmDSPhieuNhapKho = new frmDSPhieuNhapKho();
            this.Hide();
            frmDSPhieuNhapKho.ShowDialog();
            this.Show();    
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachBaoCaoThongKe frmDanhSachBaoCaoThongKe = new frmDanhSachBaoCaoThongKe();
            this.Hide();
            frmDanhSachBaoCaoThongKe .ShowDialog(); 
            this.Show();
        }

        private void hóaĐơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhsachphieudathang frmDanhsachphieudathang = new frmDanhsachphieudathang();
            this.Hide();
            frmDanhsachphieudathang .ShowDialog();  
            this.Show();
        }
    }
}
