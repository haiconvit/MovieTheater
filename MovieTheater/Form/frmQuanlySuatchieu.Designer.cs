namespace MovieTheater.Form
{
    partial class frmQuanlySuatchieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuanlySuatchieu = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbNgaychieu = new System.Windows.Forms.CheckBox();
            this.btnTimSuatChieu = new System.Windows.Forms.Button();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.cbxRap = new System.Windows.Forms.ComboBox();
            this.cbxCaChieu = new System.Windows.Forms.ComboBox();
            this.cbxTheLoai = new System.Windows.Forms.ComboBox();
            this.cbxDinhDang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCachieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaychieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlySuatchieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(572, 575);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 39);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(315, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 52);
            this.label1.TabIndex = 24;
            this.label1.Text = "QUẢN LÝ SUẤT CHIẾU";
            // 
            // dgvQuanlySuatchieu
            // 
            this.dgvQuanlySuatchieu.AllowUserToAddRows = false;
            this.dgvQuanlySuatchieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanlySuatchieu.BackgroundColor = System.Drawing.Color.Black;
            this.dgvQuanlySuatchieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanlySuatchieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuanlySuatchieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlySuatchieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colPhong,
            this.colPhim,
            this.colCachieu,
            this.colNgaychieu});
            this.dgvQuanlySuatchieu.EnableHeadersVisualStyles = false;
            this.dgvQuanlySuatchieu.GridColor = System.Drawing.Color.Black;
            this.dgvQuanlySuatchieu.Location = new System.Drawing.Point(333, 151);
            this.dgvQuanlySuatchieu.Name = "dgvQuanlySuatchieu";
            this.dgvQuanlySuatchieu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanlySuatchieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuanlySuatchieu.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQuanlySuatchieu.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuanlySuatchieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanlySuatchieu.Size = new System.Drawing.Size(721, 408);
            this.dgvQuanlySuatchieu.TabIndex = 36;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(726, 575);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 39);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(593, 106);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(262, 26);
            this.txtTuKhoa.TabIndex = 37;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(388, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nhập tên Phim để tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.ckbNgaychieu);
            this.groupBox2.Controls.Add(this.btnTimSuatChieu);
            this.groupBox2.Controls.Add(this.dtpNgayChieu);
            this.groupBox2.Controls.Add(this.cbxRap);
            this.groupBox2.Controls.Add(this.cbxCaChieu);
            this.groupBox2.Controls.Add(this.cbxTheLoai);
            this.groupBox2.Controls.Add(this.cbxDinhDang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(5, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 414);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm suất chiếu:";
            // 
            // ckbNgaychieu
            // 
            this.ckbNgaychieu.AutoSize = true;
            this.ckbNgaychieu.Location = new System.Drawing.Point(7, 103);
            this.ckbNgaychieu.Name = "ckbNgaychieu";
            this.ckbNgaychieu.Size = new System.Drawing.Size(238, 24);
            this.ckbNgaychieu.TabIndex = 4;
            this.ckbNgaychieu.Text = "Cho phép tìm theo ngày chiếu";
            this.ckbNgaychieu.UseVisualStyleBackColor = true;
            this.ckbNgaychieu.CheckedChanged += new System.EventHandler(this.ckbNgaychieu_CheckedChanged);
            // 
            // btnTimSuatChieu
            // 
            this.btnTimSuatChieu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTimSuatChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSuatChieu.ForeColor = System.Drawing.Color.Black;
            this.btnTimSuatChieu.Location = new System.Drawing.Point(105, 346);
            this.btnTimSuatChieu.Name = "btnTimSuatChieu";
            this.btnTimSuatChieu.Size = new System.Drawing.Size(75, 31);
            this.btnTimSuatChieu.TabIndex = 3;
            this.btnTimSuatChieu.Text = "Tìm";
            this.btnTimSuatChieu.UseVisualStyleBackColor = true;
            this.btnTimSuatChieu.Click += new System.EventHandler(this.btnTimSuatChieu_Click);
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChieu.Location = new System.Drawing.Point(134, 141);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(159, 23);
            this.dtpNgayChieu.TabIndex = 2;
            // 
            // cbxRap
            // 
            this.cbxRap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRap.FormattingEnabled = true;
            this.cbxRap.Items.AddRange(new object[] {
            "- Chọn rạp -"});
            this.cbxRap.Location = new System.Drawing.Point(134, 52);
            this.cbxRap.Name = "cbxRap";
            this.cbxRap.Size = new System.Drawing.Size(159, 24);
            this.cbxRap.TabIndex = 0;
            // 
            // cbxCaChieu
            // 
            this.cbxCaChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCaChieu.FormattingEnabled = true;
            this.cbxCaChieu.Items.AddRange(new object[] {
            "-- Chọn ca chiếu phim --",
            "Ca 1: Bắt đầu từ 09:00",
            "Ca 2: Bắt đầu từ 12:00",
            "Ca 3: Bắt đầu từ 15:00",
            "Ca 4: Bắt đầu từ 18:00",
            "Ca 5: Bắt đầu từ 21:00"});
            this.cbxCaChieu.Location = new System.Drawing.Point(134, 281);
            this.cbxCaChieu.Name = "cbxCaChieu";
            this.cbxCaChieu.Size = new System.Drawing.Size(159, 24);
            this.cbxCaChieu.TabIndex = 0;
            // 
            // cbxTheLoai
            // 
            this.cbxTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTheLoai.FormattingEnabled = true;
            this.cbxTheLoai.Location = new System.Drawing.Point(134, 234);
            this.cbxTheLoai.Name = "cbxTheLoai";
            this.cbxTheLoai.Size = new System.Drawing.Size(159, 24);
            this.cbxTheLoai.TabIndex = 0;
            // 
            // cbxDinhDang
            // 
            this.cbxDinhDang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDinhDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDinhDang.FormattingEnabled = true;
            this.cbxDinhDang.Items.AddRange(new object[] {
            "-- Chọn định dạng --",
            "2D",
            "3D"});
            this.cbxDinhDang.Location = new System.Drawing.Point(134, 188);
            this.cbxDinhDang.Name = "cbxDinhDang";
            this.cbxDinhDang.Size = new System.Drawing.Size(159, 24);
            this.cbxDinhDang.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chọn ngày chiếu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Chọn thể loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chọn ca chiếu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chọn định dạng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chọn rạp:";
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "MaSuatChieu";
            this.colMa.FillWeight = 50F;
            this.colMa.HeaderText = "Mã";
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            // 
            // colPhong
            // 
            this.colPhong.DataPropertyName = "Phong";
            this.colPhong.FillWeight = 50F;
            this.colPhong.HeaderText = "Phòng chiếu";
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            // 
            // colPhim
            // 
            this.colPhim.DataPropertyName = "TenPhim";
            this.colPhim.FillWeight = 200F;
            this.colPhim.HeaderText = "Tên phim";
            this.colPhim.Name = "colPhim";
            this.colPhim.ReadOnly = true;
            // 
            // colCachieu
            // 
            this.colCachieu.DataPropertyName = "CaChieu";
            this.colCachieu.FillWeight = 50F;
            this.colCachieu.HeaderText = "Ca chiếu";
            this.colCachieu.Name = "colCachieu";
            this.colCachieu.ReadOnly = true;
            // 
            // colNgaychieu
            // 
            this.colNgaychieu.DataPropertyName = "NgayChieu";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.colNgaychieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNgaychieu.FillWeight = 80F;
            this.colNgaychieu.HeaderText = "Ngày chiếu";
            this.colNgaychieu.Name = "colNgaychieu";
            this.colNgaychieu.ReadOnly = true;
            // 
            // frmQuanlySuatchieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1056, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.dgvQuanlySuatchieu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanlySuatchieu";
            this.Text = "frmQuanlySuatchieu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanlySuatchieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlySuatchieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuanlySuatchieu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimSuatChieu;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.ComboBox cbxRap;
        private System.Windows.Forms.ComboBox cbxCaChieu;
        private System.Windows.Forms.ComboBox cbxTheLoai;
        private System.Windows.Forms.ComboBox cbxDinhDang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbNgaychieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCachieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaychieu;
    }
}