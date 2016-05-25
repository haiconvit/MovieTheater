using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmChiTietGiaVe : System.Windows.Forms.Form
	{
		public string LoaiNgay;
		public string DinhDang;
		public string tenForm;
		public frmChiTietGiaVe()
		{
			InitializeComponent();
			nudNguoiLon_1.Minimum = 5000;
			nudNguoiLon_1.Maximum = 200000;
			nudNguoiLon_1.Increment = 5000;
			nudSinhVien_1.Minimum = 5000;
			nudSinhVien_1.Maximum = 200000;
			nudSinhVien_1.Increment = 5000;
			nudTreEm_1.Minimum = 5000;
			nudTreEm_1.Maximum = 200000;
			nudTreEm_1.Increment = 5000;
			nudNguoiLon_2.Minimum = 5000;
			nudNguoiLon_2.Maximum = 200000;
			nudNguoiLon_2.Increment = 5000;
			nudSinhVien_2.Minimum = 5000;
			nudSinhVien_2.Maximum = 200000;
			nudSinhVien_2.Increment = 5000;
			nudTreEm_2.Minimum = 5000;
			nudTreEm_2.Maximum = 200000;
			nudTreEm_2.Increment = 5000;
		}
		private float NguoiLon1Old, SinhVien1Old, TreEm1Old;
		private float NguoiLon2Old, SinhVien2Old, TreEm2Old;
		private void frmChiTietGiaVe_Load(object sender, EventArgs e)
		{
			if (DinhDang == "2D")
			{
				this.Text = tenForm;
				lblNgay.Text = tenForm;
				List<GiaVe> dt = new List<GiaVe>();
				dt = GiaVeBus.LayGiaVeTheoMa_2D(LoaiNgay);

				NguoiLon1Old = dt[0].NguoiLon.Value;
				SinhVien1Old = dt[0].SinhVien.Value;
				TreEm1Old = dt[0].TreEm.Value;
				NguoiLon2Old = dt[1].NguoiLon.Value;
				SinhVien2Old = dt[1].SinhVien.Value;
				TreEm2Old = dt[1].TreEm.Value;

				nudNguoiLon_1.Value = Convert.ToInt32(dt[0].NguoiLon);
				nudSinhVien_1.Value = Convert.ToInt32(dt[0].SinhVien);
				nudTreEm_1.Value = Convert.ToInt32(dt[0].TreEm);
				nudNguoiLon_2.Value = Convert.ToInt32(dt[1].NguoiLon);
				nudSinhVien_2.Value = Convert.ToInt32(dt[1].SinhVien);
				nudTreEm_2.Value = Convert.ToInt32(dt[1].TreEm);
			}
			else
			{
				this.Text = tenForm;
				lblNgay.Text = tenForm;
				List<GiaVe> dt = new List<GiaVe>();
				dt = GiaVeBus.LayGiaVeTheoMa_3D(LoaiNgay);

				NguoiLon1Old = dt[0].NguoiLon.Value;
				SinhVien1Old = dt[0].SinhVien.Value;
				TreEm1Old = dt[0].TreEm.Value;
				NguoiLon2Old = dt[1].NguoiLon.Value;
				SinhVien2Old = dt[1].SinhVien.Value;
				TreEm2Old = dt[1].TreEm.Value;

				nudNguoiLon_1.Value = Convert.ToInt32(dt[0].NguoiLon);
				nudSinhVien_1.Value = Convert.ToInt32(dt[0].SinhVien);
				nudTreEm_1.Value = Convert.ToInt32(dt[0].TreEm);
				nudNguoiLon_2.Value = Convert.ToInt32(dt[1].NguoiLon);
				nudSinhVien_2.Value = Convert.ToInt32(dt[1].SinhVien);
				nudTreEm_2.Value = Convert.ToInt32(dt[1].TreEm);
			}

		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			int dem = 0;
			if (nudNguoiLon_1.Value != Convert.ToInt32(NguoiLon1Old) || nudSinhVien_1.Value != Convert.ToInt32(SinhVien1Old) || nudTreEm_1.Value != Convert.ToInt32(TreEm1Old))
			{
				int Thoigian = 1;
				int rs = GiaVeBus.Update((int)nudNguoiLon_1.Value, (int)nudSinhVien_1.Value, (int)nudTreEm_1.Value, DinhDang, LoaiNgay, Thoigian);
				if (rs != 0)
					MessageBox.Show("Cập nhật thành công!");
				dem++;
			}
			if (nudNguoiLon_2.Value != Convert.ToInt32(NguoiLon2Old) || nudSinhVien_2.Value != Convert.ToInt32(SinhVien2Old) || nudTreEm_2.Value != Convert.ToInt32(TreEm2Old))
			{
				int Thoigian = 2;
				int rs = GiaVeBus.Update((int)nudNguoiLon_2.Value, (int)nudSinhVien_2.Value, (int)nudTreEm_2.Value, DinhDang, LoaiNgay, Thoigian);
				if (rs != 0)
					MessageBox.Show("Cập nhật thành công!");
				dem++;
			}
			if (dem == 2)
			{
				MessageBox.Show("Cập nhật thành công!");
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
			DialogResult = System.Windows.Forms.DialogResult.OK;
		}
	}
}
