namespace DoAnLTUD
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btnInDS = new System.Windows.Forms.Button();
            this.rdoMaSV = new System.Windows.Forms.RadioButton();
            this.rdoTenSV = new System.Windows.Forms.RadioButton();
            this.rdoLop = new System.Windows.Forms.RadioButton();
            this.rdoTenGiaiThuong = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(309, 124);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(282, 22);
            this.txtTim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ SINH VIÊN KHEN THƯỞNG";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 228);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(1028, 270);
            this.dgvSinhVien.TabIndex = 2;
            // 
            // btnInDS
            // 
            this.btnInDS.Location = new System.Drawing.Point(765, 199);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(251, 23);
            this.btnInDS.TabIndex = 3;
            this.btnInDS.Text = "In Danh Sách";
            this.btnInDS.UseVisualStyleBackColor = true;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // rdoMaSV
            // 
            this.rdoMaSV.AutoSize = true;
            this.rdoMaSV.Location = new System.Drawing.Point(312, 83);
            this.rdoMaSV.Name = "rdoMaSV";
            this.rdoMaSV.Size = new System.Drawing.Size(106, 20);
            this.rdoMaSV.TabIndex = 4;
            this.rdoMaSV.TabStop = true;
            this.rdoMaSV.Text = "Mã Sinh Viên";
            this.rdoMaSV.UseVisualStyleBackColor = true;
            // 
            // rdoTenSV
            // 
            this.rdoTenSV.AutoSize = true;
            this.rdoTenSV.Location = new System.Drawing.Point(424, 83);
            this.rdoTenSV.Name = "rdoTenSV";
            this.rdoTenSV.Size = new System.Drawing.Size(111, 20);
            this.rdoTenSV.TabIndex = 5;
            this.rdoTenSV.TabStop = true;
            this.rdoTenSV.Text = "Tên Sinh Viên";
            this.rdoTenSV.UseVisualStyleBackColor = true;
            // 
            // rdoLop
            // 
            this.rdoLop.AutoSize = true;
            this.rdoLop.Location = new System.Drawing.Point(538, 83);
            this.rdoLop.Name = "rdoLop";
            this.rdoLop.Size = new System.Drawing.Size(51, 20);
            this.rdoLop.TabIndex = 6;
            this.rdoLop.TabStop = true;
            this.rdoLop.Text = "Lớp";
            this.rdoLop.UseVisualStyleBackColor = true;
            // 
            // rdoTenGiaiThuong
            // 
            this.rdoTenGiaiThuong.AutoSize = true;
            this.rdoTenGiaiThuong.Location = new System.Drawing.Point(598, 83);
            this.rdoTenGiaiThuong.Name = "rdoTenGiaiThuong";
            this.rdoTenGiaiThuong.Size = new System.Drawing.Size(150, 20);
            this.rdoTenGiaiThuong.TabIndex = 7;
            this.rdoTenGiaiThuong.TabStop = true;
            this.rdoTenGiaiThuong.Text = "Mã Khen Thưởng SV";
            this.rdoTenGiaiThuong.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tìm Sinh Viên:";
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(598, 169);
            this.btnTiepTuc.Margin = new System.Windows.Forms.Padding(4);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(125, 41);
            this.btnTiepTuc.TabIndex = 10;
            this.btnTiepTuc.Text = "Tiep Tuc";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(598, 121);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(125, 41);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tim SV";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(13, 9);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 32);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 498);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdoTenGiaiThuong);
            this.Controls.Add(this.rdoLop);
            this.Controls.Add(this.rdoTenSV);
            this.Controls.Add(this.rdoMaSV);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTim);
            this.Name = "frmThongKe";
            this.Text = "Thống kê khen thưởng";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.RadioButton rdoMaSV;
        private System.Windows.Forms.RadioButton rdoTenSV;
        private System.Windows.Forms.RadioButton rdoLop;
        private System.Windows.Forms.RadioButton rdoTenGiaiThuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
    }
}