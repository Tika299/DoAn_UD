using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTUD
{
    public partial class ThemKhenThuong : Form
    {
        public ThemKhenThuong()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IQ0GJ6P;Initial Catalog=QUANLYKHENTHUONG;Integrated Security=True;Encrypt=False");

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdXoaThuong = new SqlCommand("SP_DeleteStudentAward", conn);

                cmdXoaThuong.CommandType = CommandType.StoredProcedure;

                SqlParameter parMaThuong = new SqlParameter("@StudentAwardID", txtMaThuong.Text);
                cmdXoaThuong.Parameters.Add(parMaThuong);

                if (cmdXoaThuong.ExecuteNonQuery() > 0)
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
            dtgDSSVThuong.DataSource = LoadThuong();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text.Trim() == "Đạt")
            {
                try
                {
                    conn.Open();

                    SqlCommand cmdThemSV = new SqlCommand("SP_AddStudentAward", conn);
                    cmdThemSV.CommandType = CommandType.StoredProcedure;

                    SqlParameter paraID = new SqlParameter("@StudentAwardID", txtMaThuong.Text);
                    cmdThemSV.Parameters.Add(paraID);

                    SqlParameter paraMaHV = new SqlParameter("@StudentID", LayMaSV(cmbSV.Text));
                    cmdThemSV.Parameters.Add(paraMaHV);

                    SqlParameter paraMaThuong = new SqlParameter("@AwardID", LayMaAward(cmbThuong.Text));
                    cmdThemSV.Parameters.Add(paraMaThuong);

                    SqlParameter paraNgayThuong = new SqlParameter("@AwardDate", (DateTime)dtpThuong.Value);
                    cmdThemSV.Parameters.Add(paraNgayThuong);

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
                dtgDSSVThuong.DataSource = LoadThuong();
            }
            else if (txtKQ.Text.Trim() == "Không Đạt")
            {
                MessageBox.Show("Học viên không đạt điều kiện xem xét!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn chưa xem xét học viên đã đủ điều kiện chưa!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private DataTable LoadThuong()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                //tao cau lenh
                SqlCommand cmdSV = new SqlCommand("SP_GetAllStudentAwards", conn);
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

        private DataTable LoadLoaiThuong()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                //tao cau lenh
                SqlCommand cmdSV = new SqlCommand("SP_GetAllAwards", conn);
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

        private double DiemAVG()
        {
            double diem = 0.0;
            try
            {
                conn.Open();

                SqlCommand cmdDiem = new SqlCommand("SP_CalculateAverageScore", conn);

                cmdDiem.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMa = new SqlParameter("@student", SqlDbType.Char);
                paraMa.Value = LayMaSV(cmbSV.Text); // Lấy StudentID từ ValueMember
                cmdDiem.Parameters.Add(paraMa);

                using (SqlDataReader reader = cmdDiem.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Lấy giá trị của cột AverageScore
                        diem = (double)reader["AverageScore"];
                        return Math.Round(diem, 2);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên.");
                    }
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
            return diem;
        }

        private int CountSubjects()
        {
            int somon = 0;
            try
            {
                conn.Open();

                SqlCommand cmdSoMon = new SqlCommand("SP_CountSubjects", conn);

                cmdSoMon.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMa = new SqlParameter("@student", SqlDbType.Char);
                paraMa.Value = LayMaSV(cmbSV.Text); // Lấy StudentID từ ValueMember
                cmdSoMon.Parameters.Add(paraMa);

                using (SqlDataReader reader = cmdSoMon.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Lấy giá trị của cột AverageScore
                        somon = (int)reader["CountSubjects"];
                        return somon;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên.");
                    }
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
            return somon;
        }

        private string LayMaSV(string sql)
        {
            string s = "";
            try
            {

                string test = "select StudentID from Students where FullName like N'%" + sql + "%'";
                SqlCommand cmdTen = new SqlCommand(sql, conn);
                cmdTen.CommandText = test;
                cmdTen.CommandType = CommandType.Text;

                s = (string)cmdTen.ExecuteScalar();


            }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return s;
        }

        private string LayMaThuong(string sql)
        {
            string s = "";
            try
            {
                conn.Open();

                string test = "select AwardID from Awards where AwardName like N'%" + sql + "%'";
                SqlCommand cmdTen = new SqlCommand(sql, conn);
                cmdTen.CommandText = test;
                cmdTen.CommandType = CommandType.Text;

                s = (string)cmdTen.ExecuteScalar();


            }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            finally
            {
                conn.Close();
            }
            return s;
        }

        private string LayMaAward(string sql)
        {
            string s = "";
            try
            {

                string test = "select AwardID from Awards where AwardName like N'%" + sql + "%'";
                SqlCommand cmdTen = new SqlCommand(sql, conn);
                cmdTen.CommandText = test;
                cmdTen.CommandType = CommandType.Text;

                s = (string)cmdTen.ExecuteScalar();


            }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return s;
        }

        private void btnXet_Click(object sender, EventArgs e)
        {
            double diem = DiemAVG();
            int soMon = CountSubjects();
            txtAVG.Text = diem.ToString();
            txtSoMon.Text = soMon.ToString();
            string s = LayMaThuong(cmbThuong.Text).Trim();
            if (s.Equals("A0003", StringComparison.OrdinalIgnoreCase))
            {
                if (diem >= 9 && soMon >= 3)
                {
                    txtKQ.Text = "Đạt";
                    errorProvider1.SetError(txtKQ, "");
                }
                else
                {
                    txtKQ.Text = "Không Đạt";
                    errorProvider1.SetError(txtKQ, "Học sinh phải đạt ít nhất 9 điểm trung bình hoặc học ít nhất 3 môn");
                }
            }
            else if (s.Equals("A0001", StringComparison.OrdinalIgnoreCase))
            {
                if (diem >= 8 && soMon >= 3)
                {
                    if (diem >= 9)
                    {
                        MessageBox.Show("Diem cua hoc vien cao hon dieu kien xet chon loai thuong cao hon", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtKQ.Text = "";
                    }
                    else
                    {
                        txtKQ.Text = "Đạt";
                        errorProvider1.SetError(txtKQ, "");
                    }
                }
                else
                {
                    txtKQ.Text = "Không Đạt";
                    errorProvider1.SetError(txtKQ, "Học sinh phải đạt ít nhất 8 điểm trung bình hoặc học ít nhất 3 môn");
                }
            }
            else
            {
                if (diem >= 7 && soMon >= 3)
                {
                    if (diem >= 8)
                    {
                        MessageBox.Show("Diem cua hoc vien cao hon dieu kien xet chon loai thuong cao hon", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtKQ.Text = "";
                    }
                    else
                    {
                        txtKQ.Text = "Đạt";
                        errorProvider1.SetError(txtKQ, "");
                    }
                }
                else
                {
                    txtKQ.Text = "Không Đạt";
                    errorProvider1.SetError(txtKQ, "Học sinh phải đạt ít nhất 7 điểm trung bình hoặc học ít nhất 3 môn");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void dtgDSSVThuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaThuong.Text = dtgDSSVThuong.Rows[dong].Cells[0].Value.ToString();
            cmbSV.Text = dtgDSSVThuong.Rows[dong].Cells[1].Value.ToString().Trim();
            cmbThuong.Text = dtgDSSVThuong.Rows[dong].Cells[2].Value.ToString().Trim();
            dtpThuong.Value = (DateTime)dtgDSSVThuong.Rows[dong].Cells[3].Value;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaThuong.Text = "";
            cmbSV.SelectedIndex = 0;
            cmbThuong.SelectedIndex = 0;
            dtpThuong.Text = DateTime.Now.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmdTim = new SqlCommand("SP_TimSAMa", conn);
                cmdTim.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter("@studentId", txtMaThuong.Text);
                cmdTim.Parameters.Add(para);

                SqlDataAdapter da = new SqlDataAdapter(cmdTim);

                da.Fill(dt);
                dtgDSSVThuong.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi + " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ThemKhenThuong_Load(object sender, EventArgs e)
        {
            cmbSV.DataSource = LoadSV();
            cmbSV.DisplayMember = "FullName";
            cmbSV.ValueMember = "StudentID";
            cmbThuong.DataSource = LoadLoaiThuong();
            cmbThuong.DisplayMember = "AwardName";
            cmbThuong.ValueMember = "AwardID";
            dtgDSSVThuong.DataSource = LoadThuong();
        }
    }
}
