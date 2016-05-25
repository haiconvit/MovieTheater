using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmQuanlyPhim : System.Windows.Forms.Form
	{
		public NguoiDung ND;
		public frmQuanlyPhim()
		{
			InitializeComponent();

			dgvQuanlyPhim.ReadOnly = true;

			//dgvQuanlyPhim.Columns["colMaPhim"].DataPropertyName = "MaPhim";
			//dgvQuanlyPhim.Columns["colPhim"].DataPropertyName = "TenPhim";
			//dgvQuanlyPhim.Columns["colHangphim"].DataPropertyName = "HangPhim";
			//dgvQuanlyPhim.Columns["colNamSX"].DataPropertyName = "NamSX";
			//dgvQuanlyPhim.Columns["colDinhdang"].DataPropertyName = "DinhDang";
			//dgvQuanlyPhim.Columns["colThoiLuong"].DataPropertyName = "ThoiLuong";
			//dgvQuanlyPhim.Columns["colTheLoai"].DataPropertyName = "TenTheLoai";
			//dgvQuanlyPhim.Columns["colNuocSX"].DataPropertyName = "NuocSX";
			//dgvQuanlyPhim.Columns["colDiemBinhChon"].DataPropertyName = "DiemBinhChon";
			cbxDinhDang.Text = "-- Chọn định dạng --";
			LoadCBXTheLoai();
			LoadCBXHangPhim();
			LoadCBXQuocGia();
			List<Phim> ds = new List<Phim>();
			ds = PhimBus.LayDsPhim();
			foreach (Phim p in ds)
			{
				TheLoaiPhim tl = new TheLoaiPhim();
				tl.MaTheLoai = p.TheLoai;
				dgvQuanlyPhim.Rows.Add(p.MaPhim, p.TenPhim, p.HangPhim, p.NamSX, p.NuocSX, p.DinhDang, p.ThoiLuong, TheLoaiPhimBus.LayTenTheLoai(tl), p.DiemBinhChon);
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmChitietPhim Chitietphim = new frmChitietPhim();
			Chitietphim.lblTen = "ĐĂNG KÝ PHIM";
			Chitietphim.checkform = true;
			if (Chitietphim.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				dgvQuanlyPhim.Rows.Clear();
				List<Phim> ds = new List<Phim>();
				ds = PhimBus.LayDsPhim();
				foreach (Phim p in ds)
				{
					TheLoaiPhim tl = new TheLoaiPhim();
					tl.MaTheLoai = p.TheLoai;
					dgvQuanlyPhim.Rows.Add(p.MaPhim, p.TenPhim, p.HangPhim, p.NamSX, p.NuocSX, p.DinhDang, p.ThoiLuong, TheLoaiPhimBus.LayTenTheLoai(tl), p.DiemBinhChon);
				}
			}
		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			int index = dgvQuanlyPhim.CurrentRow.Index;
			frmChitietPhim Chitietphim = new frmChitietPhim();
			Chitietphim.lblTen = "CHI TIẾT PHIM";
			Chitietphim.checkform = false;
			Chitietphim.MaPhim = (int)dgvQuanlyPhim.Rows[index].Cells["colMaPhim"].Value;
			if (Chitietphim.ShowDialog() == System.Windows.Forms.DialogResult.Ignore)
			{
				dgvQuanlyPhim.Rows.Clear();
				List<Phim> ds = new List<Phim>();
				ds = PhimBus.LayDsPhim();
				foreach (Phim p in ds)
				{
					TheLoaiPhim tl = new TheLoaiPhim();
					tl.MaTheLoai = p.TheLoai;
					dgvQuanlyPhim.Rows.Add(p.MaPhim, p.TenPhim, p.HangPhim, p.NamSX, p.NuocSX, p.DinhDang, p.ThoiLuong, TheLoaiPhimBus.LayTenTheLoai(tl), p.DiemBinhChon);
				}
			}
		}
		private void frmQuanlyPhim_Load(object sender, EventArgs e)
		{

		}
		#region Load Combobox
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
		void LoadCBXHangPhim()
		{
			List<Phim> dt = new List<Phim>();
			dt = PhimBus.LayDsPhim();
			Phim p = new Phim();
			p.HangPhim = "-- Hãng Phim --";
			dt.Add(p);
			cmbHangPhim.DataSource = dt;
			cmbHangPhim.DisplayMember = "HangPhim";
			cmbHangPhim.ValueMember = "HangPhim";
			cmbHangPhim.SelectedValue = "-- Hãng Phim --";
		}

		void LoadCBXQuocGia()
		{
			List<Phim> dt = new List<Phim>();
			dt = PhimBus.LayDsPhim();
			Phim p = new Phim();
			p.NuocSX = "-- Chọn quốc gia --";
			dt.Add(p);
			cmbNuocSX.DataSource = dt;
			cmbNuocSX.DisplayMember = "NuocSX";
			cmbNuocSX.ValueMember = "NuocSX";
			cmbNuocSX.SelectedValue = "-- Chọn quốc gia --";
		}
		#endregion

		private void btnTimPhim_Click(object sender, EventArgs e)
		{
			List<Phim> ds = new List<Phim>();
			ds = PhimBus.TimPhimNangCao(cbxDinhDang.Text, (string)cbxTheLoai.SelectedValue, cmbHangPhim.SelectedValue.ToString(), cmbNuocSX.SelectedValue.ToString());
			if (ds.Count == 0)
			{
				dgvQuanlyPhim.Rows.Clear();
				MessageBox.Show("Không có Phim thỏa điều kiện !");
			}
			else
			{
				dgvQuanlyPhim.Rows.Clear();
				foreach (Phim p in ds)
				{
					TheLoaiPhim tl = new TheLoaiPhim();
					tl.MaTheLoai = p.TheLoai;
					dgvQuanlyPhim.Rows.Add(p.MaPhim, p.TenPhim, p.HangPhim, p.NamSX, p.NuocSX, p.DinhDang, p.ThoiLuong, TheLoaiPhimBus.LayTenTheLoai(tl), p.DiemBinhChon);
				}
			}

		}
		private void txtTuKhoa_TextChanged(object sender, EventArgs e)
		{
			List<Phim> ds = new List<Phim>();
			ds = PhimBus.TimPhimTheoTuKhoa(txtTuKhoa.Text);
			dgvQuanlyPhim.Rows.Clear();
			foreach (Phim p in ds)
			{
				TheLoaiPhim tl = new TheLoaiPhim();
				tl.MaTheLoai = p.TheLoai;
				dgvQuanlyPhim.Rows.Add(p.MaPhim, p.TenPhim, p.HangPhim, p.NamSX, p.NuocSX, p.DinhDang, p.ThoiLuong, TheLoaiPhimBus.LayTenTheLoai(tl), p.DiemBinhChon);
			}
		}

	}
}
