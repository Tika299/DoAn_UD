namespace DoAnLTUD
{
    partial class ThemKhenThuong
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
            this.components = new System.ComponentModel.Container();
            this.rdoMA = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoMon = new System.Windows.Forms.TextBox();
            this.btnXet = new System.Windows.Forms.Button();
            this.txtAVG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThuong = new System.Windows.Forms.DateTimePicker();
            this.cmbThuong = new System.Windows.Forms.ComboBox();
            this.cmbSV = new System.Windows.Forms.ComboBox();
            this.txtMaThuong = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgDSSVThuong = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSSVThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoMA
            // 
            this.rdoMA.AutoSize = true;
            this.rdoMA.Checked = true;
            this.rdoMA.Location = new System.Drawing.Point(325, 85);
            this.rdoMA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMA.Name = "rdoMA";
            this.rdoMA.Size = new System.Drawing.Size(105, 20);
            this.rdoMA.TabIndex = 89;
            this.rdoMA.TabStop = true;
            this.rdoMA.Text = "Tìm Theo Mã";
            this.rdoMA.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 88;
            this.label7.Text = "Kết Quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Enabled = false;
            this.txtKQ.Location = new System.Drawing.Point(583, 201);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(235, 22);
            this.txtKQ.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "Số Môn Đã Học";
            // 
            // txtSoMon
            // 
            this.txtSoMon.Enabled = false;
            this.txtSoMon.Location = new System.Drawing.Point(583, 155);
            this.txtSoMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoMon.Name = "txtSoMon";
            this.txtSoMon.Size = new System.Drawing.Size(235, 22);
            this.txtSoMon.TabIndex = 85;
            // 
            // btnXet
            // 
            this.btnXet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXet.Location = new System.Drawing.Point(643, 231);
            this.btnXet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnXet.Name = "btnXet";
            this.btnXet.Size = new System.Drawing.Size(112, 59);
            this.btnXet.TabIndex = 84;
            this.btnXet.Text = "Xét Thưởng";
            this.btnXet.UseVisualStyleBackColor = true;
            this.btnXet.Click += new System.EventHandler(this.btnXet_Click);
            // 
            // txtAVG
            // 
            this.txtAVG.Enabled = false;
            this.txtAVG.Location = new System.Drawing.Point(583, 112);
            this.txtAVG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAVG.Name = "txtAVG";
            this.txtAVG.Size = new System.Drawing.Size(235, 22);
            this.txtAVG.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Điểm Trung Bình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Ngày Nhận Thưởng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "Loại Thưởng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Sinh Viên Nhận Thưởng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "Mã Thưởng";
            // 
            // dtpThuong
            // 
            this.dtpThuong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThuong.Location = new System.Drawing.Point(221, 251);
            this.dtpThuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpThuong.Name = "dtpThuong";
            this.dtpThuong.Size = new System.Drawing.Size(233, 22);
            this.dtpThuong.TabIndex = 77;
            // 
            // cmbThuong
            // 
            this.cmbThuong.FormattingEnabled = true;
            this.cmbThuong.Location = new System.Drawing.Point(221, 203);
            this.cmbThuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbThuong.Name = "cmbThuong";
            this.cmbThuong.Size = new System.Drawing.Size(233, 24);
            this.cmbThuong.TabIndex = 76;
            // 
            // cmbSV
            // 
            this.cmbSV.FormattingEnabled = true;
            this.cmbSV.Location = new System.Drawing.Point(220, 159);
            this.cmbSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSV.Name = "cmbSV";
            this.cmbSV.Size = new System.Drawing.Size(235, 24);
            this.cmbSV.TabIndex = 75;
            // 
            // txtMaThuong
            // 
            this.txtMaThuong.Location = new System.Drawing.Point(220, 112);
            this.txtMaThuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaThuong.Name = "txtMaThuong";
            this.txtMaThuong.Size = new System.Drawing.Size(235, 22);
            this.txtMaThuong.TabIndex = 74;
            // 
            // btnTim
            // 
            this.btnTim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTim.Location = new System.Drawing.Point(707, 305);
            this.btnTim.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 59);
            this.btnTim.TabIndex = 73;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLamMoi.Location = new System.Drawing.Point(568, 305);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(112, 59);
            this.btnLamMoi.TabIndex = 72;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(432, 305);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 59);
            this.btnThoat.TabIndex = 71;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(295, 305);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 59);
            this.btnSua.TabIndex = 70;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(155, 305);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 59);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(12, 305);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 59);
            this.btnThem.TabIndex = 68;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgDSSVThuong
            // 
            this.dtgDSSVThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSSVThuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDSSVThuong.Location = new System.Drawing.Point(0, 383);
            this.dtgDSSVThuong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtgDSSVThuong.Name = "dtgDSSVThuong";
            this.dtgDSSVThuong.RowHeadersWidth = 51;
            this.dtgDSSVThuong.Size = new System.Drawing.Size(887, 228);
            this.dtgDSSVThuong.TabIndex = 67;
            this.dtgDSSVThuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDSSVThuong_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(308, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(317, 37);
            this.label8.TabIndex = 90;
            this.label8.Text = "Thêm Khen Thưởng";
            // 
            // ThemKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 611);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdoMA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoMon);
            this.Controls.Add(this.btnXet);
            this.Controls.Add(this.txtAVG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpThuong);
            this.Controls.Add(this.cmbThuong);
            this.Controls.Add(this.cmbSV);
            this.Controls.Add(this.txtMaThuong);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgDSSVThuong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemKhenThuong";
            this.Text = "ThemKhenThuong";
            this.Load += new System.EventHandler(this.ThemKhenThuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSSVThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoMA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoMon;
        private System.Windows.Forms.Button btnXet;
        private System.Windows.Forms.TextBox txtAVG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThuong;
        private System.Windows.Forms.ComboBox cmbThuong;
        private System.Windows.Forms.ComboBox cmbSV;
        private System.Windows.Forms.TextBox txtMaThuong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgDSSVThuong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
    }
}