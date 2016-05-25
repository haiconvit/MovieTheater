using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmChonGheNgoi : System.Windows.Forms.Form
	{

		SuatChieu Data = new SuatChieu();
		string Loai;
		Panel Envi = new Panel();
		Panel pn;
		Object BackData = new object();
		NguoiDung ND = new NguoiDung();

		public frmChonGheNgoi(string loai, SuatChieu data, Panel environment, Object dt)
		{
			InitializeComponent();
			Data = data;
			Envi = environment;
			Loai = loai;
			BackData = dt;
			ND = (NguoiDung)environment.Tag;
			if (ND.LoaiNguoiDung == 2 || ND.LoaiNguoiDung == 1)
				cbxGiaVe.Enabled = true;
		}

		private void frmChonGheNgoi_Load(object sender, EventArgs e)
		{
			LoadGhe(Data);
			LoadCbxGiaVe();
		}

		void LoadCbxGiaVe()
		{
			int LoaiNgay = 1;
			DateTime ngay = Data.NgayChieu.Value;
			if (KiemTraNgayLe(ngay))
			{
				LoaiNgay = 4;
			}
			else
			{
				if (ngay.DayOfWeek == DayOfWeek.Tuesday)
					LoaiNgay = 2;
				if (ngay.DayOfWeek == DayOfWeek.Saturday || ngay.DayOfWeek == DayOfWeek.Sunday)
					LoaiNgay = 3;
			}
			string DinhDang = PhimBus.LayDinhDang(Data.Phim.Value);
			int LoaiTG = CaChieuPhimBus.LayLoaiThoiGian(Data.CaChieu.Value);
			DataTable dt = new DataTable();
			var gv = GiaVeBus.LayGiaVeTheoTieuChi(LoaiNgay, LoaiTG, DinhDang);
			cbxGiaVe.Items.Add(gv.NguoiLon);
			cbxGiaVe.Items.Add(gv.SinhVien);
			cbxGiaVe.Items.Add(gv.TreEm);
			cbxGiaVe.SelectedItem = gv.NguoiLon;
		}

		bool KiemTraNgayLe(DateTime n)
		{
			if (n.Day == 1 && n.Month == 1)
				return true;
			if (n.Day == 30 && n.Month == 4)
				return true;
			if (n.Day == 1 && n.Month == 5)
				return true;
			if (n.Day == 8 && n.Month == 3)
				return true;
			if (n.Day == 2 && n.Month == 9)
				return true;
			return false;
		}

		void LoadGhe(SuatChieu sc)
		{
			List<Ve> ds = new List<Ve>();
			ds = VeBus.LayDsVeTheoSuatChieu(sc);
			pn = new Panel();
			pn.AutoSize = true;
			pn.Location = new Point(50, 130);
			this.Controls.Add(pn);

			PhongChieuPhim p = new PhongChieuPhim();
			p = PhongChieuPhimBus.LayPhongChieuTheoMa(sc.Phong);
			int Daibtn = 60;
			int Rongbtn = 40;
			int Mar = 3;
			int He = 3;
			int Wi = 3;
			int index = 1;
			for (int i = 0; i < p.SoDayGhe; ++i)
			{
				Wi = Mar;
				for (int j = 0; j < p.SoHangGhe; ++j)
				{
					Button btn = new Button();
					btn.Size = new Size(Daibtn, Rongbtn);
					btn.Location = new Point(Wi, He);
					btn.FlatStyle = FlatStyle.Popup;
					btn.Font = new Font("Microsoft Sans Serif", 9f);
					if (ds[index - 1].TinhTrang == "còn trống")
					{
						btn.BackColor = Color.Transparent;
						btn.Tag = ds[index - 1];
						btn.ForeColor = Color.Lime;
						btn.Cursor = Cursors.Hand;
						btn.Text = index.ToString();
						btn.Click += btn_Click;
					}
					else
					{
						btn.BackColor = Color.Orange;
						btn.Enabled = false;
						btn.ForeColor = Color.RoyalBlue;
						btn.Text = index.ToString() + "\n(Đã đặt)";
					}
					if (ND.LoaiNguoiDung == 1)
					{
						btn.Enabled = false;
					}
					pn.Controls.Add(btn);
					Wi += Daibtn + Mar;
					index++;
				}
				He += Rongbtn + Mar;
			}
			llbBack.Location = new Point(pn.Left, pn.Bottom + 50);

			Button btnManHinh = new Button();
			btnManHinh.Size = new Size(pn.Width, 20);
			btnManHinh.BackColor = Color.White;
			btnManHinh.ForeColor = Color.White;
			btnManHinh.Text = "Màn hình";
			btnManHinh.Enabled = false;
			btnManHinh.Location = new Point(50, 100);
			this.Controls.Add(btnManHinh);
		}

		void btn_Click(object sender, EventArgs e)
		{
			if (ND.MaND == 0)
			{
				MessageBox.Show("Bạn chưa đăng nhập, bạn phải đăng nhập để mua vé !!", "Đặt vé thất bại");
				return;
			}
			string tb = string.Format("Bạn muốn đặt vé tại vị trí ghế {0} ?", ((Button)sender).Text);
			var a = MessageBox.Show(tb, "Đặt vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (a == DialogResult.Yes)
			{
				try
				{
					HoaDon hd = new HoaDon();
					Ve ve = (Ve)((Button)sender).Tag;
					hd.MaVe = ((Ve)((Button)sender).Tag).MaVe;
					hd.NguoiMua = ND.MaND;
					hd.ThoiGianDat = DateTime.Now;
					hd.TongTien = float.Parse(cbxGiaVe.Text);
					if (ND.LoaiNguoiDung == 2)
					{
						hd.TinhTrang = "đã thanh toán";
						HoaDonBus.ThemHoaDon(hd);
						MessageBox.Show("Đặt vé thành công !", "Congratulation !");
					}
					else
					{
						hd.TinhTrang = "chưa thanh toán";
						HoaDonBus.ThemHoaDon(hd);
						MessageBox.Show("Chúc mừng bạn đặt vé thành công.\n Vé của bạn được giữ trong 04 giờ, vui lòng đến rạp để thanh toán.\nNếu sau 04 giờ bạn chưa thanh toán thì tình trạng đặt vẽ sẽ bị hủy");
					}

					((Button)sender).BackColor = Color.Orange;
					((Button)sender).Enabled = false;
					((Button)sender).Text += "\n(Đã đặt)";
				}
				catch
				{
					MessageBox.Show("Lỗi hệ thống, vui lòng quay lại sau", "Đặt vé thất bại");
				}
			}
		}

		private void llbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmXemChiTietPhimChieu xem = new frmXemChiTietPhimChieu(Loai, this.Tag, Envi);
			Envi.Controls.Clear();
			xem.TopLevel = false;
			xem.Tag = BackData;
			Envi.Controls.Add(xem);
			xem.Visible = true;
		}
	}
}
