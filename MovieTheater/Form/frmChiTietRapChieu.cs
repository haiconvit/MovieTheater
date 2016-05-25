using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmChiTietRapChieu : System.Windows.Forms.Form
	{
		public bool checkform;
		public string MaRap;
		public NguoiDung ND;
		public frmChiTietRapChieu()
		{
			InitializeComponent();
		}

		private void frmChiTietRapChieu_Load(object sender, EventArgs e)
		{
			if (checkform == true)
			{
				btnThem.Text = "Thêm";
				btnHuy.Text = "Hủy";
				nudSoPhongChieu.Enabled = false;
			}
			else
			{
				nudSoPhongChieu.Enabled = true;
				lblTenRap.Text = "CHI TIẾT RẠP CHIẾU";
				btnThem.Text = "Lưu";
				btnHuy.Text = "Xóa";
				txtMaRap.Enabled = false;
				RapChieuPhim dt = new RapChieuPhim();

				dt = RapChieuPhimBus.LayDsRapPhimTheoMa(MaRap);
				txtMaRap.Text = MaRap;
				txtTenRap.Text = dt.TenRap;
				txtDiaChi.Text = dt.DiaChi;

				nudSoPhongChieu.Value = dt.SoPhongChieu.Value;
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (btnThem.Text == "Thêm")
			{
				List<RapChieuPhim> dt = RapChieuPhimBus.LayMaRap();
				RapChieuPhim r = new RapChieuPhim();
                r.MaRap = txtMaRap.Text;
                r.TenRap = txtTenRap.Text;
                r.DiaChi = txtDiaChi.Text;
                r.SoPhongChieu = (int)nudSoPhongChieu.Value;
                r.ChuRap = ND.MaND;
				for (int i = 0; i < dt.Count; i++)
				{
					if (r.MaRap == dt[i].MaRap)
					{
						MessageBox.Show("Mã Rạp đã tồn tại, hãy thử lại!");
						return;
					}
				}
				int rs = RapChieuPhimBus.ThemRapChieuPhim(r);
				if (rs != 0)
				{
					MessageBox.Show("Thêm thành công!");
					this.Close();
				}
				else
				{
					MessageBox.Show("Thêm thất bại, mời thử lại sau!");
				}
			}
			else
			{
				RapChieuPhim r = new RapChieuPhim();
                r.MaRap = txtMaRap.Text;
                r.TenRap = txtTenRap.Text;
                r.DiaChi = txtDiaChi.Text;
                r.SoPhongChieu = int.Parse(nudSoPhongChieu.Value.ToString());
                r.ChuRap = ND.MaND;
				int rs = RapChieuPhimBus.UpdateRapChieuPhim(r);
				if (rs != 0)
				{
					MessageBox.Show("Update thành công!");
					this.Close();
				}
				else
				{
					MessageBox.Show("Update thất bại, mời thử lại sau!");
				}
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			if (btnHuy.Text == "Hủy")
			{
				this.Close();
			}
			else
			{
				int rs = RapChieuPhimBus.DeleteRapChieuPhim(MaRap);
				if (rs != 0)
				{
					MessageBox.Show("Xóa thành công !");
					this.Close();
				}
				else
				{
					MessageBox.Show("Xóa không thành công!, Mời thử lại!");
					this.Close();
				}
			}
		}
	}
}
