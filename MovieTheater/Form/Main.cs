using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class Main : System.Windows.Forms.Form
	{
		List<Phim> dsPhim = new List<Phim>();
		List<SuatChieu> dsSC = new List<SuatChieu>();
		NguoiDung ND = new NguoiDung();

		LinkLabel llbTenND;

		Button btnDangXuat;

		public Main()
		{
			InitializeComponent();
			ND = NguoiDungBus.TaoNguoiDungMacDinh();
			lbCoppyRight.Text = @"© 2014-2015 Hệ thống rạp phim HKT
- Trụ sở chính: 227 Nguyễn Văn Cừ, phường 4,
Hồ Chí Minh
- Điện thoại: 01664857479";
			txtTenTaiKhoan.KeyPress += txtMatKhau_KeyPress;
		}

		private void Main_Load(object sender, EventArgs e)
		{
			dsPhim = PhimBus.LayDsPhim();

			frmHienThiDSPhim_SuatChieu ds = new frmHienThiDSPhim_SuatChieu("Phim", dsPhim);
			ds.TopLevel = false;
			splitContainer1.Panel2.Tag = ND;
			ds.Tag = this.splitContainer1.Panel2;
			splitContainer1.Panel2.Controls.Clear();
			splitContainer1.Panel2.Controls.Add(ds);
			ds.Visible = true;

			LoadCBXRap();
			cbxDinhDang.Text = @"-- Chọn định dạng --";
			LoadCBXTheLoai();
			LoadCBXCaChieu();
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			DangNhap(txtTenTaiKhoan.Text, txtMatKhau.Text);
		}

		private void llbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			splitContainer1.Panel2.Controls.Clear();
			var dsRap = RapChieuPhimBus.LayDsRapChieuPhim();
			int he = 100;
			foreach (RapChieuPhim r in dsRap)
			{
				Label lb = new Label();
				lb.AutoSize = true;
				lb.AllowDrop = true;
				string text = $"- Chi nhánh {r.TenRap}\n  Địa chỉ: {r.DiaChi}";
				lb.Text = text;
				lb.ForeColor = Color.White;
				lb.Location = new Point(100, he);
				splitContainer1.Panel2.Controls.Add(lb);
				he += 50 + lb.Height;
			}
			Label lbDienThoai = new Label();
			lbDienThoai.AutoSize = true;
			lbDienThoai.AllowDrop = true;
			lbDienThoai.Text = @"Điện thoại: (+84)1664857479 - (+84)1233245111 - (+84)1674299239
Email: RapPhimHieuKhanhTuyen@gmail.com";
			lbDienThoai.ForeColor = Color.White;
			lbDienThoai.Location = new Point(100, he);
			splitContainer1.Panel2.Controls.Add(lbDienThoai);
			he += 50 + lbDienThoai.Height;

			LinkLabel llb = new LinkLabel();
			llb.AutoSize = true;
			llb.AllowDrop = true;
			llb.Text = @"Trở về trang chính";
			llb.Location = new Point(50, he);
			splitContainer1.Panel2.Controls.Add(llb);
			llb.Click += llb_Click;
		}

		private void llbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmDangKyND dk = new frmDangKyND();
			dk.DKThanhCong = new frmDangKyND.DangNhap(DangNhap);
			dk.TopLevel = false;
			dk.Tag = splitContainer1.Panel2;
			splitContainer1.Panel2.Controls.Clear();
			splitContainer1.Panel2.Controls.Add(dk);
			dk.Visible = true;
		}

		void llb_Click(object sender, EventArgs e)
		{
			Main_Load(sender, e);
		}

		void btnDangXuat_Click(object sender, EventArgs e)
		{
			panel1.Controls.Remove(llbTenND);
			panel1.Controls.Remove(btnDangXuat);
			panel1.Controls.Add(txtTenTaiKhoan);
			panel1.Controls.Add(txtMatKhau);
			panel1.Controls.Add(llbDangKy);
			panel1.Controls.Add(btnDangNhap);
			panel1.Controls.Add(lbMatKhau);
			panel1.Controls.Add(lbTaiKhoan);
			ND = NguoiDungBus.TaoNguoiDungMacDinh();
			Main_Load(sender, e);

		}

		void llbTenND_Click(object sender, EventArgs e)
		{
			switch (ND.LoaiNguoiDung)
			{
				case 1:
					frmAdmin_Home ad = new frmAdmin_Home();
					ad.btnDangXuatClick = new frmAdmin_Home.DangXuat(btnDangXuat_Click);
					ad.ND = ND;
					ad.Tag = this;
					ad.Show();
					this.Hide();
					break;
				case 2:
					frmAdmin_Home bv = new frmAdmin_Home();
					bv.btnDangXuatClick = new frmAdmin_Home.DangXuat(btnDangXuat_Click);
					bv.ND = ND;
					bv.Tag = this;
					bv.Show();
					this.Hide();
					break;
			}
		}

		private void btnTimTheoTuKhoa_Click(object sender, EventArgs e)
		{
			splitContainer1.Panel2.Controls.Clear();
			if (txtTuKhoa.Text == "")
			{
				Label lbThongBao = new Label();
				lbThongBao.AutoSize = true;
				lbThongBao.Text = @"Dữ liệu tìm kiếm không có. Vui lòng bạn nhập từ khóa khác để tìm kiếm";
				lbThongBao.Font = new Font("Microsoft Sans Serif", 12);
				lbThongBao.ForeColor = Color.Red;
				lbThongBao.Location = new Point(100, 100);
				splitContainer1.Panel2.Controls.Add(lbThongBao);
			}
			else
			{
				dsPhim = PhimBus.TimPhimTheoTuKhoa(txtTuKhoa.Text);
				if (dsPhim.Count == 0)
				{
					Label lbThongBao = new Label();
					lbThongBao.AutoSize = true;
					lbThongBao.Text = @"Không có phim chiếu thỏa điều kiện !";
					lbThongBao.ForeColor = Color.Red;
					lbThongBao.Font = new Font("Microsoft Sans Serif", 12);
					lbThongBao.Location = new Point(100, 100);
					splitContainer1.Panel2.Controls.Add(lbThongBao);
				}
				else
				{
					frmHienThiDSPhim_SuatChieu ds = new frmHienThiDSPhim_SuatChieu("Phim", dsPhim);
					ds.TopLevel = false;
					splitContainer1.Panel2.Tag = ND;
					ds.Tag = this.splitContainer1.Panel2;
					splitContainer1.Panel2.Controls.Clear();
					splitContainer1.Panel2.Controls.Add(ds);
					ds.Visible = true;
				}
			}
		}

		private void splitContainer1_Panel2_Click(object sender, EventArgs e)
		{
			splitContainer1.Panel2.Focus();
		}

		private void btnTimSuatChieu_Click(object sender, EventArgs e)
		{
			dsSC = SuatChieuBus.LaySuatChieuTheoTieuChi(dtpNgayChieu.Value, (string)cbxRap.SelectedValue, cbxDinhDang.Text, (string)cbxTheLoai.SelectedValue, (int)cbxCaChieu.SelectedValue);
			splitContainer1.Panel2.Controls.Clear();
			if (dsPhim.Count == 0)
			{
				Label lbThongBao = new Label();
				lbThongBao.AutoSize = true;
				lbThongBao.Text = @"Không có suất chiếu thỏa điều kiện !";
				lbThongBao.ForeColor = Color.Red;
				lbThongBao.Font = new Font("Microsoft Sans Serif", 12);
				lbThongBao.Location = new Point(100, 100);
				splitContainer1.Panel2.Controls.Add(lbThongBao);
			}
			else
			{
				frmHienThiDSPhim_SuatChieu ds = new frmHienThiDSPhim_SuatChieu("Suất Chiếu", dsSC);
				ds.TopLevel = false;
				splitContainer1.Panel2.Tag = ND;
				ds.Tag = this.splitContainer1.Panel2;
				splitContainer1.Panel2.Controls.Clear();
				splitContainer1.Panel2.Controls.Add(ds);
				ds.Visible = true;
			}
		}

		private void txtTuKhoa_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				btnTimTheoTuKhoa_Click(sender, (new EventArgs()));
			}
		}

		private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				btnDangNhap_Click(sender, (new EventArgs()));
			}
		}


		#region CacHamPhu

		public static byte[] encryptData(string data)
		{
			MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
			byte[] hashedBytes;
			System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
			hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
			return hashedBytes;
		}

		public static string md5(string data)
		{
			return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
		}

		private bool KiemTraDN()
		{
			var dsND = NguoiDungBus.LayDsNguoiDung();
			foreach (NguoiDung row in dsND)
			{
				if (txtTenTaiKhoan.Text == row.TenND)
				{
					if (md5(txtMatKhau.Text) == row.MatKhau)
					{
						return true;
					}
				}
			}
			return false;
		}

		void DNThanhCong()
		{
			btnDangXuat = new Button();
			btnDangXuat.Text = "Đăng xuất";
			btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)8.25);
			btnDangXuat.FlatStyle = FlatStyle.Popup;
			btnDangXuat.BackColor = Color.LightSteelBlue;
			btnDangXuat.Location = new Point(1275, 25);
			panel1.Controls.Add(btnDangXuat);

			btnDangXuat.Click += btnDangXuat_Click;
			llbTenND = new LinkLabel();
			llbTenND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
			llbTenND.AutoSize = true;           
            NguoiDung nd = new NguoiDung();
			nd = (NguoiDung)this.Tag;
			switch (nd.LoaiNguoiDung)
			{
				case 1:
					llbTenND.Text = "Chủ rạp";
					break;
				case 2:
					llbTenND.Text = "Nhân viên";
					break;
				case 3:
					llbTenND.Text = "User";
					break;
			}
			llbTenND.Text += " | " + nd.HoTen;
			llbTenND.LinkColor = Color.White;
			panel1.Controls.Add(llbTenND);
			llbTenND.Location = new Point(1275 - (llbTenND.Text.Length * 10), 25);
			llbTenND.Click += llbTenND_Click;
		}

		private void RemoveControlsDangNhap()
		{
			txtTenTaiKhoan.Text = "";
			txtMatKhau.Text = "";
			panel1.Controls.Remove(txtTenTaiKhoan);
			panel1.Controls.Remove(txtMatKhau);
			panel1.Controls.Remove(llbDangKy);
			panel1.Controls.Remove(btnDangNhap);
			panel1.Controls.Remove(lbMatKhau);
			panel1.Controls.Remove(lbTaiKhoan);
		}

		void LoadCBXRap()
		{
			var dt = RapChieuPhimBus.LayDsRapChieuPhim();
			RapChieuPhim r = new RapChieuPhim();
			r.MaRap = "0";
			r.TenRap = "-- Chọn rạp --";
			dt.Add(r);
			cbxRap.DataSource = dt;
			cbxRap.DisplayMember = "TenRap";
			cbxRap.ValueMember = "MaRap";
			cbxRap.SelectedValue = "0";
		}

		void LoadCBXTheLoai()
		{
			List<TheLoaiPhim> dsTheLoai = new List<TheLoaiPhim>();
			dsTheLoai = TheLoaiPhimBus.LayDsTheLoaiPhim();
			var tl = new TheLoaiPhim();
			tl.MaTheLoai = "0";
			tl.TenTheLoai = "-- Chọn thể loại --";
			dsTheLoai.Add(tl);
			cbxTheLoai.DataSource = dsTheLoai;
			cbxTheLoai.DisplayMember = "TenTheLoai";
			cbxTheLoai.ValueMember = "MaTheLoai";
			cbxTheLoai.SelectedValue = "0";
		}

		void LoadCBXCaChieu()
		{
			DataTable dt = new DataTable();
			var ds = CaChieuPhimBus.LayDsCaChieuPhim();
			dt.Columns.Add("MaCa", typeof(int));
			dt.Columns.Add("MieuTa", typeof(string));
			foreach (CaChieuPhim c in ds)
			{
				string mt = $"Ca {c.MaCa}: Bắt đầu từ {c.ThoiGianBD.ToString()}";
				dt.Rows.Add(c.MaCa, mt);
			}
			var row = dt.NewRow();
			row["MaCa"] = 0;
			row["MieuTa"] = "-- Chọn ca chiếu phim --";
			dt.Rows.Add(row);
			cbxCaChieu.DataSource = dt;
			cbxCaChieu.DisplayMember = "MieuTa";
			cbxCaChieu.ValueMember = "MaCa";
			cbxCaChieu.SelectedValue = 0;
		}

		void DangNhap(string TenDN, string MatKhau)
		{
			var dsND = NguoiDungBus.LayDsNguoiDung();
			foreach (NguoiDung nd in dsND)
			{
				if (TenDN == nd.TenND && md5(MatKhau) == nd.MatKhau)
				{
					this.Tag = nd;
					RemoveControlsDangNhap();
					DNThanhCong();
					ND = nd;
					MessageBox.Show("Đăng nhập thành công !", "Thông báo");
					Main_Load(this, (new EventArgs()));
					return;
				}
			}
			MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !", "Đăng nhập thất bại !");
		}



		#endregion


	}
}
