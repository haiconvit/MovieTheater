using System;
using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
	public class SuatChieuBus
	{
		public static List<SuatChieu> LayDsSuatChieu()
		{
			return EntityHelper.QlRapEntities.SuatChieux.ToList();
		}

		public static List<SuatChieu> LaySuatChieuTheoTieuChi(DateTime ngay, string maRap, string dinhDang, string theLoai, int ca)
		{
			string sql =
				$"select sc.*,p.* from Phim p,SuatChieu sc, PhongChieuPhim pc where p.MaPhim = sc.Phim and sc.Phong = pc.MaPhong and sc.NgayChieu = '{ngay.ToString("MM/dd/yyyy")}'";
			if (maRap != "0")
			{
				sql += $" and pc.ThuocRap = '{maRap}'";
			}
			if (dinhDang != "-- Chọn định dạng --")
			{
				sql += $" and p.DinhDang = '{dinhDang}'";
			}
			if (theLoai != "0")
			{
				sql += $" and p.TheLoai = '{theLoai}'";
			}
			if (ca != 0)
			{
				sql += $" and sc.CaChieu = {ca}";
			}
			if (sql.Contains("CaChieu"))
				sql += " order by p.TenPhim asc";
			else
				sql += " order by sc.CaChieu asc";
			return EntityHelper.QlRapEntities.SuatChieux.SqlQuery(sql).ToList();
		}

		public static List<SuatChieu> LaySuatChieuHienTaiTheoPhim(Phim p)
		{

			return
				EntityHelper.QlRapEntities.SuatChieux.Where(s => s.Phim==(p.MaPhim))
					.Where(s => s.NgayChieu > DateTime.Now)
					.ToList();
		}


		public static List<SuatChieu> LaySuatChieuTheoTenPhim(string tenphim)
		{
			return
				EntityHelper.QlRapEntities.SuatChieux.Where(s => s.Phim1.TenPhim==(tenphim))
					.Where(s => s.NgayChieu > DateTime.Now)
					.ToList();
		}

		//Hàm thêm lần 2
		public static List<SuatChieu> TimSuatChieuNangCao(DateTime ngay, string maRap, string dinhDang, string theLoai, int ca)
		{
			string sql = string.Format("select * from Phim p,SuatChieu sc, PhongChieuPhim pc where p.MaPhim = sc.Phim and sc.Phong = pc.MaPhong and sc.IsDeleted = 0");
			if (maRap != "0")
			{
				sql += $" and pc.ThuocRap = '{maRap}'";
			}
			if (dinhDang != "-- Chọn định dạng --")
			{
				sql += $" and p.DinhDang = '{dinhDang}'";
			}
			if (theLoai != "0")
			{
				sql += $" and p.TheLoai = '{theLoai}'";
			}
			if (ngay != (new DateTime(1, 1, 1)))
			{
				sql += $" and sc.NgayChieu = '{ngay.ToString("MM/dd/yyyy")}'";
			}
			if (ca != 0)
			{
				sql += $" and sc.CaChieu = {ca}";
			}
			sql += " order by sc.MaSuatChieu ASC";
			return EntityHelper.QlRapEntities.SuatChieux.SqlQuery(sql).ToList();
		}

		//Hàm thêm lần 3
		public static SuatChieu LaySuatChieuTheoMa(int maSc)
		{
			return EntityHelper.QlRapEntities.SuatChieux.SingleOrDefault(s => s.MaSuatChieu==(maSc));
		}

		public static int ThemSuatChieu(string phong, int caChieu, int phim, DateTime ngayChieu)
		{
			SuatChieu sc = new SuatChieu()
			{
				CaChieu = caChieu,
				Phong = phong,
				NgayChieu = ngayChieu,
				Phim = phim,
				IsDeleted = 0
			};
			var a = EntityHelper.QlRapEntities.SuatChieux;
			a.Add(sc);
			return EntityHelper.QlRapEntities.SaveChanges();
		}

		public static int CapnhatSuatChieu(string phong, int caChieu, int phim, DateTime ngayChieu, int masuatchieu)
		{
			var sc = EntityHelper.QlRapEntities.SuatChieux.SingleOrDefault(s => s.MaSuatChieu==(masuatchieu));
			sc.Phim = phim;
			sc.NgayChieu = ngayChieu;
			sc.CaChieu = caChieu;
			sc.Phong = phong;
			return EntityHelper.QlRapEntities.SaveChanges();
		}

		public static int XoaSuatChieu(int masuatchieu)
		{
			var sc = EntityHelper.QlRapEntities.SuatChieux.SingleOrDefault(s => s.MaSuatChieu==(masuatchieu));
			sc.IsDeleted = 1;
			return EntityHelper.QlRapEntities.SaveChanges();
		}

		public static List<SuatChieu> LaySuatChieuAdmin(int maNd)
		{
			string sql =
				"Select * From SuatChieu sc, Phim p, RapChieuPhim r, PhongChieuPhim pc where sc.Phim = p.Maphim and pc.MaPhong = sc.Phong and r.MaRap = pc.ThuocRap and r.ChuRap = " +maNd +" order by MaSuatChieu ASC";
			return EntityHelper.QlRapEntities.SuatChieux.SqlQuery(sql).ToList();
		}
	}
}
