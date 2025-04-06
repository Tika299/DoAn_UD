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
    public partial class FormAddClass : Form
    {
        public FormAddClass()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IQ0GJ6P;Initial Catalog=QUANLYKHENTHUONG;Integrated Security=True;Encrypt=False");

        private DataTable LoadClass()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmdDSL = new SqlCommand("SP_GetAllClass", conn);
                cmdDSL.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdDSL);
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

        private void FormAddClass_Load(object sender, EventArgs e)
        {
            dtgLop.DataSource = LoadClass();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdThemL = new SqlCommand("SP_AddClass", conn);

                cmdThemL.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMAL = new SqlParameter("@Class", txtMaLop.Text);
                cmdThemL.Parameters.Add(paraMAL);

                SqlParameter paraTenL = new SqlParameter("@ClassName", txtTenLop.Text);
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
            dtgLop.DataSource = LoadClass();
        }

        private void dtgLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaLop.Text = dtgLop.Rows[dong].Cells[0].Value.ToString();
            txtTenLop.Text = dtgLop.Rows[dong].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdXoaL = new SqlCommand("SP_DeleteClass", conn);
                cmdXoaL.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMa = new SqlParameter("@Class", txtMaLop.Text);
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
            dtgLop.DataSource = LoadClass();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmdSuaL = new SqlCommand("SP_UpdateClass", conn);

                cmdSuaL.CommandType = CommandType.StoredProcedure;

                SqlParameter paraMAL = new SqlParameter("@Class", txtMaLop.Text);
                cmdSuaL.Parameters.Add(paraMAL);

                SqlParameter paraTenL = new SqlParameter("@ClassName", txtTenLop.Text);
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
            dtgLop.DataSource = LoadClass();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMaLop.Focus();
            dtgLop.DataSource = LoadClass();
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

                string Loai = rdoMa.Checked == true ? txtMaLop.Text : txtTenLop.Text;

                SqlParameter para = new SqlParameter("@Class", Loai);
                cmdTim.Parameters.Add(para);

                SqlDataAdapter da = new SqlDataAdapter(cmdTim);

                da.Fill(dt);
                dtgLop.DataSource = dt;

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
