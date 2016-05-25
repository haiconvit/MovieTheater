using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmQLTrangthaiPhong : System.Windows.Forms.Form
	{

		public NguoiDung ND;
		public frmQLTrangthaiPhong()
		{
			InitializeComponent();
			dgvPhongchieu.ReadOnly = true;
		}

		private void frmQLTrangthaiPhong_Load(object sender, EventArgs e)
		{
			//colMa.DataPropertyName = "MaPhong";
			//colSohangghe.DataPropertyName = "SoHangGhe";
			//colSodayghe.DataPropertyName = "SoDayGhe";
			//colTinhtrang.DataPropertyName = "TinhTrang";
			//colKyThuat.DataPropertyName = "KyThuat";
			//colTenRap.DataPropertyName = "TenRap";

			List<PhongChieuPhim> ds = new List<PhongChieuPhim>();
			ds = PhongChieuPhimBus.LayDsPhongChieuPhim(ND.MaND);
			dgvPhongchieu.Rows.Clear();
			foreach (PhongChieuPhim pc in ds)
			{
				dgvPhongchieu.Rows.Add(pc.MaPhong, pc.SoHangGhe, pc.SoDayGhe, pc.TinhTrang, pc.KyThuat,RapChieuPhimBus.LayDsRapPhimTheoMa(pc.ThuocRap).TenRap);
			}
			cmbTinhtrangphong.Text = "-- Chọn tình trạng phòng --";
			Load_RapChieu();
			cmbDinhDang.Text = "-- Chọn định dạng --";
			cmbDinhDang.SelectedValue = "-- Chọn định dạng --";
		}

		private void txtTuKhoa_TextChanged(object sender, EventArgs e)
		{
			List<PhongChieuPhim> ds = new List<PhongChieuPhim>();
			ds = PhongChieuPhimBus.TimPhongTheoTuKhoa(txtTuKhoa.Text, ND.MaND);
			dgvPhongchieu.Rows.Clear();
			foreach (PhongChieuPhim pc in ds)
			{
				dgvPhongchieu.Rows.Add(pc.MaPhong, pc.SoHangGhe, pc.SoDayGhe, pc.TinhTrang, pc.KyThuat, RapChieuPhimBus.LayDsRapPhimTheoMa(pc.ThuocRap).TenRap);
			}
		}

		private void Load_RapChieu()
		{
			var dt = RapChieuPhimBus.LayRapAdmin(ND.MaND);
			var r = new RapChieuPhim();
			r.MaRap = "-- Chọn rạp chiếu --";
			r.TenRap = "-- Chọn rạp chiếu --";
			dt.Add(r);
			cmbRap.DataSource = dt;
			cmbRap.DisplayMember = "TenRap";
			cmbRap.ValueMember = "MaRap";
			cmbRap.SelectedValue = "-- Chọn rạp chiếu --";
		}
		private void btnTimPhongchieu_Click(object sender, EventArgs e)
		{
			List<PhongChieuPhim> dt = new List<PhongChieuPhim>();

			dt = PhongChieuPhimBus.TimPhongNangCao(cmbTinhtrangphong.SelectedItem.ToString(), cmbRap.SelectedValue.ToString(), cmbDinhDang.Text, ND.MaND);
			if (dt.Count == 0)
			{
				dgvPhongchieu.Rows.Clear();
				MessageBox.Show("Không tìm thấy Phòng chiếu thỏa điều kiện !");
			}
			else
			{
				dgvPhongchieu.Rows.Clear();
				foreach (PhongChieuPhim pc in dt)
				{
					dgvPhongchieu.Rows.Add(pc.MaPhong, pc.SoHangGhe, pc.SoDayGhe, pc.TinhTrang, pc.KyThuat, RapChieuPhimBus.LayDsRapPhimTheoMa(pc.ThuocRap).TenRap);
				}
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			int index = dgvPhongchieu.CurrentRow.Index;
			frmChitietPhong Chitietphong = new frmChitietPhong();
			Chitietphong.MaPhong = dgvPhongchieu.Rows[index].Cells["colMa"].Value.ToString();
			Chitietphong.checkform = false;
			Chitietphong.ShowDialog();
			dgvPhongchieu.Rows.Clear();
			List<PhongChieuPhim> ds = new List<PhongChieuPhim>();
			ds = PhongChieuPhimBus.LayDsPhongChieuPhim(ND.MaND);
			foreach (PhongChieuPhim pc in ds)
			{
				dgvPhongchieu.Rows.Add(pc.MaPhong, pc.SoHangGhe, pc.SoDayGhe, pc.TinhTrang, pc.KyThuat, RapChieuPhimBus.LayDsRapPhimTheoMa(pc.ThuocRap).TenRap);
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmChitietPhong Chitietphong = new frmChitietPhong();
			Chitietphong.name = "THÊM PHÒNG CHIẾU";
			Chitietphong.checkform = true;
			if (Chitietphong.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				this.frmQLTrangthaiPhong_Load(sender, e);
		}


	}
}
