using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmDangKyND : System.Windows.Forms.Form
	{
		public frmDangKyND()
		{
			InitializeComponent();
		}

		public delegate void DangNhap(string TenDN, string MK);

		public DangNhap DKThanhCong;

		//Không cho nhập kí tự đặc biệt
		private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
		{
			txtMatKhau.UseSystemPasswordChar = true;
		}

		private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsLetterOrDigit(e.KeyChar) == true && !Char.IsControl(e.KeyChar) == true)
			{
				e.Handled = true;
			}
		}

		//Kiểm tra độ dài
		private void txtTaiKhoan_Leave(object sender, EventArgs e)
		{
			if (txtTaiKhoan.TextLength < 6)
			{
				MessageBox.Show("Tên tài khoản quá ngắn");
				txtTaiKhoan.Focus();
			}
		}

		private void txtMatKhau_Leave(object sender, EventArgs e)
		{
			if (btnHuyBo.Focused == false)
			{
				if (txtMatKhau.TextLength < 6)
				{
					MessageBox.Show("Mật khẩu quá ngắn");
					txtMatKhau.Focus();
				}
			}
		}

		//Chức năng của Button
		private void btnHuyBo_Click(object sender, EventArgs e)
		{
			frmHienThiDSPhim_SuatChieu frm = new frmHienThiDSPhim_SuatChieu("Phim", PhimBus.LayDsPhim());
			frm.TopLevel = false;
			((Panel)this.Tag).Controls.Clear();
			((Panel)this.Tag).Controls.Add(frm);
			frm.Visible = true;
		}

		private void btnDangKy_Click(object sender, EventArgs e)
		{
			if (KtraTaiKhoanTrung(txtTaiKhoan.Text) == true)
			{
				NguoiDung kh = new NguoiDung();
				kh.TenND = txtTaiKhoan.Text;
				kh.MatKhau = md5(txtMatKhau.Text);
				kh.HoTen = txtHoTen.Text;
				kh.NgaySinh = dtmNgaySinh.Value;
				kh.DienThoai = txtSoDT.Text;
				kh.Email = txtEmail.Text + "@" + cboTenMienEmail.Text;
				kh.LoaiNguoiDung = 3;

				NguoiDungBus.ThemNguoiDung(kh);

				MessageBox.Show("Đăng kí thành công");
				DKThanhCong(kh.TenND, txtMatKhau.Text);
				//frmHienThiDSPhim_SuatChieu frm = new frmHienThiDSPhim_SuatChieu("Phim", (new PhimBUS()).LayDSPhim());
				//frm.TopLevel = false;
				//((Panel)this.Tag).Controls.Clear();
				//((Panel)this.Tag).Controls.Add(frm);
				//frm.Visible = true;
			}
			else
			{
				MessageBox.Show("Tên tài khoản đã tồn tại");
			}
		}

		#region Các hàm bổ trợ

		bool KtraTaiKhoanTrung(string tk)
		{
			NguoiDung temp = EntityHelper.QlRapEntities.NguoiDungs.SingleOrDefault(d => d.TenND.Equals(tk));
			if (temp == null)
				return false;
			else
				return true;
		}

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
		#endregion

		private void frmDangKyND_Load(object sender, EventArgs e)
		{
			cboTenMienEmail.Text = "gmail.com";
		}

		private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
			{
				e.Handled = true;
			}
		}

	}
}
