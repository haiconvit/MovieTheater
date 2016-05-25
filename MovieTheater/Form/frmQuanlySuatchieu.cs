using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmQuanlySuatchieu : System.Windows.Forms.Form
	{
		public NguoiDung ND;
		public frmQuanlySuatchieu()
		{
			InitializeComponent();
			dtpNgayChieu.Enabled = false;
			dgvQuanlySuatchieu.ReadOnly = true;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmDangkySuatchieu DangKySuatchieu = new frmDangkySuatchieu();
			DangKySuatchieu.lblTen.Text = "ĐĂNG KÝ SUẤT CHIẾU";
			DangKySuatchieu.name = "ĐĂNG KÝ SUẤT CHIẾU";
			DangKySuatchieu.FormThem = true;
			DangKySuatchieu.ND = ND;
			DangKySuatchieu.ShowDialog();

			var dt = SuatChieuBus.LaySuatChieuAdmin(ND.MaND);
			dgvQuanlySuatchieu.Rows.Clear();
			foreach (SuatChieu sc in dt)
			{
				dgvQuanlySuatchieu.Rows.Add(sc.MaSuatChieu, sc.Phong, PhimBus.LayPhimTheoMa(sc.Phim.Value).TenPhim, sc.CaChieu, sc.NgayChieu);
			}

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			int index = dgvQuanlySuatchieu.CurrentRow.Index;
			frmDangkySuatchieu DangKySuatchieu = new frmDangkySuatchieu();
			DangKySuatchieu.lblTen.Text = "CHI TIẾT SUẤT CHIẾU";
			DangKySuatchieu.name = "CHI TIẾT SUẤT CHIẾU";
			DangKySuatchieu.FormThem = false;
			DangKySuatchieu.ND = ND;
			DangKySuatchieu.masc = (int)(dgvQuanlySuatchieu.Rows[index].Cells["colMa"].Value);
			DangKySuatchieu.ShowDialog();
			var dt = SuatChieuBus.LaySuatChieuAdmin(ND.MaND);
			dgvQuanlySuatchieu.Rows.Clear();
			foreach (SuatChieu sc in dt)
			{
				dgvQuanlySuatchieu.Rows.Add(sc.MaSuatChieu, sc.Phong, PhimBus.LayPhimTheoMa(sc.Phim.Value).TenPhim, sc.CaChieu, sc.NgayChieu);
			}
		}

		private void txtTuKhoa_TextChanged(object sender, EventArgs e)
		{

			var ds = SuatChieuBus.LaySuatChieuTheoTenPhim(txtTuKhoa.Text);
			dgvQuanlySuatchieu.Rows.Clear();
			foreach (SuatChieu sc in ds)
			{
				dgvQuanlySuatchieu.Rows.Add(sc.MaSuatChieu, sc.Phong, PhimBus.LayPhimTheoMa(sc.Phim.Value).TenPhim, sc.CaChieu, sc.NgayChieu);
			}
		}
		#region Load Combobox
		void LoadCBXRap()
		{
			var dt = RapChieuPhimBus.LayRapAdmin(ND.MaND);
			var r = new RapChieuPhim();
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
		#endregion

		private void btnTimSuatChieu_Click(object sender, EventArgs e)
		{
			List<SuatChieu> dt = new List<SuatChieu>();
			DateTime ngay = new DateTime();
			if (ckbNgaychieu.Checked == true)
			{
				ngay = dtpNgayChieu.Value;
			}
			else
				ngay = new DateTime(1, 1, 1);
			dt = SuatChieuBus.TimSuatChieuNangCao(ngay, (string)cbxRap.SelectedValue, cbxDinhDang.Text, (string)cbxTheLoai.SelectedValue, (int)cbxCaChieu.SelectedValue);
			if (dt.Count == 0)
			{
				MessageBox.Show("Không có suất chiếu thỏa điều kiện !");
			}
			else
			{
				dgvQuanlySuatchieu.Rows.Clear();
				foreach (SuatChieu sc in dt)
				{
					dgvQuanlySuatchieu.Rows.Add(sc.MaSuatChieu, sc.Phong, PhimBus.LayPhimTheoMa(sc.Phim.Value).TenPhim, sc.CaChieu, sc.NgayChieu);
				}
			}
		}

		private void frmQuanlySuatchieu_Load(object sender, EventArgs e)
		{
			List<SuatChieu> dt = new List<SuatChieu>();
			dt = SuatChieuBus.LaySuatChieuAdmin(ND.MaND);
			foreach (SuatChieu sc in dt)
			{
				dgvQuanlySuatchieu.Rows.Add(sc.MaSuatChieu, sc.Phong, PhimBus.LayPhimTheoMa(sc.Phim.Value).TenPhim, sc.CaChieu, sc.NgayChieu);
			}
			LoadCBXRap();
			cbxDinhDang.Text = "-- Chọn định dạng --";
			LoadCBXTheLoai();
			LoadCBXCaChieu();
		}

		private void ckbNgaychieu_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbNgaychieu.Checked == true)
				dtpNgayChieu.Enabled = true;
			else
				dtpNgayChieu.Enabled = false;
		}

	}
}
