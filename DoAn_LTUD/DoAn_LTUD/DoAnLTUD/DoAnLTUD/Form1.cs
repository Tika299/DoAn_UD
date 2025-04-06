using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IQ0GJ6P;Initial Catalog=QUANLYKHENTHUONG;Integrated Security=True;Encrypt=False");

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbLop.DataSource = LoadLop();
            cmbLop.DisplayMember = "ClassName";
            cmbLop.ValueMember = "ClassID";
            dtgSV.DataSource = LoadSV();
        }
        private DataTable LoadSV()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                //tao cau lenh
                SqlCommand cmdSV = new SqlCommand("SP_GetAllStudents", conn);
                //type
                cmdSV.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmdSV);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        private DataTable LoadLop()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                //tao cau lenh
                SqlCommand cmdSV = new SqlCommand("SP_GetAllClass", conn);
                //type
                cmdSV.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmdSV);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        private void dtgSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSV.Text = dtgSV.Rows[dong].Cells[0].Value.ToString();
            txtHoVaTen.Text = dtgSV.Rows[dong].Cells[1].Value.ToString();
            cmbLop.Text = LayTen(dtgSV.Rows[dong].Cells[2].Value.ToString().Trim());
            if (dtgSV.Rows[dong].Cells[3].Value.ToString() == "Nam")
            {
                rdioNam.Checked = true;
            }
            else
            {
                rdioNu.Checked = true;
            }
            dtpBir.Value = (DateTime)dtgSV.Rows[dong].Cells[4].Value;
            string imageDirectory = @"D:\do_an_img";
            string imagePath = Path.Combine(imageDirectory, dtgSV.Rows[dong].Cells[0].Value.ToString() + ".jpg");

            if (File.Exists(imagePath))
            {
                picBSV.ImageLocation = imagePath;
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh của sinh viên!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private string LayTen(string sql)
        {
            string s = "";
            try
            {
                conn.Open();

                string test = "select ClassName from Class where ClassID = '" + sql + "'";
                SqlCommand cmdTen = new SqlCommand(sql, conn);
                cmdTen.CommandText = test;
                cmdTen.CommandType = CommandType.Text;

                s = (string)cmdTen.ExecuteScalar();


            }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            finally { conn.Close(); }
            return s;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdThemSV = new SqlCommand("SP_AddStudent", conn);
                cmdThemSV.CommandType = CommandType.StoredProcedure;

                SqlParameter paraID = new SqlParameter("@StudentID", txtMaSV.Text);
                cmdThemSV.Parameters.Add(paraID);

                SqlParameter paraHoTen = new SqlParameter("@FullName", txtHoVaTen.Text);
                cmdThemSV.Parameters.Add(paraHoTen);

                SqlParameter paraLop = new SqlParameter("@Class", LayMa(cmbLop.Text));
                cmdThemSV.Parameters.Add(paraLop);

                //xu ly lay gt
                string gt = rdioNam.Checked == true ? "Nam" : "Nữ";
                SqlParameter paraGT = new SqlParameter("@Gender", gt);
                cmdThemSV.Parameters.Add(paraGT);

                SqlParameter paraBir = new SqlParameter("@DateOfBirth", (DateTime)dtpBir.Value);
                cmdThemSV.Parameters.Add(paraBir);

                string img = picBSV.ImageLocation;
                string saveDirectory = @"D:\do_an_img";
                string fileExtension = Path.GetExtension(picBSV.ImageLocation);
                string savePath = Path.Combine(saveDirectory, txtMaSV.Text + fileExtension);

                try
                {
                    File.Copy(img, savePath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh " + ex.Message);
                }

                if (cmdThemSV.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dtgSV.DataSource = LoadSV();
        }
        private string LayMa(string sql)
        {
            string s = "";
            try
            {

                string test = "select ClassID from Class where ClassName like N'%" + sql + "%'";
                SqlCommand cmdTen = new SqlCommand(sql, conn);
                cmdTen.CommandText = test;
                cmdTen.CommandType = CommandType.Text;

                s = (string)cmdTen.ExecuteScalar();


            }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return s;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdXoaSV = new SqlCommand("SP_DeleteStudent", conn);

                cmdXoaSV.CommandType = CommandType.StoredProcedure;

                SqlParameter parMaSV = new SqlParameter("@StudentID", txtMaSV.Text);
                cmdXoaSV.Parameters.Add(parMaSV);

                if (cmdXoaSV.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally { conn.Close(); }
            dtgSV.DataSource = LoadSV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdSuaSV = new SqlCommand("SP_UpdateStudent", conn);
                cmdSuaSV.CommandType = CommandType.StoredProcedure;

                SqlParameter paraID = new SqlParameter("@StudentID", txtMaSV.Text);
                cmdSuaSV.Parameters.Add(paraID);

                SqlParameter paraHoTen = new SqlParameter("@FullName", txtHoVaTen.Text);
                cmdSuaSV.Parameters.Add(paraHoTen);

                SqlParameter paraLop = new SqlParameter("@Class", LayMa(cmbLop.Text));
                cmdSuaSV.Parameters.Add(paraLop);

                //xu ly lay gt
                string gt = rdioNam.Checked == true ? "Nam" : "Nữ";
                SqlParameter paraGT = new SqlParameter("@Gender", gt);
                cmdSuaSV.Parameters.Add(paraGT);

                SqlParameter paraBir = new SqlParameter("@DateOfBirth", (DateTime)dtpBir.Value);
                cmdSuaSV.Parameters.Add(paraBir);

                string img = picBSV.ImageLocation;
                string saveDirectory = @"D:\do_an_img";
                string fileExtension = Path.GetExtension(picBSV.ImageLocation);
                string savePath = Path.Combine(saveDirectory, txtMaSV.Text + fileExtension);

                try
                {
                    File.Copy(img, savePath, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh " + ex.Message);
                }

                if (cmdSuaSV.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dtgSV.DataSource = LoadSV();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoVaTen.Clear();
            rdioNam.Checked = true;
            txtMaSV.Focus();
            dtgSV.DataSource = LoadSV();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                Title = "Chọn hình ảnh"
            };

            if (img.ShowDialog() == DialogResult.OK)
            {
                picBSV.ImageLocation = img.FileName;
            }
        }
    }
}
