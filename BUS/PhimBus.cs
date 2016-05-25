using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using DAO;

namespace BUS
{
	public class PhimBus
	{
		public static List<Phim> LayDsPhim()
		{
			return EntityHelper.QlRapEntities.Phims.Where(p=>p.IsDeleted == 0).ToList();
		}

		public static List<Phim> TimPhimTheoTuKhoa(string tuKhoa)
		{
			return
				EntityHelper.QlRapEntities.Phims.SqlQuery(
					"Select * from Phim where IsDeleted = 0 and TenPhim like N'% + " + tuKhoa + " + %' order by TenPhim asc").ToList();
		}

		//public DataTable FilmLoad()
		//{
		//    PhimDAO dao = new PhimDAO();
		//    return dao.FilmLoad();
		//}
		public static int ThemPhim(Phim p)
		{
			EntityHelper.QlRapEntities.Phims.Add(p);
			return EntityHelper.QlRapEntities.SaveChanges();
		}

		//Hàm thêm lần 1

		public static List<Phim> TimPhimNangCao(string dinhDang, string theLoai, string hangPhim, string quocGia)
		{
			string sql = string.Format("select * from Phim p, TheLoaiPhim tl where p.TheLoai = tl.MaTheLoai and p.MaPhim !=0 and p.IsDeleted = 0 ");
			if (dinhDang != "-- Chọn định dạng --")
			{
				sql += $" and p.DinhDang = '{dinhDang}'";
			}
			if (theLoai != "0")
			{
				sql += $" and p.TheLoai = '{theLoai}'";
			}
			if (hangPhim != "-- Hãng Phim --")
			{
				sql += $" and p.HangPhim = N'{hangPhim}'";
			}
			if (quocGia != "-- Chọn quốc gia --")
			{
				sql += $" and p.NuocSX = N'{quocGia}'";
			}
			sql += " order by p.MaPhim ASC";
			return EntityHelper.QlRapEntities.Phims.SqlQuery(sql).ToList();
		}

		//Hàm thêm lần 2

		public static Phim LayPhimTheoMa(int ma)
		{
			return EntityHelper.QlRapEntities.Phims.SingleOrDefault(p => p.MaPhim == ma);
		}

		public static int CapnhatPhim(Phim p)
		{
			var phim = EntityHelper.QlRapEntities.Phims.SingleOrDefault(ph => ph.MaPhim ==(p.MaPhim));
			phim = p;
			return EntityHelper.QlRapEntities.SaveChanges();
		}

		public static string LayDinhDang(int maP)
		{
			return EntityHelper.QlRapEntities.Phims.SingleOrDefault(p => p.MaPhim ==(maP)).DinhDang;
		}

		public static int XoaPhimTheoMa(int ma)
		{
			var p = EntityHelper.QlRapEntities.Phims.SingleOrDefault(ph => ph.MaPhim ==(ma));
			p.IsDeleted = 1;
			return EntityHelper.QlRapEntities.SaveChanges();
		}
	}
}
