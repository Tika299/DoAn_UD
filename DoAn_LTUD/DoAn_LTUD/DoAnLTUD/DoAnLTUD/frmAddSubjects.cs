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
    public partial class frmAddSubjects : Form
    {
        public frmAddSubjects()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IQ0GJ6P;Initial Catalog=QUANLYKHENTHUONG;Integrated Security=True;Encrypt=False");

        private void frmAddSubjects_Load(object sender, EventArgs e)
        {
            dtgMon.DataSource = LoadSubjects();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdThemL = new SqlCommand("SP_AddSubject", conn);

                cmdThemL.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMAL = new SqlParameter("@Class", txtMaMon.Text);
                cmdThemL.Parameters.Add(paraMAL);

                SqlParameter paraTenL = new SqlParameter("@ClassName", txtTenMon.Text);
                cmdThemL.Parameters.Add(paraTenL);

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
            dtgMon.DataSource = LoadSubjects();
        }

        private void dtgLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaMon.Text = dtgMon.Rows[dong].Cells[0].Value.ToString();
            txtTenMon.Text = dtgMon.Rows[dong].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdXoaL = new SqlCommand("SP_DeleteClass", conn);
                cmdXoaL.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMa = new SqlParameter("@Class", txtMaMon.Text);
                cmdXoaL.Parameters.Add(paraMa);

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
            dtgMon.DataSource = LoadSubjects();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdSuaL = new SqlCommand("SP_UpdateClass", conn);

                cmdSuaL.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMAL = new SqlParameter("@Class", txtMaMon.Text);
                cmdSuaL.Parameters.Add(paraMAL);

                SqlParameter paraTenL = new SqlParameter("@ClassName", txtTenMon.Text);
                cmdSuaL.Parameters.Add(paraTenL);

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
            dtgMon.DataSource = LoadSubjects();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtMaMon.Focus();
            dtgMon.DataSource = LoadSubjects();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                string st = rdoMa.Checked == true ? "SP_TimClassMa" : "SP_TimClassTen";

                SqlCommand cmdTim = new SqlCommand(st, conn);
                cmdTim.CommandType = CommandType.StoredProcedure;

                string Loai = rdoMa.Checked == true ? txtMaMon.Text : txtTenMon.Text;

                SqlParameter para = new SqlParameter("@Class", Loai);
                cmdTim.Parameters.Add(para);

                SqlDataAdapter da = new SqlDataAdapter(cmdTim);

                da.Fill(dt);
                dtgMon.DataSource = dt;

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

    }
}
