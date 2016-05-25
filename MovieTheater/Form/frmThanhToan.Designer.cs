namespace MovieTheater.Form
{
    partial class frmThanhToan
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.clMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiGianDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhToan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenND = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.chkChuaThanhToan = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.Black;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaHD,
            this.clMaVe,
            this.clTenND,
            this.clHoTen,
            this.clThoiGianDat,
            this.clTinhTrang,
            this.clTongTien,
            this.clThanhToan});
            this.dgvHoaDon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 207);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1042, 372);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // clMaHD
            // 
            this.clMaHD.DataPropertyName = "MaHD";
            this.clMaHD.FillWeight = 61.23226F;
            this.clMaHD.HeaderText = "Mã hóa đơn";
            this.clMaHD.Name = "clMaHD";
            // 
            // clMaVe
            // 
            this.clMaVe.DataPropertyName = "MaVe";
            this.clMaVe.FillWeight = 61.23226F;
            this.clMaVe.HeaderText = "Mã vé";
            this.clMaVe.Name = "clMaVe";
            // 
            // clTenND
            // 
            this.clTenND.DataPropertyName = "TenND";
            this.clTenND.FillWeight = 61.23226F;
            this.clTenND.HeaderText = "Tên người dùng";
            this.clTenND.Name = "clTenND";
            // 
            // clHoTen
            // 
            this.clHoTen.DataPropertyName = "HoTen";
            this.clHoTen.FillWeight = 61.23226F;
            this.clHoTen.HeaderText = "Họ tên";
            this.clHoTen.Name = "clHoTen";
            // 
            // clThoiGianDat
            // 
            this.clThoiGianDat.DataPropertyName = "ThoiGianDat";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm";
            this.clThoiGianDat.DefaultCellStyle = dataGridViewCellStyle2;
            this.clThoiGianDat.FillWeight = 61.23226F;
            this.clThoiGianDat.HeaderText = "Thời gian đặt";
            this.clThoiGianDat.Name = "clThoiGianDat";
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.DataPropertyName = "TinhTrang";
            this.clTinhTrang.FillWeight = 61.23226F;
            this.clTinhTrang.HeaderText = "Tình trạng";
            this.clTinhTrang.Name = "clTinhTrang";
            // 
            // clTongTien
            // 
            this.clTongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle3.Format = "0,### vnđ";
            this.clTongTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.clTongTien.FillWeight = 61.23226F;
            this.clTongTien.HeaderText = "Tổng tiền";
            this.clTongTien.Name = "clTongTien";
            // 
            // clThanhToan
            // 
            this.clThanhToan.FillWeight = 30F;
            this.clThanhToan.HeaderText = "Thanh Toán";
            this.clThanhToan.Name = "clThanhToan";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên người dùng:";
            // 
            // txtTenND
            // 
            this.txtTenND.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenND.Location = new System.Drawing.Point(415, 124);
            this.txtTenND.Name = "txtTenND";
            this.txtTenND.Size = new System.Drawing.Size(181, 23);
            this.txtTenND.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(660, 122);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // chkChuaThanhToan
            // 
            this.chkChuaThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkChuaThanhToan.AutoSize = true;
            this.chkChuaThanhToan.Checked = true;
            this.chkChuaThanhToan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChuaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChuaThanhToan.ForeColor = System.Drawing.Color.White;
            this.chkChuaThanhToan.Location = new System.Drawing.Point(327, 157);
            this.chkChuaThanhToan.Name = "chkChuaThanhToan";
            this.chkChuaThanhToan.Size = new System.Drawing.Size(232, 21);
            this.chkChuaThanhToan.TabIndex = 4;
            this.chkChuaThanhToan.Text = "Chỉ tìm hóa đơn chưa thanh toán";
            this.chkChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1042, 579);
            this.Controls.Add(this.chkChuaThanhToan);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTenND);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThanhToan";
            this.Text = "frmThanhToan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenND;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.CheckBox chkChuaThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenND;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiGianDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongTien;
        private System.Windows.Forms.DataGridViewButtonColumn clThanhToan;
    }
}