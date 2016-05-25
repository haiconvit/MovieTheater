namespace MovieTheater.Form
{
    partial class frmChonGheNgoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.llbBack = new System.Windows.Forms.LinkLabel();
            this.cbxGiaVe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn vị trí ghế ngồi:";
            // 
            // llbBack
            // 
            this.llbBack.AutoSize = true;
            this.llbBack.Location = new System.Drawing.Point(29, 609);
            this.llbBack.Name = "llbBack";
            this.llbBack.Size = new System.Drawing.Size(92, 13);
            this.llbBack.TabIndex = 2;
            this.llbBack.TabStop = true;
            this.llbBack.Text = "Trở về trang trước";
            this.llbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbBack_LinkClicked);
            // 
            // cbxGiaVe
            // 
            this.cbxGiaVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGiaVe.Enabled = false;
            this.cbxGiaVe.FormattingEnabled = true;
            this.cbxGiaVe.Location = new System.Drawing.Point(498, 35);
            this.cbxGiaVe.Name = "cbxGiaVe";
            this.cbxGiaVe.Size = new System.Drawing.Size(121, 21);
            this.cbxGiaVe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(457, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(625, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "VNĐ";
            // 
            // frmChonGheNgoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1120, 723);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxGiaVe);
            this.Controls.Add(this.llbBack);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChonGheNgoi";
            this.Text = "frmChonGheNgoi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChonGheNgoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbBack;
        private System.Windows.Forms.ComboBox cbxGiaVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}