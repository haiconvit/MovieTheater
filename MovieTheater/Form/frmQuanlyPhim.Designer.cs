namespace MovieTheater.Form
{
    partial class frmQuanlyPhim
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimPhim = new System.Windows.Forms.Button();
            this.cmbHangPhim = new System.Windows.Forms.ComboBox();
            this.cmbNuocSX = new System.Windows.Forms.ComboBox();
            this.cbxTheLoai = new System.Windows.Forms.ComboBox();
            this.cbxDinhDang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.dgvQuanlyPhim = new System.Windows.Forms.DataGridView();
            this.colMaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHangphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDinhdang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemBinhChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(723, 570);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 33);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(597, 570);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 33);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl.Location = new System.Drawing.Point(333, 22);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(337, 52);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "QUẢN LÝ PHIM";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnTimPhim);
            this.groupBox2.Controls.Add(this.cmbHangPhim);
            this.groupBox2.Controls.Add(this.cmbNuocSX);
            this.groupBox2.Controls.Add(this.cbxTheLoai);
            this.groupBox2.Controls.Add(this.cbxDinhDang);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(2, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 387);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm phim";
            // 
            // btnTimPhim
            // 
            this.btnTimPhim.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTimPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhim.ForeColor = System.Drawing.Color.Black;
            this.btnTimPhim.Location = new System.Drawing.Point(104, 296);
            this.btnTimPhim.Name = "btnTimPhim";
            this.btnTimPhim.Size = new System.Drawing.Size(75, 31);
            this.btnTimPhim.TabIndex = 3;
            this.btnTimPhim.Text = "Tìm";
            this.btnTimPhim.UseVisualStyleBackColor = true;
            this.btnTimPhim.Click += new System.EventHandler(this.btnTimPhim_Click);
            // 
            // cmbHangPhim
            // 
            this.cmbHangPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHangPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHangPhim.FormattingEnabled = true;
            this.cmbHangPhim.Items.AddRange(new object[] {
            "- Chọn rạp -"});
            this.cmbHangPhim.Location = new System.Drawing.Point(133, 56);
            this.cmbHangPhim.Name = "cmbHangPhim";
            this.cmbHangPhim.Size = new System.Drawing.Size(159, 24);
            this.cmbHangPhim.TabIndex = 0;
            // 
            // cmbNuocSX
            // 
            this.cmbNuocSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNuocSX.FormattingEnabled = true;
            this.cmbNuocSX.Items.AddRange(new object[] {
            "-- Chọn ca chiếu phim --",
            "Ca 1: Bắt đầu từ 09:00",
            "Ca 2: Bắt đầu từ 12:00",
            "Ca 3: Bắt đầu từ 15:00",
            "Ca 4: Bắt đầu từ 18:00",
            "Ca 5: Bắt đầu từ 21:00"});
            this.cmbNuocSX.Location = new System.Drawing.Point(133, 225);
            this.cmbNuocSX.Name = "cmbNuocSX";
            this.cmbNuocSX.Size = new System.Drawing.Size(159, 24);
            this.cmbNuocSX.TabIndex = 0;
            // 
            // cbxTheLoai
            // 
            this.cbxTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTheLoai.FormattingEnabled = true;
            this.cbxTheLoai.Location = new System.Drawing.Point(132, 171);
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
            this.cbxDinhDang.Location = new System.Drawing.Point(133, 113);
            this.cbxDinhDang.Name = "cbxDinhDang";
            this.cbxDinhDang.Size = new System.Drawing.Size(159, 24);
            this.cbxDinhDang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn quốc gia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Chọn thể loại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chọn định dạng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn hãng phim:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nhập tên Phim để tìm kiếm";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(610, 119);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(342, 26);
            this.txtTuKhoa.TabIndex = 43;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // dgvQuanlyPhim
            // 
            this.dgvQuanlyPhim.AllowUserToAddRows = false;
            this.dgvQuanlyPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanlyPhim.BackgroundColor = System.Drawing.Color.Black;
            this.dgvQuanlyPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanlyPhim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuanlyPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlyPhim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhim,
            this.colPhim,
            this.colHangphim,
            this.colNamSX,
            this.colNuocSX,
            this.colDinhdang,
            this.colThoiLuong,
            this.colTheLoai,
            this.colDiemBinhChon});
            this.dgvQuanlyPhim.EnableHeadersVisualStyles = false;
            this.dgvQuanlyPhim.GridColor = System.Drawing.Color.Black;
            this.dgvQuanlyPhim.Location = new System.Drawing.Point(318, 169);
            this.dgvQuanlyPhim.Name = "dgvQuanlyPhim";
            this.dgvQuanlyPhim.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanlyPhim.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuanlyPhim.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvQuanlyPhim.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuanlyPhim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanlyPhim.Size = new System.Drawing.Size(737, 384);
            this.dgvQuanlyPhim.TabIndex = 45;
            // 
            // colMaPhim
            // 
            this.colMaPhim.FillWeight = 50F;
            this.colMaPhim.HeaderText = "Mã";
            this.colMaPhim.Name = "colMaPhim";
            this.colMaPhim.ReadOnly = true;
            // 
            // colPhim
            // 
            this.colPhim.FillWeight = 200F;
            this.colPhim.HeaderText = "Tên phim";
            this.colPhim.Name = "colPhim";
            this.colPhim.ReadOnly = true;
            // 
            // colHangphim
            // 
            this.colHangphim.HeaderText = "Hãng phim";
            this.colHangphim.Name = "colHangphim";
            this.colHangphim.ReadOnly = true;
            // 
            // colNamSX
            // 
            this.colNamSX.FillWeight = 50F;
            this.colNamSX.HeaderText = "Năm SX";
            this.colNamSX.Name = "colNamSX";
            this.colNamSX.ReadOnly = true;
            // 
            // colNuocSX
            // 
            this.colNuocSX.FillWeight = 80F;
            this.colNuocSX.HeaderText = "Quốc gia";
            this.colNuocSX.Name = "colNuocSX";
            this.colNuocSX.ReadOnly = true;
            // 
            // colDinhdang
            // 
            this.colDinhdang.FillWeight = 70F;
            this.colDinhdang.HeaderText = "Định dạng";
            this.colDinhdang.Name = "colDinhdang";
            this.colDinhdang.ReadOnly = true;
            // 
            // colThoiLuong
            // 
            this.colThoiLuong.FillWeight = 70F;
            this.colThoiLuong.HeaderText = "Thời lượng";
            this.colThoiLuong.Name = "colThoiLuong";
            this.colThoiLuong.ReadOnly = true;
            // 
            // colTheLoai
            // 
            this.colTheLoai.HeaderText = "Thể loại";
            this.colTheLoai.Name = "colTheLoai";
            this.colTheLoai.ReadOnly = true;
            // 
            // colDiemBinhChon
            // 
            this.colDiemBinhChon.FillWeight = 70F;
            this.colDiemBinhChon.HeaderText = "Điểm bình chọn";
            this.colDiemBinhChon.Name = "colDiemBinhChon";
            this.colDiemBinhChon.ReadOnly = true;
            // 
            // frmQuanlyPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1056, 615);
            this.Controls.Add(this.dgvQuanlyPhim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmQuanlyPhim";
            this.Text = "frmQuanlyPhim";
            this.Load += new System.EventHandler(this.frmQuanlyPhim_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimPhim;
        private System.Windows.Forms.ComboBox cbxTheLoai;
        private System.Windows.Forms.ComboBox cbxDinhDang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.ComboBox cmbNuocSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuanlyPhim;
        private System.Windows.Forms.ComboBox cmbHangPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHangphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNuocSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDinhdang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemBinhChon;
    }
}