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

namespace DoAnLTUD
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IQ0GJ6P;Initial Catalog=QUANLYKHENTHUONG;Integrated Security=True;Encrypt=False");

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Vui lòng nhập tên đăng nhập và mật khẩu!";
                return;
            }

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Mở Form chính
                frmMenu mainForm = new frmMenu();
                mainForm.Show();
                this.Hide(); // Ẩn Form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                conn.Open();

                // Sử dụng Stored Procedure
                using (SqlCommand cmd = new SqlCommand("SP_AuthenticateUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số cho Stored Procedure
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Thực thi Stored Procedure và lấy kết quả
                    int result = (int)cmd.ExecuteScalar();

                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // Hiển thị mật khẩu
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmRegister mainForm = new frmRegister();
            mainForm.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {         
            this.Close();
        }
    }
}
