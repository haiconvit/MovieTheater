namespace MovieTheater.Form
{
    partial class frmLapBaoCao
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
            this.tabTinhhinhbanve = new System.Windows.Forms.TabControl();
            this.tabLichChieu = new System.Windows.Forms.TabPage();
            this.crystalReportViewerLichChieu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crystalReportViewerBanVe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabDoanhthu = new System.Windows.Forms.TabPage();
            this.panelNgay = new System.Windows.Forms.Panel();
            this.grbNgay = new System.Windows.Forms.GroupBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.cmbDoanhThu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.crystalReportViewerDoanhThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabTinhhinhbanve.SuspendLayout();
            this.tabLichChieu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabDoanhthu.SuspendLayout();
            this.panelNgay.SuspendLayout();
            this.grbNgay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTinhhinhbanve
            // 
            this.tabTinhhinhbanve.Controls.Add(this.tabLichChieu);
            this.tabTinhhinhbanve.Controls.Add(this.tabPage2);
            this.tabTinhhinhbanve.Controls.Add(this.tabDoanhthu);
            this.tabTinhhinhbanve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTinhhinhbanve.Location = new System.Drawing.Point(0, 0);
            this.tabTinhhinhbanve.Name = "tabTinhhinhbanve";
            this.tabTinhhinhbanve.SelectedIndex = 0;
            this.tabTinhhinhbanve.Size = new System.Drawing.Size(1037, 600);
            this.tabTinhhinhbanve.TabIndex = 2;
            this.tabTinhhinhbanve.SelectedIndexChanged += new System.EventHandler(this.tabTinhhinhbanve_SelectedIndexChanged);
            // 
            // tabLichChieu
            // 
            this.tabLichChieu.BackColor = System.Drawing.Color.Black;
            this.tabLichChieu.Controls.Add(this.crystalReportViewerLichChieu);
            this.tabLichChieu.Location = new System.Drawing.Point(4, 22);
            this.tabLichChieu.Name = "tabLichChieu";
            this.tabLichChieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichChieu.Size = new System.Drawing.Size(1029, 574);
            this.tabLichChieu.TabIndex = 0;
            this.tabLichChieu.Text = "Xem lịch chiếu";
            // 
            // crystalReportViewerLichChieu
            // 
            this.crystalReportViewerLichChieu.ActiveViewIndex = -1;
            this.crystalReportViewerLichChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerLichChieu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerLichChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerLichChieu.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewerLichChieu.Name = "crystalReportViewerLichChieu";
            this.crystalReportViewerLichChieu.Size = new System.Drawing.Size(1023, 568);
            this.crystalReportViewerLichChieu.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.crystalReportViewerBanVe);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1029, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tình hình bán vé";
            // 
            // crystalReportViewerBanVe
            // 
            this.crystalReportViewerBanVe.ActiveViewIndex = -1;
            this.crystalReportViewerBanVe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerBanVe.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerBanVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerBanVe.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewerBanVe.Name = "crystalReportViewerBanVe";
            this.crystalReportViewerBanVe.Size = new System.Drawing.Size(1023, 568);
            this.crystalReportViewerBanVe.TabIndex = 0;
            // 
            // tabDoanhthu
            // 
            this.tabDoanhthu.BackColor = System.Drawing.Color.Black;
            this.tabDoanhthu.Controls.Add(this.panelNgay);
            this.tabDoanhthu.Controls.Add(this.btnXemDoanhThu);
            this.tabDoanhthu.Controls.Add(this.cmbDoanhThu);
            this.tabDoanhthu.Controls.Add(this.label2);
            this.tabDoanhthu.Controls.Add(this.crystalReportViewerDoanhThu);
            this.tabDoanhthu.Location = new System.Drawing.Point(4, 22);
            this.tabDoanhthu.Name = "tabDoanhthu";
            this.tabDoanhthu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhthu.Size = new System.Drawing.Size(1029, 574);
            this.tabDoanhthu.TabIndex = 2;
            this.tabDoanhthu.Text = "Doanh thu của rạp";
            // 
            // panelNgay
            // 
            this.panelNgay.Controls.Add(this.grbNgay);
            this.panelNgay.Location = new System.Drawing.Point(294, 37);
            this.panelNgay.Name = "panelNgay";
            this.panelNgay.Size = new System.Drawing.Size(402, 32);
            this.panelNgay.TabIndex = 6;
            // 
            // grbNgay
            // 
            this.grbNgay.Controls.Add(this.dtpToDate);
            this.grbNgay.Controls.Add(this.dtpFromDate);
            this.grbNgay.Controls.Add(this.label3);
            this.grbNgay.Controls.Add(this.label1);
            this.grbNgay.Location = new System.Drawing.Point(3, 0);
            this.grbNgay.Name = "grbNgay";
            this.grbNgay.Size = new System.Drawing.Size(392, 32);
            this.grbNgay.TabIndex = 7;
            this.grbNgay.TabStop = false;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(259, 8);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(123, 20);
            this.dtpToDate.TabIndex = 9;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(61, 8);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(123, 20);
            this.dtpFromDate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ ngày";
            // 
            // btnXemDoanhThu
            // 
            this.btnXemDoanhThu.BackColor = System.Drawing.Color.Red;
            this.btnXemDoanhThu.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnXemDoanhThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnXemDoanhThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXemDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.btnXemDoanhThu.Location = new System.Drawing.Point(698, 4);
            this.btnXemDoanhThu.Name = "btnXemDoanhThu";
            this.btnXemDoanhThu.Size = new System.Drawing.Size(75, 28);
            this.btnXemDoanhThu.TabIndex = 3;
            this.btnXemDoanhThu.Text = "Xem";
            this.btnXemDoanhThu.UseVisualStyleBackColor = false;
            this.btnXemDoanhThu.Click += new System.EventHandler(this.btnXemDoanhThu_Click);
            // 
            // cmbDoanhThu
            // 
            this.cmbDoanhThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoanhThu.FormattingEnabled = true;
            this.cmbDoanhThu.Items.AddRange(new object[] {
            "---Chọn doanh thu ---",
            "Phòng chiếu",
            "Phim",
            "Ca chiếu",
            "Ngày tháng"});
            this.cmbDoanhThu.Location = new System.Drawing.Point(433, 7);
            this.cmbDoanhThu.Name = "cmbDoanhThu";
            this.cmbDoanhThu.Size = new System.Drawing.Size(248, 24);
            this.cmbDoanhThu.TabIndex = 2;
            this.cmbDoanhThu.SelectedValueChanged += new System.EventHandler(this.cmbDoanhThu_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xem Doanh thu của Rạp theo";
            // 
            // crystalReportViewerDoanhThu
            // 
            this.crystalReportViewerDoanhThu.ActiveViewIndex = -1;
            this.crystalReportViewerDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewerDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerDoanhThu.Location = new System.Drawing.Point(6, 71);
            this.crystalReportViewerDoanhThu.Name = "crystalReportViewerDoanhThu";
            this.crystalReportViewerDoanhThu.Size = new System.Drawing.Size(1020, 500);
            this.crystalReportViewerDoanhThu.TabIndex = 0;
            // 
            // frmLapBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1037, 600);
            this.Controls.Add(this.tabTinhhinhbanve);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLapBaoCao";
            this.Text = "frmLapBaoCao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLapBaoCao_Load);
            this.tabTinhhinhbanve.ResumeLayout(false);
            this.tabLichChieu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabDoanhthu.ResumeLayout(false);
            this.tabDoanhthu.PerformLayout();
            this.panelNgay.ResumeLayout(false);
            this.grbNgay.ResumeLayout(false);
            this.grbNgay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTinhhinhbanve;
        private System.Windows.Forms.TabPage tabLichChieu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabDoanhthu;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerLichChieu;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerBanVe;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerDoanhThu;
        private System.Windows.Forms.ComboBox cmbDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.Panel panelNgay;
        private System.Windows.Forms.GroupBox grbNgay;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;

    }
}