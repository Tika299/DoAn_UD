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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IQ0GJ6P;Initial Catalog=QUANLYKHENTHUONG;Integrated Security=True;Encrypt=False");

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = txtRole.Text;

            if (ValidateForm(userID, username, password, role))
            {
                // Gọi phương thức thêm người dùng vào cơ sở dữ liệu
                AddUserToDatabase(userID, username, password, role);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }
        // Phương thức để gọi Stored Procedure thêm người dùng
        private void AddUserToDatabase(string userID, string username, string password, string role)
        {
            try
            {
                conn.Open();

                // Tạo Command và chỉ định Stored Procedure cần gọi
                SqlCommand cmd = new SqlCommand("SP_AddUsers", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào Stored Procedure
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password); 
                cmd.Parameters.AddWithValue("@Role", role);

                // Thực thi Stored Procedure
                cmd.ExecuteNonQuery();

                MessageBox.Show("Đăng ký thành công!");
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        // Phương thức kiểm tra thông tin đầu vào của người dùng
        private bool ValidateForm(string userID, string username, string password, string role)
        {
            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                return false;
            }
            return true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
    }
}
