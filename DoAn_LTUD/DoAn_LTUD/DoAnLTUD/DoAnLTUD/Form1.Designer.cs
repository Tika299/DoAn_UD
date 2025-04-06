namespace DoAnLTUD
{
    partial class Form1
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
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picBSV = new System.Windows.Forms.PictureBox();
            this.dtpBir = new System.Windows.Forms.DateTimePicker();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgSV = new System.Windows.Forms.DataGridView();
            this.rdioNu = new System.Windows.Forms.RadioButton();
            this.rdioNam = new System.Windows.Forms.RadioButton();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(626, 206);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(75, 23);
            this.btnChonAnh.TabIndex = 76;
            this.btnChonAnh.Text = "Chọn Ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picBSV
            // 
            this.picBSV.Location = new System.Drawing.Point(580, 10);
            this.picBSV.Name = "picBSV";
            this.picBSV.Size = new System.Drawing.Size(163, 167);
            this.picBSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBSV.TabIndex = 75;
            this.picBSV.TabStop = false;
            // 
            // dtpBir
            // 
            this.dtpBir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBir.Location = new System.Drawing.Point(140, 154);
            this.dtpBir.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBir.Name = "dtpBir";
            this.dtpBir.Size = new System.Drawing.Size(265, 22);
            this.dtpBir.TabIndex = 74;
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(140, 210);
            this.cmbLop.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(265, 24);
            this.cmbLop.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(16, 213);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 72;
            this.label10.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(16, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Họ Và Tên SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Mã SV";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLamMoi.Location = new System.Drawing.Point(626, 281);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(117, 48);
            this.btnLamMoi.TabIndex = 67;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(490, 281);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 48);
            this.btnThoat.TabIndex = 66;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(351, 281);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 48);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(214, 281);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 48);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(77, 281);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 48);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgSV
            // 
            this.dtgSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgSV.Location = new System.Drawing.Point(0, 359);
            this.dtgSV.Margin = new System.Windows.Forms.Padding(4);
            this.dtgSV.Name = "dtgSV";
            this.dtgSV.RowHeadersWidth = 51;
            this.dtgSV.Size = new System.Drawing.Size(799, 185);
            this.dtgSV.TabIndex = 62;
            this.dtgSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSV_CellClick);
            // 
            // rdioNu
            // 
            this.rdioNu.AutoSize = true;
            this.rdioNu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdioNu.Location = new System.Drawing.Point(275, 101);
            this.rdioNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdioNu.Name = "rdioNu";
            this.rdioNu.Size = new System.Drawing.Size(45, 20);
            this.rdioNu.TabIndex = 61;
            this.rdioNu.Text = "Nữ";
            this.rdioNu.UseVisualStyleBackColor = true;
            // 
            // rdioNam
            // 
            this.rdioNam.AutoSize = true;
            this.rdioNam.Checked = true;
            this.rdioNam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdioNam.Location = new System.Drawing.Point(140, 101);
            this.rdioNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdioNam.Name = "rdioNam";
            this.rdioNam.Size = new System.Drawing.Size(57, 20);
            this.rdioNam.TabIndex = 60;
            this.rdioNam.TabStop = true;
            this.rdioNam.Text = "Nam";
            this.rdioNam.UseVisualStyleBackColor = true;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(140, 51);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(265, 22);
            this.txtHoVaTen.TabIndex = 59;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(140, 6);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(265, 22);
            this.txtMaSV.TabIndex = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 544);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.picBSV);
            this.Controls.Add(this.dtpBir);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgSV);
            this.Controls.Add(this.rdioNu);
            this.Controls.Add(this.rdioNam);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.txtMaSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.PictureBox picBSV;
        private System.Windows.Forms.DateTimePicker dtpBir;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgSV;
        private System.Windows.Forms.RadioButton rdioNu;
        private System.Windows.Forms.RadioButton rdioNam;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtMaSV;
    }
}