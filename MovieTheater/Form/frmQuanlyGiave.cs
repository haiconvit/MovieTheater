using System;
using System.Collections.Generic;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmQuanlyGiave : System.Windows.Forms.Form
	{
		public frmQuanlyGiave()
		{
			InitializeComponent();
			dgvNgayle.ReadOnly = true;
			dgvNgayLe_3D.ReadOnly = true;
			dgvThu2_3D.ReadOnly = true;
			dgvThu246.ReadOnly = true;
			dgvThu3.ReadOnly = true;
			dgvThu3_3D.ReadOnly = true;
			dgvThu7_3D.ReadOnly = true;
			dgvThu7CN.ReadOnly = true; ;
		}


		private void frmQuanlyGiave_Load(object sender, EventArgs e)
		{
			Load_Thu2456_2D();
			Load_Thu3_2D();
			Load_Thu7CN_2D();
			Load_NgayLe_2D();
			Load_Thu2456_3D();
			Load_Thu3_3D();
			Load_Thu7CN_3D();
			Load_NgayLe_3D();
		}
		#region Load Giave 2D
		private void Load_Thu2456_2D()
		{
			colNguoilon.DataPropertyName = "NguoiLon";
			colSinhvien.DataPropertyName = "SinhVien";
			colTreem.DataPropertyName = "TreEm";
			colThoigian.DataPropertyName = "TenLoaiTG";
			List<GiaVe> ds = new List<GiaVe>();
			ds = GiaVeBus.LayDsGiaVeThu2456();
			dgvThu246.Rows.Clear();
			foreach (GiaVe g in ds)
			{
				dgvThu246.Rows.Add((LoaiThoiGianBus.LayLoaiThoiGianTheoMa(g.ThoiGian)).TenLoaiTG, g.NguoiLon, g.SinhVien, g.TreEm);
			}

		}
		private void Load_Thu3_2D()
		{
			colNguoiLonThu3.DataPropertyName = "NguoiLon";
			colSinhVienThu3.DataPropertyName = "SinhVien";
			colTreEmThu3.DataPropertyName = "TreEm";
			colThoiGianT3.DataPropertyName = "TenLoaiTG";
			List<GiaVe> ds = new List<GiaVe>();
			ds = GiaVeBus.LayDsGiaVeThu3();
			dgvThu3.Rows.Clear();
			foreach (GiaVe g in ds)
			{
				dgvThu3.Rows.Add((LoaiThoiGianBus.LayLoaiThoiGianTheoMa(g.ThoiGian)).TenLoaiTG, g.NguoiLon, g.SinhVien, g.TreEm);
			}
		}
		private void Load_Thu7CN_2D()
		{

			colNguoiLonThu7.DataPropertyName = "NguoiLon";
			colSinhVienThu7.DataPropertyName = "SinhVien";
			colTreEmThu7.DataPropertyName = "TreEm";
			colThoiGianThu7.DataPropertyName = "TenLoaiTG";
			List<GiaVe> ds = new List<GiaVe>();
			ds = GiaVeBus.LayDsGiaVeThu7Cn();
			dgvThu7CN.Rows.Clear();
			foreach (GiaVe g in ds)
			{
				dgvThu7CN.Rows.Add((LoaiThoiGianBus.LayLoaiThoiGianTheoMa(g.ThoiGian)).TenLoaiTG, g.NguoiLon, g.SinhVien, g.TreEm);
			}
		}
		private void Load_NgayLe_2D()
		{
			colNguoiLonLe.DataPropertyName = "NguoiLon";
			colSinhVienLe.DataPropertyName = "SinhVien";
			colTreEmLe.DataPropertyName = "TreEm";
			colThoiGianLe.DataPropertyName = "TenLoaiTG";
			List<GiaVe> ds = new List<GiaVe>();
			ds = GiaVeBus.LayDsGiaVeNgayle();
			dgvNgayle.Rows.Clear();
			foreach (GiaVe g in ds)
			{
				dgvNgayle.Rows.Add((LoaiThoiGianBus.LayLoaiThoiGianTheoMa(g.ThoiGian)).TenLoaiTG, g.NguoiLon, g.SinhVien, g.TreEm);
			}
		}
		#endregion

		#region GiaVe 3D
		private void Load_Thu2456_3D()
		{
			colNguoiLon_Thu2_3D.DataPropertyName = "NguoiLon";
			colSinhVien_Thu2_3D.DataPropertyName = "SinhVien";
			colTreEm_Thu2_3D.DataPropertyName = "TreEm";
			colThoiGian_Thu2_3D.DataPropertyName = "TenLoaiTG";
			List<GiaVe> ds = new List<GiaVe>();
			ds = GiaVeBus.LayDSGiaVeThu2456_3D();
			dgvThu2_3D.Rows.Clear();
			foreach (GiaVe g in ds)
			{
				dgvThu2_3D.Rows.Add((LoaiThoiGianBus.LayLoaiThoiGianTheoMa(g.ThoiGian)).TenLoaiTG, g.NguoiLon, g.SinhVien, g.TreEm);
			}
		}
		private void Load_Thu3_3D()
		{
			colNguoiLon_Thu3_3D.DataPropertyName = "NguoiLon";
			colSinhVien_Thu3_3D.DataPropertyName = "SinhVien";
			colTreEm_Thu3_3D.DataPropertyName = "TreEm";
			colThoiGian_Thu3_3D.DataPropertyName = "TenLoaiTG";
			List<GiaVe> ds = new List<GiaVe>();
			ds = GiaVeBus.LayDSGiaVeThu3_3D();
			dgvThu3_3D.Rows.Clear();
			foreach (GiaVe g in ds)
			{
				dgvThu3_3D.Rows.Add((LoaiThoiGianBus.LayLoaiThoiGianTheoMa(g.ThoiGian)).TenLoaiTG, g.NguoiLon, g.SinhVien, g.TreEm);
			}
		}
		private void Load_Thu7CN_3D()
		{
			colNguoiLon_Thu7_3D.DataPropertyName = "NguoiLon";
			colSinhVien_Thu7_3D.DataPropertyName = "SinhVien";
			colTreEm_Thu7_3D.DataPropertyName = "TreEm";
			colThoiGian_Thu7_3D.DataPropertyName = "TenLoaiTG";
			List<GiaVe> ds = new List<GiaVe>();
			ds = GiaVeBus.LayDSGiaVeThu7CN_3D();
			dgvThu7_3D.Rows.Clear();
			foreach (GiaVe g in ds)
			{
				dgvThu7_3D.Rows.Add((LoaiThoiGianBus.LayLoaiThoiGianTheoMa(g.ThoiGian)).TenLoaiTG, g.NguoiLon, g.SinhVien, g.TreEm);
			}
		}
		private void Load_NgayLe_3D()
		{
			colNguoiLon_Le_3D.DataPropertyName = "NguoiLon";
			colSinhVien_Le_3D.DataPropertyName = "SinhVien";
			colTreEm_Le_3D.DataPropertyName = "TreEm";
			colThoiGian_Le_3D.DataPropertyName = "TenLoaiTG";
			List<GiaVe> ds = new List<GiaVe>();
			ds = GiaVeBus.LayDSGiaVeNgayle_3D();
			dgvNgayLe_3D.Rows.Clear();
			foreach (GiaVe g in ds)
			{
				dgvNgayLe_3D.Rows.Add((LoaiThoiGianBus.LayLoaiThoiGianTheoMa(g.ThoiGian)).TenLoaiTG, g.NguoiLon, g.SinhVien, g.TreEm);
			}
		}
		#endregion

		#region Button Edit 2D
		private void btn2D_Thu2_Click(object sender, EventArgs e)
		{
			frmChiTietGiaVe frm = new frmChiTietGiaVe();
			frm.LoaiNgay = "1";
			frm.tenForm = "THỨ 2,4,5,6 - ĐỊNH DẠNG 2D";
			frm.DinhDang = "2D";
			if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Load_Thu2456_2D();
			}
		}

		private void btn2D_Thu3_Click(object sender, EventArgs e)
		{
			frmChiTietGiaVe frm = new frmChiTietGiaVe();
			frm.LoaiNgay = "2";
			frm.tenForm = "THỨ 3 - ĐỊNH DẠNG 2D";
			frm.DinhDang = "2D";
			if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Load_Thu3_2D();
			}
		}

		private void btn2D_Thu7_Click(object sender, EventArgs e)
		{
			frmChiTietGiaVe frm = new frmChiTietGiaVe();
			frm.LoaiNgay = "3";
			frm.tenForm = "THỨ 7 - ĐỊNH DẠNG 2D";
			frm.DinhDang = "2D";
			if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Load_Thu7CN_2D();
			}
		}

		private void btn2D_Le_Click(object sender, EventArgs e)
		{

			frmChiTietGiaVe frm = new frmChiTietGiaVe();
			frm.LoaiNgay = "4";
			frm.tenForm = "NGÀY LỄ - ĐỊNH DẠNG 2D";
			frm.DinhDang = "2D";
			if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Load_NgayLe_2D();
			}
		}
		#endregion

		private void btn3D_Thu2_Click(object sender, EventArgs e)
		{
			frmChiTietGiaVe frm = new frmChiTietGiaVe();
			frm.LoaiNgay = "1";
			frm.tenForm = "THỨ 2,4,5,6 - ĐỊNH DẠNG 3D";
			frm.DinhDang = "3D";
			if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Load_Thu2456_3D();
			}
		}

		private void btn3D_Thu3_Click(object sender, EventArgs e)
		{
			frmChiTietGiaVe frm = new frmChiTietGiaVe();
			frm.LoaiNgay = "2";
			frm.tenForm = "THỨ 3 - ĐỊNH DẠNG 3D";
			frm.DinhDang = "3D";
			if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Load_Thu3_3D();
			}
		}

		private void btn3D_Thu7_Click(object sender, EventArgs e)
		{
			frmChiTietGiaVe frm = new frmChiTietGiaVe();
			frm.LoaiNgay = "3";
			frm.tenForm = "THỨ 7, CHỦ NHẬT - ĐỊNH DẠNG 3D";
			frm.DinhDang = "3D";
			if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Load_Thu7CN_3D();
			}
		}

		private void btn3D_Le_Click(object sender, EventArgs e)
		{
			frmChiTietGiaVe frm = new frmChiTietGiaVe();
			frm.LoaiNgay = "4";
			frm.tenForm = "CÁC NGÀY LỄ - ĐỊNH DẠNG 3D";
			frm.DinhDang = "3D";
			if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Load_NgayLe_3D();
			}
		}


	}
}
