using System;
using System.Drawing;
using System.Windows.Forms;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmAdmin_Home : System.Windows.Forms.Form
	{
		frmQuanlySuatchieu QuanlySuatchieu = new frmQuanlySuatchieu();
		frmQuanlyPhim QuanlyPhim = new frmQuanlyPhim();
		frmQLTrangthaiPhong QuanlyPhong = new frmQLTrangthaiPhong();
		frmQuanlyGiave QuanlyGiave = new frmQuanlyGiave();
		frmQuanLyRapChieu QuanlyRapchieu = new frmQuanLyRapChieu();
		frmLapBaoCao LapBaoCao = new frmLapBaoCao();
		public NguoiDung ND = new NguoiDung();

		public delegate void DangXuat(object sender, EventArgs e);

		public DangXuat btnDangXuatClick;

		public frmAdmin_Home()
		{
			InitializeComponent();

			this.FormClosing += frmAdmin_Home_FormClosing;

			btnDangkyrapchieuphim.FlatStyle = FlatStyle.Flat;
			btnDangkyrapchieuphim.FlatAppearance.BorderColor = Color.Red;
			btnDangkyrapchieuphim.FlatAppearance.BorderSize = 2;

			btnLapbaocao.FlatStyle = FlatStyle.Flat;
			btnLapbaocao.FlatAppearance.BorderColor = Color.Red;
			btnLapbaocao.FlatAppearance.BorderSize = 2;
			btnQuanlyphim.FlatStyle = FlatStyle.Flat;
			btnQuanlyphim.FlatAppearance.BorderColor = Color.Red;
			btnQuanlyphim.FlatAppearance.BorderSize = 2;
			btnQuanlygiave.FlatStyle = FlatStyle.Flat;
			btnQuanlygiave.FlatAppearance.BorderColor = Color.Red;
			btnQuanlygiave.FlatAppearance.BorderSize = 2;
			btnQuanlySuatchieu.FlatStyle = FlatStyle.Flat;
			btnQuanlySuatchieu.FlatAppearance.BorderColor = Color.Red;
			btnQuanlySuatchieu.FlatAppearance.BorderSize = 2;
			btnQLphongchieu.FlatStyle = FlatStyle.Flat;
			btnQLphongchieu.FlatAppearance.BorderColor = Color.Red;
			btnQLphongchieu.FlatAppearance.BorderSize = 2;

		}

		void frmAdmin_Home_FormClosing(object sender, FormClosingEventArgs e)
		{
			((Main)this.Tag).Visible = true;
		}

		private void frmAdmin_Home_Load(object sender, EventArgs e)
		{
			if (ND.LoaiNguoiDung == 1)
			{
				llbTenND.Text = "Chủ rạp | " + ND.HoTen;
			}
			else
			{
				llbTenND.Text = "Nhân viên | " + ND.HoTen;
				this.Controls.Remove(splitContainer1);
				Panel pn = new Panel();
				pn.Location = splitContainer1.Location;
				pn.Dock = DockStyle.Fill;
				this.Controls.Add(pn);

				frmThanhToan tt = new frmThanhToan();
				tt.TopLevel = false;
				pn.Controls.Add(tt);
				tt.Visible = true;
			}
			this.splitContainer1.Panel1.BackColor = Color.Black;
			this.splitContainer1.Panel2.BackColor = Color.Black;
		}

		#region Button Admin
		private void btnDangkysuatchieu_Click(object sender, EventArgs e)
		{
			QuanlySuatchieu.TopLevel = false;
			QuanlySuatchieu.FormBorderStyle = FormBorderStyle.None;
			QuanlySuatchieu.ND = ND;
			splitContainer1.Panel2.Controls.Clear();
			splitContainer1.Panel2.Controls.Add(QuanlySuatchieu);
			QuanlySuatchieu.Visible = true;
			Invalidate();
		}

		private void btnQuanlyphim_Click(object sender, EventArgs e)
		{
			QuanlyPhim.TopLevel = false;
			QuanlyPhim.FormBorderStyle = FormBorderStyle.None;
			QuanlyPhim.ND = ND;
			splitContainer1.Panel2.Controls.Clear();
			splitContainer1.Panel2.Controls.Add(QuanlyPhim);
			QuanlyPhim.Visible = true;
			Invalidate();
		}
		private void btnQLphongchieu_Click(object sender, EventArgs e)
		{
			QuanlyPhong.TopLevel = false;
			QuanlyPhong.FormBorderStyle = FormBorderStyle.None;
			QuanlyPhong.ND = ND;
			splitContainer1.Panel2.Controls.Clear();
			splitContainer1.Panel2.Controls.Add(QuanlyPhong);
			QuanlyPhong.Visible = true;
			Invalidate();
		}
		private void btnQuanlygiave_Click(object sender, EventArgs e)
		{
			QuanlyGiave.TopLevel = false;
			QuanlyGiave.FormBorderStyle = FormBorderStyle.None;
			splitContainer1.Panel2.Controls.Clear();
			splitContainer1.Panel2.Controls.Add(QuanlyGiave);
			QuanlyGiave.Visible = true;
			Invalidate();
		}

		private void btnDangkyrapchieuphim_Click(object sender, EventArgs e)
		{
			QuanlyRapchieu.TopLevel = false;
			QuanlyRapchieu.FormBorderStyle = FormBorderStyle.None;
			QuanlyRapchieu.ND = ND;
			splitContainer1.Panel2.Controls.Clear();
			splitContainer1.Panel2.Controls.Add(QuanlyRapchieu);
			QuanlyRapchieu.Visible = true;
			Invalidate();
		}
		private void LapBaoCao_Click(object sender, EventArgs e)
		{
			LapBaoCao.TopLevel = false;
			LapBaoCao.ND = ND;
			splitContainer1.Panel2.Controls.Clear();
			splitContainer1.Panel2.Controls.Add(LapBaoCao);
			LapBaoCao.Visible = true;
			Invalidate();
		}
		#endregion

		private void btnDangXuat_Click(object sender, EventArgs e)
		{
			this.Close();
			btnDangXuatClick(sender, e);
		}

		private void btnLapbaocao_MouseDown(object sender, MouseEventArgs e)
		{
			foreach (Control ctr in splitContainer1.Panel1.Controls)
			{
				ctr.BackColor = Color.Transparent;
			}
			Button btn = (Button)sender;
			btn.BackColor = Color.Red;
		}
	}
}
