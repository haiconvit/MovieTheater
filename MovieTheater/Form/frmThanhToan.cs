using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DAO;

namespace MovieTheater.Form
{
	public partial class frmThanhToan : System.Windows.Forms.Form
	{
		List<HoaDon> ds = new List<HoaDon>();

		public frmThanhToan()
		{
			InitializeComponent();
		}

		private void frmThanhToan_Load(object sender, EventArgs e)
		{

		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			dgvHoaDon.Rows.Clear();
			ds = HoaDonBus.TimHoaDon(txtTenND.Text, chkChuaThanhToan.Checked);
			NguoiDung nd = new NguoiDung();
			if (ds.Count > 0)
			{
				nd = NguoiDungBus.LayNguoiDungTheoTenNd(txtTenND.Text);
			}
			foreach (HoaDon hd in ds)
			{
				if (hd.TinhTrang == "chưa thanh toán")
				{
					dgvHoaDon.Rows.Add(hd.MaHD, hd.MaVe, nd.TenND, nd.HoTen, hd.ThoiGianDat, hd.TinhTrang, hd.TongTien, "Thanh toán");
				}
				else
					dgvHoaDon.Rows.Add(hd.MaHD, hd.MaVe, nd.TenND, nd.HoTen, hd.ThoiGianDat, hd.TinhTrang, hd.TongTien, "");
			}
		}

		private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].GetType() == typeof(DataGridViewButtonCell))
			{
				if (dgvHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
				{
					HoaDonBus.ThanhToan(ds[e.RowIndex].MaHD);
					MessageBox.Show("Thanh toán hóa đơn thành công !");
					dgvHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
					dgvHoaDon.Rows[e.RowIndex].Cells["clTinhTrang"].Value = "đã thanh toán";
				}
			}
		}
	}
}
