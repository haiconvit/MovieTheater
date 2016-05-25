using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmChitietPhong : System.Windows.Forms.Form
	{
		public string name = "";
		public string MaPhong;
		public bool checkform;
		public frmChitietPhong()
		{
			InitializeComponent();
			nudDayghe.Maximum = 50;
			nudDayghe.Minimum = 1;
			nudHangghe.Maximum = 50;
			nudHangghe.Minimum = 1;

		}

		private void frmChitietPhong_Load(object sender, EventArgs e)
		{
			if (checkform == true)
			{
				lblTenForm.Text = "THÊM PHÒNG CHIẾU";
				this.Text = "Thêm phòng chiếu";
				btnThem.Text = "Thêm";
				btnHuy.Text = "Hủy";
				cmbKythuat.Text = "2D";
				cmbTinhtrang.Text = "đang hoạt động";
				Load_RapChieu();
			}
			else
			{
				lblTenForm.Text = "CHỈNH SỬA PHÒNG CHIẾU";
				this.Text = "CHỈNH SỬA PHÒNG CHIẾU";
				btnThem.Text = "Lưu";
				btnHuy.Text = "Xóa";
				txtMaphong.Enabled = false;
				PhongChieuPhim dt = new PhongChieuPhim();
				dt = PhongChieuPhimBus.LayPhongChieuTheoMa(MaPhong);
				txtMaphong.Text = MaPhong;
				nudHangghe.Value = dt.SoHangGhe.Value;
				nudDayghe.Value = dt.SoDayGhe.Value;

				cmbTinhtrang.Text = dt.TinhTrang;

				cmbKythuat.SelectedText = dt.KyThuat;
				cmbKythuat.Text = dt.KyThuat;

				Load_RapChieu();
				cmbRap.Text = dt.ThuocRap;
			}
		}

		private void Load_RapChieu()
		{
			var dt = RapChieuPhimBus.LayDsRapChieuPhim();
			cmbRap.DataSource = dt;
			cmbRap.DisplayMember = "TenRap";
			cmbRap.ValueMember = "MaRap";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (btnThem.Text == "Thêm")
			{
				List<PhongChieuPhim> dt = new List<PhongChieuPhim>();
				dt = PhongChieuPhimBus.LayDsPhongChieu();
				PhongChieuPhim p = new PhongChieuPhim
				{
					MaPhong = txtMaphong.Text,
					SoHangGhe = (int) nudHangghe.Value,
					SoDayGhe = (int) nudDayghe.Value,
					TinhTrang = cmbTinhtrang.Text.ToString(),
					KyThuat = cmbKythuat.Text,
					ThuocRap = cmbRap.SelectedValue.ToString()
				};
				foreach (PhongChieuPhim pc in dt)
				{
					if (p.MaPhong == pc.MaPhong)
					{
						MessageBox.Show("Mã phòng đã tồn tại");
						return;
					}
				}
				int rs = PhongChieuPhimBus.ThemPhongChieu(p);
				if (rs > 0)
				{
					MessageBox.Show("Thêm phòng chiếu thành công", "Congratulations");
					this.Close();
					DialogResult = System.Windows.Forms.DialogResult.OK;
				}
				else
					MessageBox.Show("Thêm thất bại, thử lại sau");
			}
			else
			{
				PhongChieuPhim p = new PhongChieuPhim();
                p.MaPhong = txtMaphong.Text;
                p.SoHangGhe = (int)nudHangghe.Value;
                p.SoDayGhe = (int)nudDayghe.Value;
                p.TinhTrang = cmbTinhtrang.SelectedItem.ToString();
                p.KyThuat = cmbKythuat.Text;
                p.ThuocRap = cmbRap.SelectedValue.ToString();
				int rs = PhongChieuPhimBus.UpdatePhongChieu(p);
				if (rs != 0)
				{
					MessageBox.Show("Update phòng chiếu thành công", "Congratulations");
					this.Close();
					DialogResult = System.Windows.Forms.DialogResult.Yes;
				}
				else
					MessageBox.Show("Update thất bại, thử lại sau !");
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			if (btnHuy.Text == "Hủy")
			{
				this.Close();
				DialogResult = System.Windows.Forms.DialogResult.No;
			}
			else
			{
				int rs = PhongChieuPhimBus.DeletePhongChieu(txtMaphong.Text);
				if (rs != 0)
				{
					MessageBox.Show("Xóa phòng chiếu thành công!");
					this.Close();
					DialogResult = System.Windows.Forms.DialogResult.Cancel;
				}
				else
				{
					MessageBox.Show("Không thể xóa, hãy thử lại !");
					this.Close();
					DialogResult = System.Windows.Forms.DialogResult.Cancel;
				}

			}
		}
	}
}
