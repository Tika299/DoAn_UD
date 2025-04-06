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
    public partial class frmAddResults : Form
    {
        public frmAddResults()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IQ0GJ6P;Initial Catalog=QUANLYKHENTHUONG;Integrated Security=True;Encrypt=False");

        private void frmAddResults_Load(object sender, EventArgs e)
        {
            cmbSV.DataSource = LoadSV();
            cmbSV.DisplayMember = "FullName";
            cmbSV.ValueMember = "StudentID";
            cmbMon.DataSource = LoadSubjects();
            cmbMon.DisplayMember = "SubjectsName";
            cmbMon.ValueMember = "SubjectsID";
            dtgKQ.DataSource = LoadResults();
        }

        private DataTable LoadResults()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmdKQ = new SqlCommand("SP_GetAllResults", conn);
                cmdKQ.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdKQ);
                dataAdapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi + " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        private DataTable LoadSubjects()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmdDSM = new SqlCommand("SP_GetAllSubjects", conn);
                cmdDSM.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdDSM);
                dataAdapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi + " + ex.Message);
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

        private string LayMaMon(string sql)
        {
            string s = "";
            try
            {

                string test = "select SubjectsID from Subjects where SubjectsName like N'%" + sql + "%'";
                SqlCommand cmdTen = new SqlCommand(sql, conn);
                cmdTen.CommandText = test;
                cmdTen.CommandType = CommandType.Text;

                s = (string)cmdTen.ExecuteScalar();


            }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return s;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdThemL = new SqlCommand("SP_AddResult", conn);

                cmdThemL.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMAL = new SqlParameter("@SubjectsID", LayMaMon(cmbMon.Text));
                cmdThemL.Parameters.Add(paraMAL);

                SqlParameter paraTenL = new SqlParameter("@StudentID", LayMaSV(cmbSV.Text));
                cmdThemL.Parameters.Add(paraTenL);

                SqlParameter paraDiem = new SqlParameter("@Score", txtDiem.Text);
                cmdThemL.Parameters.Add(paraDiem);

                if (cmdThemL.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them Thanh Cong!");
                }
                else
                {
                    MessageBox.Show("Them That Bai!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi + " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dtgKQ.DataSource = LoadResults();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdXoaL = new SqlCommand("SP_DeleteResult", conn);
                cmdXoaL.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMAL = new SqlParameter("@SubjectsID", LayMaMon(cmbMon.Text));
                cmdXoaL.Parameters.Add(paraMAL);

                SqlParameter paraTenL = new SqlParameter("@StudentID", LayMaSV(cmbSV.Text));
                cmdXoaL.Parameters.Add(paraTenL);

                if (cmdXoaL.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them Thanh Cong!");
                }
                else
                {
                    MessageBox.Show("Them That Bai!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi + " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dtgKQ.DataSource = LoadResults();
        }

        private void dtgKQ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            cmbMon.Text = dtgKQ.Rows[dong].Cells[0].Value.ToString();
            cmbSV.Text = dtgKQ.Rows[dong].Cells[1].Value.ToString();
            txtDiem.Text = dtgKQ.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdSuaL = new SqlCommand("SP_UpdateResult", conn);

                cmdSuaL.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMAL = new SqlParameter("@SubjectsID", LayMaMon(cmbMon.Text));
                cmdSuaL.Parameters.Add(paraMAL);

                SqlParameter paraTenL = new SqlParameter("@StudentID", LayMaSV(cmbSV.Text));
                cmdSuaL.Parameters.Add(paraTenL);

                SqlParameter paraDiem = new SqlParameter("@Score", txtDiem.Text);
                cmdSuaL.Parameters.Add(paraDiem);

                if (cmdSuaL.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua Thanh Cong!");
                }
                else
                {
                    MessageBox.Show("Sua That Bai!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi + " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            dtgKQ.DataSource = LoadResults();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cmbSV.SelectedIndex = 1;
            cmbMon.SelectedIndex = 1;
            txtDiem.Text = "";
            dtgKQ.DataSource = LoadResults();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbSV.Text) && !string.IsNullOrWhiteSpace(cmbMon.Text))
            {
                MessageBox.Show("Bạn đã chọn lọc kết quả theo cả sinh viên và môn");
                try
                {
                    conn.Open();
                    SqlCommand cmdLoc = new SqlCommand("SP_FILTERSVMH",conn);
                    cmdLoc.CommandType = CommandType.StoredProcedure;

                    SqlParameter paraMH = new SqlParameter("@SubjectsID",LayMaMon(cmbMon.Text));
                    cmdLoc.Parameters.Add(paraMH);

                    SqlParameter paraSV = new SqlParameter("@StudentID",LayMaSV(cmbSV.Text));
                    cmdLoc.Parameters.Add(paraSV);

                    SqlDataAdapter da = new SqlDataAdapter(cmdLoc);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgKQ.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }else if(!string.IsNullOrWhiteSpace(cmbSV.Text))
            {
                MessageBox.Show("Bạn đã chọn lọc kết quả theo Sinh Viên");
                try
                {
                    conn.Open();
                    SqlCommand cmdLoc = new SqlCommand("SP_FILTERSV", conn);
                    cmdLoc.CommandType = CommandType.StoredProcedure;

                    SqlParameter paraSV = new SqlParameter("@StudentID", LayMaSV(cmbSV.Text));
                    cmdLoc.Parameters.Add(paraSV);

                    SqlDataAdapter da = new SqlDataAdapter(cmdLoc);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgKQ.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else if(!string.IsNullOrWhiteSpace(cmbMon.Text))
            {
                MessageBox.Show("Bạn đã chọn lọc kết quả theo Môn Học");
                try
                {
                    conn.Open();
                    SqlCommand cmdLoc = new SqlCommand("SP_FILTERMH", conn);
                    cmdLoc.CommandType = CommandType.StoredProcedure;

                    SqlParameter paraMH = new SqlParameter("@SubjectsID", LayMaMon(cmbMon.Text));
                    cmdLoc.Parameters.Add(paraMH);

                    SqlDataAdapter da = new SqlDataAdapter(cmdLoc);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgKQ.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Sinh Viên Và Môn Học để có thể lọc dữ liệu!","Nhắc Nhở",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
