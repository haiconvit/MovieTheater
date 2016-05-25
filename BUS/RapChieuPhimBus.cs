using System.Collections.Generic;
using System.Data;
using System.Linq;
using DAO;

namespace BUS
{
	public class RapChieuPhimBus
	{
		public static List<RapChieuPhim> LayDsRapChieuPhim()
		{
			return EntityHelper.QlRapEntities.RapChieuPhims.ToList();
		}
		public static RapChieuPhim LayDsRapPhimTheoMa(string ma)
		{
			return EntityHelper.QlRapEntities.RapChieuPhims.SingleOrDefault(r => r.MaRap==(ma));
		}
		public static int ThemRapChieuPhim(RapChieuPhim rap)
		{
			EntityHelper.QlRapEntities.RapChieuPhims.Add(rap);
			return EntityHelper.QlRapEntities.SaveChanges();
		}
		public static int UpdateRapChieuPhim(RapChieuPhim rap)
		{
			var r = EntityHelper.QlRapEntities.RapChieuPhims.SingleOrDefault(ra => ra.MaRap==(rap.MaRap));
			r = rap;
			return EntityHelper.QlRapEntities.SaveChanges();
		}

		public static int DeleteRapChieuPhim(string ma)
		{
			var r = EntityHelper.QlRapEntities.RapChieuPhims.SingleOrDefault(ra => ra.MaRap==(ma));
			EntityHelper.QlRapEntities.RapChieuPhims.Remove(r);
			return EntityHelper.QlRapEntities.SaveChanges();
		}
		public static List<RapChieuPhim> TimKiemRapTheoTuKhoa(string keyWord, int maNd)
		{
			return
				EntityHelper.QlRapEntities.RapChieuPhims.Where(r => r.ChuRap==(maNd))
					.Where(r => r.TenRap.Contains(keyWord))
					.ToList();
		}
		public static List<RapChieuPhim> LayRapAdmin(int mand)
		{
			return
				EntityHelper.QlRapEntities.RapChieuPhims.Where(r => r.ChuRap == mand).OrderByDescending(r => r.MaRap).ToList();
		}

		public static List<RapChieuPhim> LayMaRap()
		{
			return EntityHelper.QlRapEntities.RapChieuPhims.ToList();
		}

	}
}
