using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmHienThiDSPhim_SuatChieu : System.Windows.Forms.Form
	{
		List<Phim> dsPhim = new List<Phim>();
		List<SuatChieu> dsSC = new List<SuatChieu>();
		string Loai;

		public frmHienThiDSPhim_SuatChieu(string loai, Object dt)
		{
			InitializeComponent();
			Loai = loai;
			if (loai == "Phim")
				dsPhim = (List<Phim>)dt;
			else
				dsSC = (List<SuatChieu>)dt;
		}

		private void frmHienThiDSPhim_SuatChieu_Load(object sender, EventArgs e)
		{
			if (Loai == "Phim")
			{
				LoadDSPhim(dsPhim);
			}
			else
			{
				LoadSuatChieu(dsSC);
			}
		}

		void LoadDSPhim(List<Phim> ds)
		{
			int stt = 0;
			int margin = 80;
			int ngang = margin;
			int doc = margin;
			int rong = 180;
			int dai = 250;
			foreach (Phim row in ds)
			{
				if (stt == 3)
				{
					ngang = margin;
					doc += dai + margin + 50;
					stt = 0;
				}

				Label lb = new Label();
				lb.Width = rong;
				lb.Height = margin;
				lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
				lb.Text = row.TenPhim + "\n( Định dạng " + row.DinhDang + ")";
				lb.ForeColor = Color.Red;
				lb.Location = new Point(ngang, doc + dai + 10);
				lb.Cursor = Cursors.Hand;
				lb.Tag = row;
				lb.Click += pb_Click;
				this.Controls.Add(lb);

				PictureBox pb = new PictureBox();
				pb.Size = new Size(rong, dai);
				pb.Location = new Point(ngang, doc);
				string url = Environment.CurrentDirectory;
				url = url.Replace("\\bin\\Debug", row.Poster);
				Bitmap bm = new Bitmap(url);
				pb.BackgroundImage = bm;
				pb.BackgroundImageLayout = ImageLayout.Stretch;
				pb.Cursor = Cursors.Hand;
				pb.Tag = row;
				pb.Click += pb_Click;
				this.Controls.Add(pb);

				stt++;
				ngang += rong + 2 * margin;
				tt.SetToolTip(pb, row.GioiThieu);
				tt.SetToolTip(lb, row.GioiThieu);
			}
		}

		void LoadSuatChieu(List<SuatChieu> ds)
		{
			int stt = 0;
			int margin = 80;
			int ngang = margin;
			int doc = margin;
			int rong = 180;
			int dai = 250;
			foreach (SuatChieu sc in ds)
			{
				Phim row = new Phim();
				row = PhimBus.LayPhimTheoMa(sc.Phim.Value);
				if (stt == 3)
				{
					ngang = margin;
					doc += dai + margin + 50;
					stt = 0;
				}
				Label lb = new Label();
				lb.Width = rong;
				lb.Height = margin;
				lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
				lb.Text = row.TenPhim + "\n( Định dạng " + row.DinhDang + ")\n" + "Chiếu lúc: " + CaChieuPhimBus.LayThoiGianBatDau(sc.CaChieu.Value);
				lb.ForeColor = Color.Red;
				lb.Location = new Point(ngang, doc + dai + 10);
				lb.Cursor = Cursors.Hand;
				lb.Tag = sc;
				lb.Click += lb_Click;
				this.Controls.Add(lb);

				PictureBox pb = new PictureBox();
				pb.Size = new Size(rong, dai);
				pb.Location = new Point(ngang, doc);
				string url = Environment.CurrentDirectory;
				url = url.Replace("\\bin\\Debug", row.Poster);
				Bitmap bm = new Bitmap(url);
				pb.BackgroundImage = bm;
				pb.BackgroundImageLayout = ImageLayout.Stretch;
				pb.Cursor = Cursors.Hand;
				pb.Tag = sc;
				pb.Click += lb_Click;
				this.Controls.Add(pb);

				stt++;
				ngang += rong + 2 * margin;
				tt.SetToolTip(pb, row.GioiThieu);
				tt.SetToolTip(lb, row.GioiThieu);
			}
		}

		void lb_Click(object sender, EventArgs e)
		{
			frmXemChiTietPhimChieu ct = new frmXemChiTietPhimChieu("CaChieu", (SuatChieu)((Control)sender).Tag, (Panel)this.Tag);
			ct.TopLevel = false;
			ct.Tag = dsSC;
			((Panel)this.Tag).Controls.Clear();
			((Panel)this.Tag).Controls.Add(ct);
			ct.Visible = true;
			Invalidate();
		}

		void pb_Click(object sender, EventArgs e)
		{
			frmXemChiTietPhimChieu ct = new frmXemChiTietPhimChieu("Phim", (Phim)((Control)sender).Tag, (Panel)this.Tag);
			ct.TopLevel = false;
			ct.Tag = dsPhim;
			((Panel)this.Tag).Controls.Clear();
			((Panel)this.Tag).Controls.Add(ct);
			ct.Visible = true;
			Invalidate();
		}


	}
}
