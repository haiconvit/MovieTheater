using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using DAO;
namespace BUS
{
	public class GiaVeBus
	{
		public static GiaVe LayGiaVeTheoTieuChi(int loaiNgay, int loaiTg, string dinhDang)
		{
			return
				EntityHelper.QlRapEntities.GiaVes.Where(g => g.LoaiNgay==(loaiNgay.ToString()))
					.Where(g => g.ThoiGian==(loaiTg))
					.SingleOrDefault(g => g.DinhDang==(dinhDang));
		}

		#region 2D
		public static List<GiaVe> LayDsGiaVeThu2456()
		{
			return
				EntityHelper.QlRapEntities.GiaVes.Where(g => g.DinhDang==("2D"))
					.Where(g => g.ThoiGian==(1))
					.ToList();
		}

		public static List<GiaVe> LayDsGiaVeThu3()
		{
			return EntityHelper.QlRapEntities.GiaVes.Where(g => g.DinhDang==("2D"))
				.Where(g => g.LoaiNgay==("2")).ToList();
		}

		public static List<GiaVe> LayDsGiaVeThu7Cn()
		{
			return EntityHelper.QlRapEntities.GiaVes.Where(g => g.DinhDang==("2D")).
			Where(global => global.LoaiNgay==("3")).ToList();
		}

		public static List<GiaVe> LayDsGiaVeNgayle()
		{
			return EntityHelper.QlRapEntities.GiaVes.Where(g => g.DinhDang==("2D")).
			Where(global => global.LoaiNgay==("4")).ToList();
		}

		public static List<GiaVe> LayGiaVeTheoMa_2D(string loaiNgay)
		{
			return EntityHelper.QlRapEntities.GiaVes.Where(g => g.DinhDang==("2D")).
			Where(global => global.LoaiNgay==(loaiNgay)).ToList();
		}

		public static int Update(int nguoiLon, int sinhVien, int treEm, string dinhDang, string loaiNgay, int thoiGian)
		{
			try
			{
				var giaVe = EntityHelper.QlRapEntities.GiaVes.Where(g => g.DinhDang==(dinhDang)).Where(global => global.LoaiNgay==(loaiNgay)).SingleOrDefault(gv=>gv.ThoiGian==(thoiGian));
				giaVe.NguoiLon = nguoiLon;
				giaVe.SinhVien = sinhVien;
				giaVe.TreEm = treEm;
				return EntityHelper.QlRapEntities.SaveChanges();
			}
			catch (Exception)
			{
				return -1;
			}
		}
		#endregion

		#region 3D
		public static List<GiaVe> LayDSGiaVeThu2456_3D()
		{
			return
				EntityHelper.QlRapEntities.GiaVes.Where(g => g.DinhDang==("3D"))
					.Where(g => g.ThoiGian==(1))
					.ToList();
		}

		public static List<GiaVe> LayDSGiaVeThu3_3D()
		{
			return EntityHelper.QlRapEntities.GiaVes.Where(g => g.DinhDang==("3D"))
				.Where(g => g.LoaiNgay==("2")).ToList();
		}

		public static List<GiaVe> LayDSGiaVeThu7CN_3D()
		{
			return EntityHelper.QlRapEntities.GiaVes.Where(g => g.DinhDang==("3D")).
			Where(global => global.LoaiNgay==("3")).ToList();
		}

		public static List<GiaVe> LayDSGiaVeNgayle_3D()
		{
			return EntityHelper.QlRapEntities.GiaVes.Where(g => g.DinhDang==("2D")).
			Where(global => global.LoaiNgay==("4")).ToList();
		}
		public static List<GiaVe> LayGiaVeTheoMa_3D(string loaiNgay)
		{
			return EntityHelper.QlRapEntities.GiaVes.Where(g => g.DinhDang==("2D")).
			Where(global => global.LoaiNgay==(loaiNgay)).ToList();
		}
		#endregion
	}
}
