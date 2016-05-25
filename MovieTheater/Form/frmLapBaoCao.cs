using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DAO;
using MovieTheater.Reports;

namespace MovieTheater.Form
{
	public partial class frmLapBaoCao : System.Windows.Forms.Form
	{
		public NguoiDung ND;
		public frmLapBaoCao()
		{
			InitializeComponent();
		}

		DataTable dt = new DataTable();
		private void frmLapBaoCao_Load(object sender, EventArgs e)
		{
			panelNgay.Controls.Remove(grbNgay);
			int MaND = ND.MaND;
			DataTable dt = new DataTable();
			dt = LapBaoCaoBus.XemLichChieu_report(MaND);

			LichChieu_Report rp = new LichChieu_Report();
			rp.SetDataSource(dt);
			crystalReportViewerLichChieu.ReportSource = rp;
			crystalReportViewerLichChieu.Refresh();

			cmbDoanhThu.Text = "---Chọn doanh thu ---";
		}

		private void tabTinhhinhbanve_SelectedIndexChanged(object sender, EventArgs e)
		{
			int MaND = ND.MaND;
			DataTable tb = new DataTable();
			ThongKeVe_Report rp = new ThongKeVe_Report();
			tb = LapBaoCaoBus.ThongKeVe_report(MaND);
			rp.SetDataSource(tb);
			crystalReportViewerBanVe.ReportSource = rp;
			crystalReportViewerBanVe.Refresh();
		}
		private void btnXemDoanhThu_Click(object sender, EventArgs e)
		{
			if (cmbDoanhThu.Text == "---Chọn doanh thu ---")
				MessageBox.Show("Bạn chưa chọn loại doanh thu, Mời thử lại");
			else
			{
				if (cmbDoanhThu.Text == "Phòng chiếu")
				{
					DataTable dt = new DataTable();
					DoanhThuTheoRap_Report rp = new DoanhThuTheoRap_Report();
					dt = LapBaoCaoBus.DoanhThuTheoRap_report(ND.MaND);
					rp.SetDataSource(dt);
					crystalReportViewerDoanhThu.ReportSource = rp;
					crystalReportViewerDoanhThu.Refresh();
				}
				else
				{
					if (cmbDoanhThu.Text == "Phim")
					{
						DataTable dt = new DataTable();
						DoanhThuTheoPhim_Report rp = new DoanhThuTheoPhim_Report();
						dt = LapBaoCaoBus.DoanhThuTheoPhim_Report(ND.MaND);
						rp.SetDataSource(dt);
						crystalReportViewerDoanhThu.ReportSource = rp;
						crystalReportViewerDoanhThu.Refresh();
					}
					else
					{
						if (cmbDoanhThu.Text == "Ca chiếu")
						{
							DataTable dt = new DataTable();
							DoanhThuTheoCaChieu_CrystalReport rp = new DoanhThuTheoCaChieu_CrystalReport();
							dt = LapBaoCaoBus.DoanhThuTheoCaChieu(ND.MaND);
							rp.SetDataSource(dt);
							crystalReportViewerDoanhThu.ReportSource = rp;
							crystalReportViewerDoanhThu.Refresh();
						}
						else
						{
							if (cmbDoanhThu.Text == "Ngày tháng")
							{
								DataTable dt = new DataTable();
								DoanhThuTheoNgay_Report rp = new DoanhThuTheoNgay_Report();
								dt = LapBaoCaoBus.DoanhThuTheoNgay(ND.MaND, dtpFromDate.Value, dtpToDate.Value);
								if (dt.Rows.Count == 0)
								{
									string thongbao = "";
									if (dtpFromDate.Value == dtpToDate.Value)
										thongbao =
											$"Hiện Doanh thu ngày {dtpFromDate.Value.ToString("MM/dd/yyyy")} không có dữ liệu, mời bạn thử lại !";
									else
										thongbao = string.Format("Hiện Doanh thu từ ngày {0} đến ngày {1} không có dữ liệu, mời bạn thử lại !", dtpFromDate.Value.ToString("MM/dd/yyyy"), dtpToDate.Value.ToString("MM/dd/yyyy"));
									MessageBox.Show(thongbao);
								}
								else
								{
									rp.SetDataSource(dt);
									crystalReportViewerDoanhThu.ReportSource = rp;
									crystalReportViewerDoanhThu.Refresh();
								}
							}
						}
					}
				}
			}
		}

		private void cmbDoanhThu_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cmbDoanhThu.Text == "Ngày tháng")
			{
				panelNgay.Controls.Add(grbNgay);
			}
			else
				panelNgay.Controls.Remove(grbNgay);
		}

	}
}
