using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmChitietPhim : System.Windows.Forms.Form
	{
		public string lblTen;
		public bool checkform;
		public int MaPhim;
		public string Dinhdang;
		private string pathimage;
		private string pathvideo;
		private string linkimageold = "";
		private string linkvideoold = "";
		public frmChitietPhim()
		{
			InitializeComponent();

			nudThoiluong.Maximum = 1000;
			nudThoiluong.Minimum = 1;
		}
		private void frmChitietPhim_Load(object sender, EventArgs e)
		{
			lblTenForm.Text = lblTen;
			this.Text = lblTen;
			if (checkform == true)
			{
				btnThem.Text = "Thêm";
				btnHuy.Text = "Hủy";

				cmbDinhdang.Text = "2D";

				cmbTheloai.DataSource = TheLoaiPhimBus.LayDsTheLoaiPhim();
				cmbTheloai.DisplayMember = "TenTheLoai";
				cmbTheloai.ValueMember = "MaTheLoai";
			}
			else
			{
				btnThem.Text = "Sửa";
				btnHuy.Text = "Xóa";

				Phim p = new Phim();
				p = PhimBus.LayPhimTheoMa(MaPhim);

				txtMaphim.Text = MaPhim.ToString();
				txtTenphim.Text = p.TenPhim;
				txtHangphim.Text = p.HangPhim;
				txtNamsanxuat.Text = p.NamSX.ToString();
				txtNuocsanxuat.Text = p.NuocSX;
				cmbDinhdang.SelectedText = p.DinhDang;
				cmbDinhdang.Text = p.DinhDang;
				nudThoiluong.Value = p.ThoiLuong.Value;
				txtGioithieu.Text = p.GioiThieu;
				txtDienVien.Text = p.CacDienVien;
				lblImage.Text = p.Poster;

				cmbTheloai.DataSource = TheLoaiPhimBus.LayDsTheLoaiPhim();
				cmbTheloai.DisplayMember = "TenTheLoai";
				cmbTheloai.ValueMember = "MaTheLoai";
				cmbTheloai.SelectedValue = p.TheLoai;

				string url = Environment.CurrentDirectory;
				url = url.Replace("\\bin\\Debug", "" + lblImage.Text);
				pathimage = url;

				try
				{
					pictureBox1.BackgroundImage = Image.FromFile(url);
					pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
				}
				catch { }
				linkimageold = p.Poster;
				linkvideoold = p.Trailer;

			}
		}
		private string linkimage = "";
		private string linkvideo = "";
		private string linkposter = "";
		private string linktrailer = "";
		private void folderPath_Click(object sender, EventArgs e)
		{
			string[] temp = new string[10];
			openFileDialog1.Filter = "Image Files (*.bmp, *.jpg, *png)|*.bmp;*.jpg;*.png";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.lblImage.Text = openFileDialog1.FileName;
				temp = lblImage.Text.Split('\\');
				pictureBox1.BackgroundImage = new Bitmap(openFileDialog1.FileName);
				pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
				linkposter = "\\Poster\\" + temp[temp.Length - 1];
			}
			string url = Environment.CurrentDirectory;
			url = url.Replace("\\bin\\Debug", "\\Poster\\" + temp[temp.Length - 1]);
			linkimage = url;
		}

		private void Copyfile(string curent, string destinationPath)
		{
			System.IO.FileInfo file = new System.IO.FileInfo(curent);
			file.CopyTo(destinationPath);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (btnThem.Text == "Thêm")
			{
				Phim p = new Phim
				{
					TenPhim = txtTenphim.Text,
					HangPhim = txtHangphim.Text,
					NamSX = int.Parse(txtNamsanxuat.Text),
					NuocSX = txtNuocsanxuat.Text,
					DinhDang = cmbDinhdang.Text,
					ThoiLuong = (int)nudThoiluong.Value,
					GioiThieu = txtGioithieu.Text,
					CacDienVien = txtDienVien.Text,
					Trailer = txtTrailer.Text,
					Poster = linkposter,
					TheLoai = cmbTheloai.SelectedValue.ToString(),
					DiemBinhChon = 0
				};
				if (p.Poster == "")
					p.Poster = null;
				else
				{
					Copyfile(lblImage.Text, linkimage);
				}

				int rs = (int)PhimBus.ThemPhim(p);
				if (rs != 0)
				{
					MessageBox.Show("Thêm phim thành công!");
					this.Close();
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
				}
				else
					MessageBox.Show("Thêm phim thất bại, xin hãy thử lại !");
			}
			else
			{
				Phim p = new Phim
				{
					MaPhim = MaPhim,
					TenPhim = txtTenphim.Text,
					HangPhim = txtHangphim.Text,
					NamSX = Int32.Parse(txtNamsanxuat.Text),
					NuocSX = txtNuocsanxuat.Text,
					DinhDang = cmbDinhdang.Text,
					ThoiLuong = (int) nudThoiluong.Value,
					GioiThieu = txtGioithieu.Text,
					CacDienVien = txtDienVien.Text,
					Trailer = txtTrailer.Text,
					Poster = linkposter,
					TheLoai = cmbTheloai.SelectedValue.ToString()
				};
				if (p.Poster == "")

					p.Poster = linkimageold;
				else
				{
					Copyfile(lblImage.Text, linkimage);
				}

				int rs = (int)PhimBus.CapnhatPhim(p);
				if (rs != 0)
				{
					MessageBox.Show("Cập nhật thông tin thành công!");
					this.Close();
					this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
				}
				else
					MessageBox.Show("Cập nhật thất bại, xin hãy thử lại !");

			}

		}
		private void btnHuy_Click(object sender, EventArgs e)
		{
			if (btnHuy.Text == "Hủy")
			{
				this.Close();
				this.Dispose();
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
			}
			else
			{
				int rs;
				rs = (int)PhimBus.XoaPhimTheoMa(MaPhim);
				if (rs != 0)
				{
					MessageBox.Show("Xóa thành công!");
					this.Close();
					this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
				}
				else
				{
					MessageBox.Show("Không thể xóa, xin hãy thử lại !");
					this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
				}
			}
		}

		private void txtNamsanxuat_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtNuocsanxuat_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
