using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmXemChiTietPhimChieu : System.Windows.Forms.Form
	{
		string Loai;
		Phim p = new Phim();
		SuatChieu sc = new SuatChieu();
		Panel Envi = new Panel();
		NguoiDung ND = new NguoiDung();
		string trailer;


		public frmXemChiTietPhimChieu(string loai, Object data, Panel environment)
		{
			InitializeComponent();
			Loai = loai;
			if (loai == "Phim")
			{
				p = (Phim)data;
			}
			else
				sc = (SuatChieu)data;
			Envi = environment;
			ND = (NguoiDung)environment.Tag;
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void frmXemChiTietPhimChieu_Load(object sender, EventArgs e)
		{
			if (Loai == "CaChieu")
			{
				p = PhimBus.LayPhimTheoMa(sc.Phim.Value);
			}
			LoadThongTinPhim(p);


			if (ND.LoaiNguoiDung != 3)
			{
				btnBinhChon.Visible = false;
				cbxDiem.Visible = false;
				lbDiem.Visible = false;
			}

			if (Loai == "CaChieu")
			{
				this.Controls.Remove(groupBox1);
				Button btn = new Button();
				btn.Text = "Đặt vé \nxem suất này";
				btn.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
				btn.ForeColor = Color.White;
				btn.Cursor = Cursors.Hand;
				btn.FlatStyle = FlatStyle.Popup;
				btn.BackColor = Color.RoyalBlue;
				btn.Size = new Size(200, 90);
				btn.Location = new Point(460, 445);
				btn.Tag = sc;
				btn.Click += llb_Click;
				this.Controls.Add(btn);
				tt.SetToolTip(btn, "Nhấp để đặt vé xem suất chiếu phim này");

				Label lb = new Label();
				lb.AutoSize = true;
				lb.ForeColor = Color.Red;
				lb.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Italic);
				lb.Text = "Bắt đầu lúc: " + CaChieuPhimBus.LayThoiGianBatDau(sc.CaChieu.Value) + " Ngày " + (sc.NgayChieu);
				lb.Location = new Point(460, 410);
				this.Controls.Add(lb);
			}
			else
			{
				Phim phim = new Phim();
				phim.MaPhim = p.MaPhim;
				var ds = SuatChieuBus.LaySuatChieuHienTaiTheoPhim(p);
				if (ds.Count == 0)
				{
					Label lb = new Label();
					lb.AutoSize = true;
					lb.ForeColor = Color.Red;
					lb.Text = "Hiện tại không có suất chiếu phim này";
					lb.Location = new Point(20, 20);
					pnCacCaChieu.Controls.Add(lb);
				}
				else
				{
					int local = 10;
					foreach (SuatChieu r in ds)
					{
						LinkLabel llb = new LinkLabel();
						llb.AutoSize = true;
						llb.LinkColor = Color.Orange;
						llb.Font = new Font("Microsoft Sans Serif", 10);
						llb.Location = new Point(20, local);
						llb.Text = $"{r.NgayChieu} Ca {r.CaChieu}: {CaChieuPhimBus.LayThoiGianBatDau(r.CaChieu.Value)}";
						pnCacCaChieu.Controls.Add(llb);
						llb.Tag = r;
						llb.Click += llb_Click;
						local += 30;
						tt.SetToolTip(llb, "Nhấp để đặt vé xem suất chiếu phim này");
					}
				}
				pnCacCaChieu.Focus();
			}
		}

		private void LoadThongTinPhim(Phim p)
		{
			cbxDiem.Text = "-- Bình chọn --";
			string url = Environment.CurrentDirectory;
			trailer = url.Replace("\\bin\\Debug", p.Trailer.ToString());
			url = url.Replace("\\bin\\Debug", p.Poster.ToString());
			pbPoster.BackgroundImage = new Bitmap(url);
			TheLoaiPhim tl = new TheLoaiPhim();
			tl.MaTheLoai = p.TheLoai;
			lbTheLoai.Text = "Thể loại: " + TheLoaiPhimBus.LayTenTheLoai(tl);
			lbTenPhim.Text = p.TenPhim;
			lbHangSX.Text = "Hãng sản xuất: " + p.HangPhim;
			lbNuocSX.Text = "Nước sản xuất: " + p.NuocSX;
			lbDinhDang.Text = "Định dạng: " + p.DinhDang;
			lbCacDienVien.Text = "Các diễn viên: " + p.CacDienVien;
			lbThoiLuong.Text = "Thời lượng: " + p.ThoiLuong + " phút";

			string textDiemTB = string.Format("Điểm bình chọn trung bình: {0:0.00} ({1} lượt bình chọn)", p.DiemBinhChon, BinhChonPhimBus.DemSoLanBinhChon((int)p.MaPhim));
			lbDiemTB.Text = textDiemTB;
			txtGioiThieu.Text = p.GioiThieu;
		}

		void llb_Click(object sender, EventArgs e)
		{
			frmChonGheNgoi chon = new frmChonGheNgoi(Loai, (SuatChieu)((Control)sender).Tag, Envi, this.Tag);
			if (Loai == "Phim")
				chon.Tag = p;
			else
				chon.Tag = sc;
			chon.TopLevel = false;
			Envi.Controls.Clear();
			Envi.Controls.Add(chon);
			chon.Visible = true;
		}

		private void pnCacCaChieu_Click(object sender, EventArgs e)
		{
			pnCacCaChieu.Focus();
		}

		private void btnBinhChon_Click(object sender, EventArgs e)
		{
			if (ND.MaND != 0)
			{
				if (cbxDiem.Text != "-- Bình chọn --")
				{
					BinhChonPhim bc = new BinhChonPhim();
					bc.MaKH = ND.MaND;
					bc.Diem = float.Parse(cbxDiem.Text);
					bc.MaPhim = p.MaPhim;
					BinhChonPhimBus.BinhChon(bc);
					MessageBox.Show("Cảm ơn bạn đã bình chọn cho phim", "Bình chọn thành công");
					this.frmXemChiTietPhimChieu_Load(sender, e);
					this.Controls.Remove(btnBinhChon);
					this.Controls.Remove(cbxDiem);
					this.Controls.Remove(lbDiem);
					lbDiem.Text = "Bạn đã bình chọn\nphim này rồi !!";
					lbDiem.ForeColor = Color.Red;
					lbDiem.Location = new Point(785, 460);
					this.Controls.Add(lbDiem);
				}
				else
				{
					MessageBox.Show("Bạn chưa chọn điểm cho phim", "Bình chọn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cbxDiem.Focus();
				}
			}
			else
			{
				MessageBox.Show("Bạn chưa đăng nhập, bạn cần đăng nhập để bình chọn phim", "Thông báo");
				return;
			}
		}

		private void lbBack_Click(object sender, EventArgs e)
		{
			Envi.Controls.Clear();
			frmHienThiDSPhim_SuatChieu x;

			x = new frmHienThiDSPhim_SuatChieu(Loai, this.Tag);
			x.TopLevel = false;
			x.Tag = Envi;
			Envi.Controls.Add(x);
			x.Visible = true;
			Envi.Invalidate();
		}

		private void btnTrailer_Click(object sender, EventArgs e)
		{
			Process.Start(p.Trailer);
		}


	}
}
