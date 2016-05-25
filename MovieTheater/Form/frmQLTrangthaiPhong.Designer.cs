namespace MovieTheater.Form
{
    partial class frmQLTrangthaiPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPhongchieu = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSohangghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSodayghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKyThuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimPhongchieu = new System.Windows.Forms.Button();
            this.cmbTinhtrangphong = new System.Windows.Forms.ComboBox();
            this.cmbDinhDang = new System.Windows.Forms.ComboBox();
            this.cmbRap = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongchieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhongchieu
            // 
            this.dgvPhongchieu.AllowUserToAddRows = false;
            this.dgvPhongchieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongchieu.BackgroundColor = System.Drawing.Color.Black;
            this.dgvPhongchieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongchieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhongchieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongchieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colSohangghe,
            this.colSodayghe,
            this.colTinhtrang,
            this.colKyThuat,
            this.colTenRap});
            this.dgvPhongchieu.EnableHeadersVisualStyles = false;
            this.dgvPhongchieu.Location = new System.Drawing.Point(341, 151);
            this.dgvPhongchieu.Name = "dgvPhongchieu";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongchieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhongchieu.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhongchieu.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhongchieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongchieu.Size = new System.Drawing.Size(712, 407);
            this.dgvPhongchieu.TabIndex = 0;
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã phòng";
            this.colMa.Name = "colMa";
            // 
            // colSohangghe
            // 
            this.colSohangghe.FillWeight = 80F;
            this.colSohangghe.HeaderText = "Số hàng ghế";
            this.colSohangghe.Name = "colSohangghe";
            // 
            // colSodayghe
            // 
            this.colSodayghe.FillWeight = 70F;
            this.colSodayghe.HeaderText = "Số dãy ghế";
            this.colSodayghe.Name = "colSodayghe";
            // 
            // colTinhtrang
            // 
            this.colTinhtrang.HeaderText = "Tình Trạng";
            this.colTinhtrang.Name = "colTinhtrang";
            // 
            // colKyThuat
            // 
            this.colKyThuat.HeaderText = "Kỹ thuật";
            this.colKyThuat.Name = "colKyThuat";
            // 
            // colTenRap
            // 
            this.colTenRap.FillWeight = 130F;
            this.colTenRap.HeaderText = "Rạp";
            this.colTenRap.Name = "colTenRap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(306, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ PHÒNG CHIẾU";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(660, 564);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 39);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(531, 564);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 39);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(388, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nhập tên Rạp để tìm kiếm";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(620, 105);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(342, 26);
            this.txtTuKhoa.TabIndex = 46;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // btnTimPhongchieu
            // 
            this.btnTimPhongchieu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTimPhongchieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhongchieu.ForeColor = System.Drawing.Color.Black;
            this.btnTimPhongchieu.Location = new System.Drawing.Point(100, 261);
            this.btnTimPhongchieu.Name = "btnTimPhongchieu";
            this.btnTimPhongchieu.Size = new System.Drawing.Size(75, 31);
            this.btnTimPhongchieu.TabIndex = 3;
            this.btnTimPhongchieu.Text = "Tìm";
            this.btnTimPhongchieu.UseVisualStyleBackColor = true;
            this.btnTimPhongchieu.Click += new System.EventHandler(this.btnTimPhongchieu_Click);
            // 
            // cmbTinhtrangphong
            // 
            this.cmbTinhtrangphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTinhtrangphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTinhtrangphong.FormattingEnabled = true;
            this.cmbTinhtrangphong.Items.AddRange(new object[] {
            "-- Chọn tình trạng phòng --",
            "đang hoạt động",
            "đang sửa chữa"});
            this.cmbTinhtrangphong.Location = new System.Drawing.Point(133, 60);
            this.cmbTinhtrangphong.Name = "cmbTinhtrangphong";
            this.cmbTinhtrangphong.Size = new System.Drawing.Size(177, 24);
            this.cmbTinhtrangphong.TabIndex = 0;
            // 
            // cmbDinhDang
            // 
            this.cmbDinhDang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDinhDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDinhDang.FormattingEnabled = true;
            this.cmbDinhDang.Items.AddRange(new object[] {
            "-- Chọn định dạng --",
            "2D",
            "3D"});
            this.cmbDinhDang.Location = new System.Drawing.Point(132, 175);
            this.cmbDinhDang.Name = "cmbDinhDang";
            this.cmbDinhDang.Size = new System.Drawing.Size(178, 24);
            this.cmbDinhDang.TabIndex = 0;
            // 
            // cmbRap
            // 
            this.cmbRap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRap.FormattingEnabled = true;
            this.cmbRap.Items.AddRange(new object[] {
            "-- Chọn định dạng --",
            "2D",
            "3D"});
            this.cmbRap.Location = new System.Drawing.Point(133, 117);
            this.cmbRap.Name = "cmbRap";
            this.cmbRap.Size = new System.Drawing.Size(177, 24);
            this.cmbRap.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Chọn định dạng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Rạp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tình trạng phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnTimPhongchieu);
            this.groupBox2.Controls.Add(this.cmbTinhtrangphong);
            this.groupBox2.Controls.Add(this.cmbDinhDang);
            this.groupBox2.Controls.Add(this.cmbRap);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(1, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 410);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm phòng chiếu";
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
            // frmQLTrangthaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1056, 615);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhongchieu);
            this.Name = "frmQLTrangthaiPhong";
            this.Text = "frmQLTrangthaiPhong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLTrangthaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongchieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongchieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimPhongchieu;
        private System.Windows.Forms.ComboBox cmbTinhtrangphong;
        private System.Windows.Forms.ComboBox cmbDinhDang;
        private System.Windows.Forms.ComboBox cmbRap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSohangghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSodayghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKyThuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenRap;
    }
}