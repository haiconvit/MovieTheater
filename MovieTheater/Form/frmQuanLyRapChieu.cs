using System;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmQuanLyRapChieu : System.Windows.Forms.Form
	{
		public NguoiDung ND;
		public frmQuanLyRapChieu()
		{
			InitializeComponent();
		}

		private void frmQuanLyRapChieu_Load(object sender, EventArgs e)
		{
			dgvRapChieu.Rows.Clear();
			var dsRap = RapChieuPhimBus.LayRapAdmin(ND.MaND);
			foreach (RapChieuPhim r in dsRap)
			{
				dgvRapChieu.Rows.Add(r.MaRap, r.TenRap, r.DiaChi, r.SoPhongChieu, NguoiDungBus.LayNguoiDungTheoMa(r.ChuRap.Value).HoTen);
			}
		}

		private void txtKeyword_TextChanged(object sender, EventArgs e)
		{
			dgvRapChieu.Rows.Clear();
			var dsRap = RapChieuPhimBus.TimKiemRapTheoTuKhoa(txtKeyword.Text, ND.MaND);
			foreach (RapChieuPhim r in dsRap)
			{
				dgvRapChieu.Rows.Add(r.MaRap, r.TenRap, r.DiaChi, r.SoPhongChieu, NguoiDungBus.LayNguoiDungTheoMa(r.ChuRap.Value).HoTen);
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			frmChiTietRapChieu ct = new frmChiTietRapChieu();
			ct.checkform = true;
			ct.ND = ND;
			ct.ShowDialog();
			this.frmQuanLyRapChieu_Load(sender, e);

		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			int index = dgvRapChieu.CurrentRow.Index;
			frmChiTietRapChieu frm = new frmChiTietRapChieu();
			frm.checkform = false;
			frm.ND = ND;
			frm.MaRap = dgvRapChieu.Rows[index].Cells["colMa"].Value.ToString();
			frm.ShowDialog();
			this.frmQuanLyRapChieu_Load(sender, e);
		}
	}
}
