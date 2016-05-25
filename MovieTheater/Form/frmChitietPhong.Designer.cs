namespace MovieTheater.Form
{
    partial class frmChitietPhong
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
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbRap = new System.Windows.Forms.ComboBox();
            this.cmbKythuat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSodayghe = new System.Windows.Forms.Label();
            this.lblSohangghe = new System.Windows.Forms.Label();
            this.lbbGiave = new System.Windows.Forms.Label();
            this.lblTenForm = new System.Windows.Forms.Label();
            this.cmbTinhtrang = new System.Windows.Forms.ComboBox();
            this.nudHangghe = new System.Windows.Forms.NumericUpDown();
            this.nudDayghe = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudHangghe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayghe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaphong
            // 
            this.txtMaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaphong.Location = new System.Drawing.Point(245, 96);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(282, 26);
            this.txtMaphong.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Mã phòng";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(398, 369);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 44);
            this.btnHuy.TabIndex = 50;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(275, 369);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 44);
            this.btnThem.TabIndex = 51;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbRap
            // 
            this.cmbRap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRap.FormattingEnabled = true;
            this.cmbRap.Items.AddRange(new object[] {
            "\"-- Chọn định dạng --\"",
            "2D",
            "3D"});
            this.cmbRap.Location = new System.Drawing.Point(245, 313);
            this.cmbRap.Name = "cmbRap";
            this.cmbRap.Size = new System.Drawing.Size(282, 28);
            this.cmbRap.TabIndex = 49;
            // 
            // cmbKythuat
            // 
            this.cmbKythuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKythuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKythuat.FormattingEnabled = true;
            this.cmbKythuat.Items.AddRange(new object[] {
            "2D",
            "3D"});
            this.cmbKythuat.Location = new System.Drawing.Point(245, 269);
            this.cmbKythuat.Name = "cmbKythuat";
            this.cmbKythuat.Size = new System.Drawing.Size(282, 28);
            this.cmbKythuat.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Thuộc Rạp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Kỹ thuật";
            // 
            // lblSodayghe
            // 
            this.lblSodayghe.AutoSize = true;
            this.lblSodayghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSodayghe.Location = new System.Drawing.Point(102, 186);
            this.lblSodayghe.Name = "lblSodayghe";
            this.lblSodayghe.Size = new System.Drawing.Size(89, 20);
            this.lblSodayghe.TabIndex = 42;
            this.lblSodayghe.Text = "Số dãy ghế";
            // 
            // lblSohangghe
            // 
            this.lblSohangghe.AutoSize = true;
            this.lblSohangghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSohangghe.Location = new System.Drawing.Point(102, 141);
            this.lblSohangghe.Name = "lblSohangghe";
            this.lblSohangghe.Size = new System.Drawing.Size(100, 20);
            this.lblSohangghe.TabIndex = 41;
            this.lblSohangghe.Text = "Số hàng ghế";
            // 
            // lbbGiave
            // 
            this.lbbGiave.AutoSize = true;
            this.lbbGiave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbGiave.Location = new System.Drawing.Point(102, 228);
            this.lbbGiave.Name = "lbbGiave";
            this.lbbGiave.Size = new System.Drawing.Size(80, 20);
            this.lbbGiave.TabIndex = 40;
            this.lbbGiave.Text = "Tình trạng";
            // 
            // lblTenForm
            // 
            this.lblTenForm.AutoSize = true;
            this.lblTenForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTenForm.Location = new System.Drawing.Point(48, 18);
            this.lblTenForm.Name = "lblTenForm";
            this.lblTenForm.Size = new System.Drawing.Size(561, 54);
            this.lblTenForm.TabIndex = 39;
            this.lblTenForm.Text = "CHI TIẾT PHÒNG CHIẾU";
            // 
            // cmbTinhtrang
            // 
            this.cmbTinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTinhtrang.FormattingEnabled = true;
            this.cmbTinhtrang.Items.AddRange(new object[] {
            "đang hoạt động",
            "đang sửa chữa"});
            this.cmbTinhtrang.Location = new System.Drawing.Point(245, 224);
            this.cmbTinhtrang.Name = "cmbTinhtrang";
            this.cmbTinhtrang.Size = new System.Drawing.Size(282, 28);
            this.cmbTinhtrang.TabIndex = 54;
            // 
            // nudHangghe
            // 
            this.nudHangghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHangghe.Location = new System.Drawing.Point(245, 137);
            this.nudHangghe.Name = "nudHangghe";
            this.nudHangghe.Size = new System.Drawing.Size(282, 26);
            this.nudHangghe.TabIndex = 55;
            // 
            // nudDayghe
            // 
            this.nudDayghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDayghe.Location = new System.Drawing.Point(245, 182);
            this.nudDayghe.Name = "nudDayghe";
            this.nudDayghe.Size = new System.Drawing.Size(282, 26);
            this.nudDayghe.TabIndex = 56;
            // 
            // frmChitietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(690, 435);
            this.Controls.Add(this.nudDayghe);
            this.Controls.Add(this.nudHangghe);
            this.Controls.Add(this.cmbTinhtrang);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbRap);
            this.Controls.Add(this.cmbKythuat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSodayghe);
            this.Controls.Add(this.lblSohangghe);
            this.Controls.Add(this.lbbGiave);
            this.Controls.Add(this.lblTenForm);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmChitietPhong";
            this.Text = "frmChitietPhong";
            this.Load += new System.EventHandler(this.frmChitietPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHangghe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayghe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbRap;
        private System.Windows.Forms.ComboBox cmbKythuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSodayghe;
        private System.Windows.Forms.Label lblSohangghe;
        private System.Windows.Forms.Label lbbGiave;
        private System.Windows.Forms.Label lblTenForm;
        private System.Windows.Forms.ComboBox cmbTinhtrang;
        private System.Windows.Forms.NumericUpDown nudHangghe;
        private System.Windows.Forms.NumericUpDown nudDayghe;
    }
}