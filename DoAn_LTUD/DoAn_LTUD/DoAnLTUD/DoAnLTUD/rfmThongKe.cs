using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IQ0GJ6P;Initial Catalog=QUANLYKHENTHUONG;Integrated Security=True;Encrypt=False");

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Xác định tiêu chí tìm kiếm dựa trên RadioButton được chọn
            string studentId = null;
            string fullName = null;
            string className = null;
            string awardName = null;

            // Lấy giá trị tìm kiếm từ TextBox txtTim
            string searchValue = txtTim.Text.Trim();

            // Kiểm tra RadioButton nào được chọn
            if (rdoMaSV.Checked) // Tìm theo mã sinh viên
            {
                studentId = searchValue;
            }
            else if (rdoTenSV.Checked) // Tìm theo tên sinh viên
            {
                fullName = searchValue;
            }
            else if (rdoLop.Checked) // Tìm theo lớp
            {
                className = searchValue;
            }
            else if (rdoTenGiaiThuong.Checked) // Tìm theo giải thưởng
            {
                awardName = searchValue;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Load dữ liệu tìm kiếm dựa trên tiêu chí
            dgvSinhVien.DataSource = FindStudentAwards(studentId, fullName, className, awardName);
        }

        public DataTable LoadDuLieuSinhVien()
        {
            DataTable dtSV = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmdSV = new SqlCommand();
                cmdSV.CommandText = "SP_LoadStudentAwards";
                cmdSV.CommandType = CommandType.StoredProcedure;
                cmdSV.Connection = conn;

                SqlDataAdapter daSV = new SqlDataAdapter(cmdSV);
                daSV.Fill(dtSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtSV;
        }

        // Tìm kiếm sinh viên được khen thưởng
        public DataTable FindStudentAwards(string studentId, string fullName, string className, string awardID)
        {
            DataTable dtResults = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_FindStudentAwards", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào command
                cmd.Parameters.AddWithValue("@StudentID", string.IsNullOrEmpty(studentId) ? (object)DBNull.Value : studentId);
                cmd.Parameters.AddWithValue("@FullName", string.IsNullOrEmpty(fullName) ? (object)DBNull.Value : fullName);
                cmd.Parameters.AddWithValue("@ClassName", string.IsNullOrEmpty(className) ? (object)DBNull.Value : className);
                cmd.Parameters.AddWithValue("@AwardID", string.IsNullOrEmpty(awardID) ? (object)DBNull.Value : awardID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtResults);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dtResults;
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = LoadDuLieuSinhVien();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            txtTim.Focus();
            dgvSinhVien.DataSource = LoadDuLieuSinhVien();
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng Crystal Report
            ReportDocument reportDocument = new ReportDocument();

            // Tạo DataTable từ DataGridView (dữ liệu hiện tại của dgvSinhVien)
            DataTable dt = (DataTable)dgvSinhVien.DataSource;

            // Nếu DataTable có dữ liệu, tiếp tục
            if (dt != null && dt.Rows.Count > 0)
            {
                // Load báo cáo Crystal Report (thay đổi đường dẫn tới file .rpt của bạn)
                reportDocument.Load("D:\\DoAn_LTUD\\DoAn_LTUD\\DoAnLTUD\\DoAnLTUD\\rptThongKe.rpt");

                // Đưa dữ liệu vào báo cáo
                reportDocument.SetDataSource(dt);

                // Hiển thị báo cáo trong CrystalReportViewer
                CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
                crystalReportViewer.ReportSource = reportDocument;
                crystalReportViewer.Refresh();

                // Hiển thị form với CrystalReportViewer
                Form reportForm = new Form();
                reportForm.Text = "Danh sách sinh viên được khen thưởng";
                crystalReportViewer.Dock = DockStyle.Fill;
                reportForm.Controls.Add(crystalReportViewer);
                reportForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            form.Show(); 
            this.Close();          
        }
    }
}
