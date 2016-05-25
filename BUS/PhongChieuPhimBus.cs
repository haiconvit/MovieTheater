using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
	public class PhongChieuPhimBus
	{
		public static List<PhongChieuPhim> LayDsPhongChieuPhim(int maNd)
		{
			return EntityHelper.QlRapEntities.PhongChieuPhims.Where(ph=>ph.IsDeleted ==0).Where(p => p.RapChieuPhim.ChuRap==(maNd)).ToList();
		}

		//Hàm thêm lần 2
		public static List<PhongChieuPhim> LayDsPhongDangHoatDong(int maNd)
		{
			return LayDsPhongChieuPhim(maNd).Where(ph => ph.IsDeleted == 0).Where(p => p.TinhTrang==("đang hoạt động")).ToList();
		}

		public static PhongChieuPhim LayPhongChieuTheoMa(string ma)
		{
			return EntityHelper.QlRapEntities.PhongChieuPhims.SingleOrDefault(p => p.MaPhong ==ma);
		}

		public static int ThemPhongChieu(PhongChieuPhim p)
		{
			EntityHelper.QlRapEntities.PhongChieuPhims.Add(p);
			return EntityHelper.QlRapEntities.SaveChanges();
		}
		public static int UpdatePhongChieu(PhongChieuPhim p)
		{
			var phong = EntityHelper.QlRapEntities.PhongChieuPhims.SingleOrDefault(ph => ph.MaPhong==p.MaPhong);
			phong = p;
			return EntityHelper.QlRapEntities.SaveChanges();
		}
		public static int DeletePhongChieu(string ma)
		{
			var phong = EntityHelper.QlRapEntities.PhongChieuPhims.SingleOrDefault(ph => ph.MaPhong ==ma);
			phong.IsDeleted = 1;
			return EntityHelper.QlRapEntities.SaveChanges();
		}
		public static List<PhongChieuPhim> LayDsPhongChieu()
		{
			return EntityHelper.QlRapEntities.PhongChieuPhims.Where(ph => ph.IsDeleted == 0).ToList();
		}

		public static List<PhongChieuPhim> TimPhongTheoTuKhoa(string keywword, int MaND)
		{
			string sql = "select * from PhongChieuPhim pc, RapChieuPhim r where pc.IsDeleted = 0 and pc.ThuocRap=r.MaRap and r.TenRap like '%" + keywword +"%' and r.ChuRap=" + MaND;
			return EntityHelper.QlRapEntities.PhongChieuPhims.SqlQuery(sql).ToList();
		}

		public static List<PhongChieuPhim> TimPhongNangCao(string tinhTrang, string rap, string dinhDang, int maNd)
		{
			string sql = "select * from PhongChieuPhim pc, RapChieuPhim r, NguoiDung nd where pc.ThuocRap=r.MaRap and r.ChuRap=nd.MaND and pc.IsDeleted = 0";
			if (tinhTrang != "-- Chọn tình trạng phòng --")
				sql += $" and pc.TinhTrang = N'{tinhTrang}'";
			if (rap != "-- Chọn rạp chiếu --")
				sql += $" and pc.ThuocRap = '{rap}'";
			if (dinhDang != "-- Chọn định dạng --")
				sql += $" and pc.KyThuat = '{dinhDang}'";
			sql += $" and nd.MaND = {maNd}";
			sql += " order by pc.MaPhong ASC";
			return EntityHelper.QlRapEntities.PhongChieuPhims.SqlQuery(sql).ToList();
		}

	}
}
