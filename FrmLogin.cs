using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        DataConnection dc = new DataConnection(); 
        SqlCommand cmd;
        SqlDataAdapter dapter;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE ID=@ID AND TenDangNhap = @TenDangNhap AND MatKhau= @MatKhau AND LoaiTaiKhoan = @LoaiTaiKhoan";

            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "ID không được để trống");
                return;
            }
            if (txtuser.Text == "")
            {
                errorProvider1.SetError(txtuser, "User không được để trống");
                return;
            }
            if (txtpassword.Text == "")
            {
                errorProvider1.SetError(txtpassword, "Password không được để trống");
                return;
            }

            SqlConnection connection = dc.getConnect();
            connection.Open();
            cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.Parameters.AddWithValue("@LoaiTaiKhoan", cobLoaiTK.Text);
            cmd.Parameters.AddWithValue("@TenDangNhap", txtuser.Text);
            cmd.Parameters.AddWithValue("@MatKhau", txtpassword.Text);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                if (cobLoaiTK.Text == "Quản lý ")
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmWelcome frmWelcome = new frmWelcome();
                    this.Hide();
                    frmWelcome.ShowDialog();
                    this.Show();
                }
                if (cobLoaiTK.Text == "Nhân viên")
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmWelcome frmWelcome = new frmWelcome();
                    this.Hide();
                    frmWelcome.hidemenustripNhanVien();
                    frmWelcome.ShowDialog();
                    this.Show();

                }

            }
            else { 
                    MessageBox.Show("Thông tin tài khoản sai !!","Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát ? ", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void cobLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
