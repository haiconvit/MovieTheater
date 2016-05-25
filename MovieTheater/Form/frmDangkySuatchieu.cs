using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmDangkySuatchieu : System.Windows.Forms.Form
	{
		public Label lblTen = new Label();
		public string name;
		public bool FormThem;
		public int masc;
		public NguoiDung ND;
		public frmDangkySuatchieu()
		{
			InitializeComponent();
		}

		private void frmDangkySuatchieu_Load(object sender, EventArgs e)
		{
			this.Text = name;
			if (FormThem == true)
			{
				btnThem.Text = "Thêm";
				btnHuy.Text = "Hủy";

				cmbCachieu.DataSource = CaChieuPhimBus.LayDsCaChieuPhim();
				cmbCachieu.DisplayMember = "ThoiGianBD";
				cmbCachieu.ValueMember = "MaCa";

				cmbPhim.DataSource = PhimBus.LayDsPhim();
				cmbPhim.DisplayMember = "TenPhim";
				cmbPhim.ValueMember = "MaPhim";
				lblTenForm.Text = lblTen.Text;
				// lấy phòng chiếu Admin đang hoạt động
				cmbPhong.DataSource = PhongChieuPhimBus.LayDsPhongDangHoatDong(ND.MaND);
				cmbPhong.DisplayMember = "MaPhong";
				cmbPhong.ValueMember = "MaPhong";
			}
			else
			{
				btnThem.Text = "Lưu";
				btnHuy.Text = "Xóa";
				SuatChieu dt = new SuatChieu();
				dt = SuatChieuBus.LaySuatChieuTheoMa(masc);
				txtMasuatchieu.Text = masc.ToString();

				dtpNgaychieu.Value = dt.NgayChieu.Value;
				cmbCachieu.DataSource = CaChieuPhimBus.LayDsCaChieuPhim();
				cmbCachieu.DisplayMember = "ThoiGianBD";
				cmbCachieu.ValueMember = "MaCa";
				cmbCachieu.SelectedValue = dt.CaChieu;

				cmbPhim.DataSource = PhimBus.LayDsPhim();
				cmbPhim.DisplayMember = "TenPhim";
				cmbPhim.ValueMember = "MaPhim";
				cmbPhim.SelectedValue = dt.Phim;
				lblTenForm.Text = lblTen.Text;
				cmbPhong.DataSource = PhongChieuPhimBus.LayDsPhongDangHoatDong(ND.MaND);
				cmbPhong.DisplayMember = "MaPhong";
				cmbPhong.ValueMember = "MaPhong";
				cmbPhong.SelectedValue = dt.Phong;
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (btnThem.Text == "Thêm")
			{
				int rs;
				List<SuatChieu> dt = new List<SuatChieu>();
				dt = SuatChieuBus.LaySuatChieuAdmin(ND.MaND);
				foreach (SuatChieu r in dt)
				{
					if (r.Phong == cmbPhong.SelectedValue.ToString() && r.CaChieu == (int)cmbCachieu.SelectedValue && r.NgayChieu == dtpNgaychieu.Value)
					{
						MessageBox.Show("Suất chiếu đã tồn tại, mời thử lại !");
						return;
					}
				}
				rs = (int)SuatChieuBus.ThemSuatChieu(cmbPhong.SelectedValue.ToString(), (int)cmbCachieu.SelectedValue, (int)cmbPhim.SelectedValue, dtpNgaychieu.Value);
				if (rs != 0)
				{
					MessageBox.Show("Thêm Suất chiếu thành công!");
					this.Close();
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
				}
				else
					MessageBox.Show("Thêm Suất chiếu thất bại, xin hãy thử lại !");
			}
			else
			{
				List<SuatChieu> dt = new List<SuatChieu>();
				dt = SuatChieuBus.LaySuatChieuAdmin(ND.MaND);

				foreach (SuatChieu r in dt)
				{
					if (r.Phong == cmbPhong.SelectedValue.ToString() && r.CaChieu == (int)cmbCachieu.SelectedValue && r.NgayChieu == dtpNgaychieu.Value.Date)
					{
						MessageBox.Show("Suất chiếu đã tồn tại, mời thử lại !");
						return;
					}
				}
				int rs;
				rs = (int)SuatChieuBus.CapnhatSuatChieu(cmbPhong.SelectedValue.ToString(), (int)cmbCachieu.SelectedValue, (int)cmbPhim.SelectedValue, dtpNgaychieu.Value, masc);
				if (rs != 0)
				{
					MessageBox.Show("Cập nhật thành công!");
					this.Close();
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
			}
			else
			{
				int rs;
				VeBus.XoaveTheoSuatChieu(masc);
				rs = (int)SuatChieuBus.XoaSuatChieu(masc);
				if (rs != 0)
				{
					MessageBox.Show("Xóa thành công!");
					this.Close();
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
				}
				else
				{
					MessageBox.Show("Không thể xóa, xin hãy thử lại !");
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
				}

			}

		}
	}
}
