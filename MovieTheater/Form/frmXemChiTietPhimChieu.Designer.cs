namespace MovieTheater.Form
{
    partial class frmXemChiTietPhimChieu
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
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.btnBinhChon = new System.Windows.Forms.Button();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.lbTenPhim = new System.Windows.Forms.Label();
            this.lbHangSX = new System.Windows.Forms.Label();
            this.lbNuocSX = new System.Windows.Forms.Label();
            this.lbDinhDang = new System.Windows.Forms.Label();
            this.lbThoiLuong = new System.Windows.Forms.Label();
            this.lbGioiThieu = new System.Windows.Forms.Label();
            this.txtGioiThieu = new System.Windows.Forms.TextBox();
            this.lbCacDienVien = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnCacCaChieu = new System.Windows.Forms.Panel();
            this.cbxDiem = new System.Windows.Forms.ComboBox();
            this.lbDiem = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.LinkLabel();
            this.lbDiemTB = new System.Windows.Forms.Label();
            this.btnTrailer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBinhChon
            // 
            this.btnBinhChon.BackColor = System.Drawing.Color.Green;
            this.btnBinhChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBinhChon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBinhChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinhChon.ForeColor = System.Drawing.Color.White;
            this.btnBinhChon.Location = new System.Drawing.Point(785, 445);
            this.btnBinhChon.Name = "btnBinhChon";
            this.btnBinhChon.Size = new System.Drawing.Size(146, 51);
            this.btnBinhChon.TabIndex = 8;
            this.btnBinhChon.Text = "Bình chọn phim";
            this.tt.SetToolTip(this.btnBinhChon, "Bình chọn điểm mức hay cho phim theo cảm nhận của bạn ");
            this.btnBinhChon.UseVisualStyleBackColor = false;
            this.btnBinhChon.Click += new System.EventHandler(this.btnBinhChon_Click);
            // 
            // pbPoster
            // 
            this.pbPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPoster.Location = new System.Drawing.Point(22, 32);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(400, 560);
            this.pbPoster.TabIndex = 2;
            this.pbPoster.TabStop = false;
            // 
            // lbTenPhim
            // 
            this.lbTenPhim.AllowDrop = true;
            this.lbTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhim.Location = new System.Drawing.Point(459, 32);
            this.lbTenPhim.Name = "lbTenPhim";
            this.lbTenPhim.Size = new System.Drawing.Size(476, 93);
            this.lbTenPhim.TabIndex = 3;
            this.lbTenPhim.Text = "Tên phim";
            // 
            // lbHangSX
            // 
            this.lbHangSX.AutoSize = true;
            this.lbHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHangSX.ForeColor = System.Drawing.Color.White;
            this.lbHangSX.Location = new System.Drawing.Point(460, 173);
            this.lbHangSX.Name = "lbHangSX";
            this.lbHangSX.Size = new System.Drawing.Size(93, 13);
            this.lbHangSX.TabIndex = 4;
            this.lbHangSX.Text = "Hãng sản xuất:";
            // 
            // lbNuocSX
            // 
            this.lbNuocSX.AutoSize = true;
            this.lbNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNuocSX.ForeColor = System.Drawing.Color.White;
            this.lbNuocSX.Location = new System.Drawing.Point(460, 198);
            this.lbNuocSX.Name = "lbNuocSX";
            this.lbNuocSX.Size = new System.Drawing.Size(93, 13);
            this.lbNuocSX.TabIndex = 4;
            this.lbNuocSX.Text = "Nước sản xuất:";
            // 
            // lbDinhDang
            // 
            this.lbDinhDang.AutoSize = true;
            this.lbDinhDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDinhDang.ForeColor = System.Drawing.Color.White;
            this.lbDinhDang.Location = new System.Drawing.Point(460, 223);
            this.lbDinhDang.Name = "lbDinhDang";
            this.lbDinhDang.Size = new System.Drawing.Size(69, 13);
            this.lbDinhDang.TabIndex = 4;
            this.lbDinhDang.Text = "Định dạng:";
            // 
            // lbThoiLuong
            // 
            this.lbThoiLuong.AutoSize = true;
            this.lbThoiLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiLuong.ForeColor = System.Drawing.Color.White;
            this.lbThoiLuong.Location = new System.Drawing.Point(460, 249);
            this.lbThoiLuong.Name = "lbThoiLuong";
            this.lbThoiLuong.Size = new System.Drawing.Size(71, 13);
            this.lbThoiLuong.TabIndex = 4;
            this.lbThoiLuong.Text = "Thời lượng:";
            // 
            // lbGioiThieu
            // 
            this.lbGioiThieu.AutoSize = true;
            this.lbGioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiThieu.ForeColor = System.Drawing.Color.White;
            this.lbGioiThieu.Location = new System.Drawing.Point(460, 275);
            this.lbGioiThieu.Name = "lbGioiThieu";
            this.lbGioiThieu.Size = new System.Drawing.Size(65, 13);
            this.lbGioiThieu.TabIndex = 4;
            this.lbGioiThieu.Text = "Giới thiệu:";
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.AllowDrop = true;
            this.txtGioiThieu.BackColor = System.Drawing.Color.Black;
            this.txtGioiThieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGioiThieu.ForeColor = System.Drawing.Color.White;
            this.txtGioiThieu.Location = new System.Drawing.Point(466, 299);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.Size = new System.Drawing.Size(469, 59);
            this.txtGioiThieu.TabIndex = 5;
            this.txtGioiThieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbCacDienVien
            // 
            this.lbCacDienVien.AutoSize = true;
            this.lbCacDienVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCacDienVien.ForeColor = System.Drawing.Color.White;
            this.lbCacDienVien.Location = new System.Drawing.Point(460, 361);
            this.lbCacDienVien.Name = "lbCacDienVien";
            this.lbCacDienVien.Size = new System.Drawing.Size(89, 13);
            this.lbCacDienVien.TabIndex = 4;
            this.lbCacDienVien.Text = "Các diễn viên:";
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoSize = true;
            this.lbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheLoai.ForeColor = System.Drawing.Color.White;
            this.lbTheLoai.Location = new System.Drawing.Point(460, 150);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(57, 13);
            this.lbTheLoai.TabIndex = 4;
            this.lbTheLoai.Text = "Thể loại:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnCacCaChieu);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(463, 438);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các ca chiếu";
            // 
            // pnCacCaChieu
            // 
            this.pnCacCaChieu.AutoScroll = true;
            this.pnCacCaChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCacCaChieu.Location = new System.Drawing.Point(3, 16);
            this.pnCacCaChieu.Name = "pnCacCaChieu";
            this.pnCacCaChieu.Size = new System.Drawing.Size(263, 135);
            this.pnCacCaChieu.TabIndex = 0;
            this.pnCacCaChieu.Click += new System.EventHandler(this.pnCacCaChieu_Click);
            // 
            // cbxDiem
            // 
            this.cbxDiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDiem.FormattingEnabled = true;
            this.cbxDiem.Items.AddRange(new object[] {
            "-- Bình chọn --",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxDiem.Location = new System.Drawing.Point(786, 511);
            this.cbxDiem.Name = "cbxDiem";
            this.cbxDiem.Size = new System.Drawing.Size(105, 21);
            this.cbxDiem.TabIndex = 7;
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.White;
            this.lbDiem.Location = new System.Drawing.Point(897, 517);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(35, 13);
            this.lbDiem.TabIndex = 4;
            this.lbDiem.Text = "Điểm";
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Location = new System.Drawing.Point(19, 609);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(92, 13);
            this.lbBack.TabIndex = 9;
            this.lbBack.TabStop = true;
            this.lbBack.Text = "Trở về trang trước";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // lbDiemTB
            // 
            this.lbDiemTB.AutoSize = true;
            this.lbDiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemTB.ForeColor = System.Drawing.Color.White;
            this.lbDiemTB.Location = new System.Drawing.Point(460, 125);
            this.lbDiemTB.Name = "lbDiemTB";
            this.lbDiemTB.Size = new System.Drawing.Size(160, 13);
            this.lbDiemTB.TabIndex = 4;
            this.lbDiemTB.Text = "Điểm bình chọn trung bình:";
            // 
            // btnTrailer
            // 
            this.btnTrailer.Location = new System.Drawing.Point(463, 385);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(97, 23);
            this.btnTrailer.TabIndex = 10;
            this.btnTrailer.Text = "|> Xem trailer...";
            this.btnTrailer.UseVisualStyleBackColor = true;
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            // 
            // frmXemChiTietPhimChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1120, 723);
            this.Controls.Add(this.btnTrailer);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.btnBinhChon);
            this.Controls.Add(this.cbxDiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtGioiThieu);
            this.Controls.Add(this.lbDiemTB);
            this.Controls.Add(this.lbTheLoai);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.lbCacDienVien);
            this.Controls.Add(this.lbGioiThieu);
            this.Controls.Add(this.lbThoiLuong);
            this.Controls.Add(this.lbDinhDang);
            this.Controls.Add(this.lbNuocSX);
            this.Controls.Add(this.lbHangSX);
            this.Controls.Add(this.lbTenPhim);
            this.Controls.Add(this.pbPoster);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXemChiTietPhimChieu";
            this.Text = "Hệ thống rạp chiếu phim HKT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXemChiTietPhimChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Label lbTenPhim;
        private System.Windows.Forms.Label lbHangSX;
        private System.Windows.Forms.Label lbNuocSX;
        private System.Windows.Forms.Label lbDinhDang;
        private System.Windows.Forms.Label lbThoiLuong;
        private System.Windows.Forms.Label lbGioiThieu;
        private System.Windows.Forms.TextBox txtGioiThieu;
        private System.Windows.Forms.Label lbCacDienVien;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnCacCaChieu;
        private System.Windows.Forms.ComboBox cbxDiem;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Button btnBinhChon;
        private System.Windows.Forms.LinkLabel lbBack;
        private System.Windows.Forms.Label lbDiemTB;
        private System.Windows.Forms.Button btnTrailer;
    }
}