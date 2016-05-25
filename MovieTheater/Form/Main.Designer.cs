namespace MovieTheater.Form
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbDangKy = new System.Windows.Forms.LinkLabel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbCoppyRight = new System.Windows.Forms.Label();
            this.llbLienHe = new System.Windows.Forms.LinkLabel();
            this.btnTimSuatChieu = new System.Windows.Forms.Button();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.cbxRap = new System.Windows.Forms.ComboBox();
            this.cbxCaChieu = new System.Windows.Forms.ComboBox();
            this.cbxTheLoai = new System.Windows.Forms.ComboBox();
            this.cbxDinhDang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimTheoTuKhoa = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "HKT Cinema";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.llbDangKy);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtTenTaiKhoan);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.lbMatKhau);
            this.panel1.Controls.Add(this.lbTaiKhoan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 73);
            this.panel1.TabIndex = 1;
            // 
            // llbDangKy
            // 
            this.llbDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbDangKy.AutoSize = true;
            this.llbDangKy.LinkColor = System.Drawing.Color.White;
            this.llbDangKy.Location = new System.Drawing.Point(1007, 48);
            this.llbDangKy.Name = "llbDangKy";
            this.llbDangKy.Size = new System.Drawing.Size(94, 13);
            this.llbDangKy.TabIndex = 4;
            this.llbDangKy.TabStop = true;
            this.llbDangKy.Text = "Đăng ký tài khoản";
            this.llbDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDangKy_LinkClicked);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.Location = new System.Drawing.Point(1138, 25);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(123, 20);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(1010, 25);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(122, 20);
            this.txtTenTaiKhoan.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangNhap.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangNhap.Location = new System.Drawing.Point(1275, 23);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.ForeColor = System.Drawing.Color.White;
            this.lbMatKhau.Location = new System.Drawing.Point(1135, 9);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(55, 13);
            this.lbMatKhau.TabIndex = 1;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lbTaiKhoan.Location = new System.Drawing.Point(1007, 9);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(58, 13);
            this.lbTaiKhoan.TabIndex = 1;
            this.lbTaiKhoan.Text = "Tài khoản:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 73);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Click += new System.EventHandler(this.splitContainer1_Panel2_Click);
            this.splitContainer1.Panel2MinSize = 1058;
            this.splitContainer1.Size = new System.Drawing.Size(1362, 668);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.btnTimSuatChieu);
            this.groupBox2.Controls.Add(this.dtpNgayChieu);
            this.groupBox2.Controls.Add(this.cbxRap);
            this.groupBox2.Controls.Add(this.cbxCaChieu);
            this.groupBox2.Controls.Add(this.cbxTheLoai);
            this.groupBox2.Controls.Add(this.cbxDinhDang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(0, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 538);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm suất chiếu:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbCoppyRight);
            this.panel3.Controls.Add(this.llbLienHe);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 452);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 83);
            this.panel3.TabIndex = 5;
            // 
            // lbCoppyRight
            // 
            this.lbCoppyRight.AllowDrop = true;
            this.lbCoppyRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCoppyRight.AutoSize = true;
            this.lbCoppyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoppyRight.ForeColor = System.Drawing.Color.Orange;
            this.lbCoppyRight.Location = new System.Drawing.Point(5, 0);
            this.lbCoppyRight.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbCoppyRight.Name = "lbCoppyRight";
            this.lbCoppyRight.Size = new System.Drawing.Size(63, 15);
            this.lbCoppyRight.TabIndex = 8;
            this.lbCoppyRight.Text = "CopyRight";
            // 
            // llbLienHe
            // 
            this.llbLienHe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llbLienHe.AutoSize = true;
            this.llbLienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLienHe.LinkColor = System.Drawing.Color.Orange;
            this.llbLienHe.Location = new System.Drawing.Point(5, 60);
            this.llbLienHe.Name = "llbLienHe";
            this.llbLienHe.Size = new System.Drawing.Size(75, 17);
            this.llbLienHe.TabIndex = 0;
            this.llbLienHe.TabStop = true;
            this.llbLienHe.Text = "Liên hệ.....";
            this.llbLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLienHe_LinkClicked);
            // 
            // btnTimSuatChieu
            // 
            this.btnTimSuatChieu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTimSuatChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSuatChieu.ForeColor = System.Drawing.Color.Black;
            this.btnTimSuatChieu.Location = new System.Drawing.Point(104, 288);
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
            this.dtpNgayChieu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChieu.Location = new System.Drawing.Point(133, 77);
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
            this.cbxRap.Location = new System.Drawing.Point(133, 30);
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
            this.cbxCaChieu.Location = new System.Drawing.Point(133, 218);
            this.cbxCaChieu.Name = "cbxCaChieu";
            this.cbxCaChieu.Size = new System.Drawing.Size(159, 24);
            this.cbxCaChieu.TabIndex = 0;
            // 
            // cbxTheLoai
            // 
            this.cbxTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTheLoai.FormattingEnabled = true;
            this.cbxTheLoai.Location = new System.Drawing.Point(133, 171);
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
            this.cbxDinhDang.Location = new System.Drawing.Point(133, 122);
            this.cbxDinhDang.Name = "cbxDinhDang";
            this.cbxDinhDang.Size = new System.Drawing.Size(159, 24);
            this.cbxDinhDang.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 81);
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
            this.label9.Location = new System.Drawing.Point(8, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Chọn thể loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn ca chiếu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chọn định dạng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chọn rạp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimTheoTuKhoa);
            this.groupBox1.Controls.Add(this.txtTuKhoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm phim:";
            // 
            // btnTimTheoTuKhoa
            // 
            this.btnTimTheoTuKhoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTimTheoTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoTuKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnTimTheoTuKhoa.Location = new System.Drawing.Point(104, 77);
            this.btnTimTheoTuKhoa.Name = "btnTimTheoTuKhoa";
            this.btnTimTheoTuKhoa.Size = new System.Drawing.Size(75, 28);
            this.btnTimTheoTuKhoa.TabIndex = 3;
            this.btnTimTheoTuKhoa.Text = "Tìm kiếm";
            this.btnTimTheoTuKhoa.UseVisualStyleBackColor = true;
            this.btnTimTheoTuKhoa.Click += new System.EventHandler(this.btnTimTheoTuKhoa_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(107, 35);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(183, 23);
            this.txtTuKhoa.TabIndex = 2;
            this.txtTuKhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTuKhoa_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nhập tên phim:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Hệ thống rạp chiếu phim HKT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llbDangKy;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimSuatChieu;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.ComboBox cbxRap;
        private System.Windows.Forms.ComboBox cbxTheLoai;
        private System.Windows.Forms.ComboBox cbxDinhDang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimTheoTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.ComboBox cbxCaChieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel llbLienHe;
        private System.Windows.Forms.Label lbCoppyRight;
    }
}

