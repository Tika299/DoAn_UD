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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IQ0GJ6P;Initial Catalog=QUANLYKHENTHUONG;Integrated Security=True;Encrypt=False");

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
            this.Close();
            }
            else
            {

            }

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.Show();
            this.Close();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            FormAddClass frmAddClass = new FormAddClass();
            frmAddClass.Show();
            this.Close();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnKhenThuong_Click(object sender, EventArgs e)
        {
            ThemKhenThuong themKhenThuong = new ThemKhenThuong();
            themKhenThuong.Show();
            this.Close();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            frmAddResults addResults = new frmAddResults();
            addResults.Show();
            this.Close();
        }
    }
}
