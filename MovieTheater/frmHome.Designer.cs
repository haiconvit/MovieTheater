namespace MovieTheater
{
    partial class frmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvPhim = new System.Windows.Forms.ListView();
            this.imglL = new System.Windows.Forms.ImageList(this.components);
            this.btnIndex_Refresh = new System.Windows.Forms.Button();
            this.btnIndex_Search = new System.Windows.Forms.Button();
            this.txtIndex_TenPhim = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSignUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuanLyBanVe = new System.Windows.Forms.Button();
            this.btnQuanLyRap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxBot = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxTop = new System.Windows.Forms.PictureBox();
            this.btnQuanLyChuRap = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 790);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phim:";
            // 
            // lvPhim
            // 
            this.lvPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPhim.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lvPhim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPhim.ForeColor = System.Drawing.Color.White;
            this.lvPhim.LargeImageList = this.imglL;
            this.lvPhim.Location = new System.Drawing.Point(0, 171);
            this.lvPhim.Margin = new System.Windows.Forms.Padding(4);
            this.lvPhim.Name = "lvPhim";
            this.lvPhim.Size = new System.Drawing.Size(1539, 568);
            this.lvPhim.TabIndex = 0;
            this.lvPhim.UseCompatibleStateImageBehavior = false;
            // 
            // imglL
            // 
            this.imglL.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imglL.ImageSize = new System.Drawing.Size(180, 256);
            this.imglL.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnIndex_Refresh
            // 
            this.btnIndex_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIndex_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnIndex_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnIndex_Refresh.FlatAppearance.BorderSize = 0;
            this.btnIndex_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndex_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndex_Refresh.ForeColor = System.Drawing.Color.White;
            this.btnIndex_Refresh.Location = new System.Drawing.Point(656, 778);
            this.btnIndex_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnIndex_Refresh.Name = "btnIndex_Refresh";
            this.btnIndex_Refresh.Size = new System.Drawing.Size(124, 42);
            this.btnIndex_Refresh.TabIndex = 43;
            this.btnIndex_Refresh.Text = "Refresh";
            this.btnIndex_Refresh.UseVisualStyleBackColor = false;
            // 
            // btnIndex_Search
            // 
            this.btnIndex_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIndex_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnIndex_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnIndex_Search.FlatAppearance.BorderSize = 0;
            this.btnIndex_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndex_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndex_Search.ForeColor = System.Drawing.Color.White;
            this.btnIndex_Search.Location = new System.Drawing.Point(511, 778);
            this.btnIndex_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btnIndex_Search.Name = "btnIndex_Search";
            this.btnIndex_Search.Size = new System.Drawing.Size(124, 42);
            this.btnIndex_Search.TabIndex = 42;
            this.btnIndex_Search.Text = "Search";
            this.btnIndex_Search.UseVisualStyleBackColor = false;
            // 
            // txtIndex_TenPhim
            // 
            this.txtIndex_TenPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIndex_TenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndex_TenPhim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtIndex_TenPhim.Location = new System.Drawing.Point(133, 779);
            this.txtIndex_TenPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndex_TenPhim.Name = "txtIndex_TenPhim";
            this.txtIndex_TenPhim.Size = new System.Drawing.Size(343, 34);
            this.txtIndex_TenPhim.TabIndex = 45;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1537, 40);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUser
            // 
            this.tsmiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogIn,
            this.tsmiSignUp,
            this.tsmiLogOut,
            this.tsmiExit});
            this.tsmiUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiUser.ForeColor = System.Drawing.Color.Gray;
            this.tsmiUser.Image = global::MovieTheater.Properties.Resources.user;
            this.tsmiUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmiUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(111, 36);
            this.tsmiUser.Text = "Login";
            // 
            // tsmiLogIn
            // 
            this.tsmiLogIn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tsmiLogIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLogIn.Name = "tsmiLogIn";
            this.tsmiLogIn.Size = new System.Drawing.Size(153, 28);
            this.tsmiLogIn.Text = "Log In";
            // 
            // tsmiSignUp
            // 
            this.tsmiSignUp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tsmiSignUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiSignUp.Name = "tsmiSignUp";
            this.tsmiSignUp.Size = new System.Drawing.Size(153, 28);
            this.tsmiSignUp.Text = "Sign Up";
            // 
            // tsmiLogOut
            // 
            this.tsmiLogOut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tsmiLogOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLogOut.Name = "tsmiLogOut";
            this.tsmiLogOut.Size = new System.Drawing.Size(153, 28);
            this.tsmiLogOut.Text = "Log Out";
            // 
            // tsmiExit
            // 
            this.tsmiExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tsmiExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(153, 28);
            this.tsmiExit.Text = "Exit";
            // 
            // btnQuanLyBanVe
            // 
            this.btnQuanLyBanVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuanLyBanVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnQuanLyBanVe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnQuanLyBanVe.FlatAppearance.BorderSize = 0;
            this.btnQuanLyBanVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyBanVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBanVe.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyBanVe.Location = new System.Drawing.Point(1301, 779);
            this.btnQuanLyBanVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyBanVe.Name = "btnQuanLyBanVe";
            this.btnQuanLyBanVe.Size = new System.Drawing.Size(199, 42);
            this.btnQuanLyBanVe.TabIndex = 42;
            this.btnQuanLyBanVe.Text = "Quản Lý Bán Vé";
            this.btnQuanLyBanVe.UseVisualStyleBackColor = false;
            this.btnQuanLyBanVe.Visible = false;
            // 
            // btnQuanLyRap
            // 
            this.btnQuanLyRap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuanLyRap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnQuanLyRap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnQuanLyRap.FlatAppearance.BorderSize = 0;
            this.btnQuanLyRap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyRap.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyRap.Location = new System.Drawing.Point(1331, 779);
            this.btnQuanLyRap.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyRap.Name = "btnQuanLyRap";
            this.btnQuanLyRap.Size = new System.Drawing.Size(169, 42);
            this.btnQuanLyRap.TabIndex = 43;
            this.btnQuanLyRap.Text = "Quản Lý Rạp";
            this.btnQuanLyRap.UseVisualStyleBackColor = false;
            this.btnQuanLyRap.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::MovieTheater.Properties.Resources.Banner;
            this.label2.Location = new System.Drawing.Point(480, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(573, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "PHIM ĐANG CHIẾU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxBot
            // 
            this.pbxBot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxBot.Image = global::MovieTheater.Properties.Resources.Bot;
            this.pbxBot.Location = new System.Drawing.Point(0, 738);
            this.pbxBot.Margin = new System.Windows.Forms.Padding(4);
            this.pbxBot.Name = "pbxBot";
            this.pbxBot.Size = new System.Drawing.Size(1540, 182);
            this.pbxBot.TabIndex = 46;
            this.pbxBot.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieTheater.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(39, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1461, 58);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // pbxTop
            // 
            this.pbxTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxTop.Image = global::MovieTheater.Properties.Resources.Top;
            this.pbxTop.Location = new System.Drawing.Point(0, -37);
            this.pbxTop.Margin = new System.Windows.Forms.Padding(4);
            this.pbxTop.Name = "pbxTop";
            this.pbxTop.Size = new System.Drawing.Size(1540, 210);
            this.pbxTop.TabIndex = 46;
            this.pbxTop.TabStop = false;
            // 
            // btnQuanLyChuRap
            // 
            this.btnQuanLyChuRap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuanLyChuRap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnQuanLyChuRap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnQuanLyChuRap.FlatAppearance.BorderSize = 0;
            this.btnQuanLyChuRap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyChuRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyChuRap.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyChuRap.Location = new System.Drawing.Point(1296, 779);
            this.btnQuanLyChuRap.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLyChuRap.Name = "btnQuanLyChuRap";
            this.btnQuanLyChuRap.Size = new System.Drawing.Size(204, 43);
            this.btnQuanLyChuRap.TabIndex = 51;
            this.btnQuanLyChuRap.Text = "Quản Lý Chủ Rạp";
            this.btnQuanLyChuRap.UseVisualStyleBackColor = false;
            this.btnQuanLyChuRap.Visible = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1537, 847);
            this.Controls.Add(this.btnQuanLyChuRap);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lvPhim);
            this.Controls.Add(this.txtIndex_TenPhim);
            this.Controls.Add(this.btnQuanLyRap);
            this.Controls.Add(this.btnQuanLyBanVe);
            this.Controls.Add(this.btnIndex_Refresh);
            this.Controls.Add(this.btnIndex_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxBot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxTop);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1547, 875);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rạp Chiếu Phim";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIndex_Refresh;
        private System.Windows.Forms.Button btnIndex_Search;
        private System.Windows.Forms.TextBox txtIndex_TenPhim;
        private System.Windows.Forms.ListView lvPhim;
        private System.Windows.Forms.ImageList imglL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxTop;
        private System.Windows.Forms.PictureBox pbxBot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiSignUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Button btnQuanLyBanVe;
        private System.Windows.Forms.Button btnQuanLyRap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuanLyChuRap;
    }
}