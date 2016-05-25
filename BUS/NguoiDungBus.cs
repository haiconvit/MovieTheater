using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
	public class NguoiDungBus
	{
		public static List<NguoiDung> LayDsNguoiDung()
		{
			return EntityHelper.QlRapEntities.NguoiDungs.Where(n=>n.IsDeleted == 0).ToList();
		}

		public static NguoiDung LayNguoiDungTheoTenNd(string tenNd)
		{
			return EntityHelper.QlRapEntities.NguoiDungs.SingleOrDefault(n => n.TenND==(tenNd));
		}

		public static int ThemNguoiDung(NguoiDung nd)
		{
			EntityHelper.QlRapEntities.NguoiDungs.Add(nd);
			return EntityHelper.QlRapEntities.SaveChanges();
		}

		public static NguoiDung TaoNguoiDungMacDinh()
		{
			NguoiDung nd = new NguoiDung
			{
				MaND = 0,
				TenND = "khach",
				HoTen = "khách",
				LoaiNguoiDung = 3
			};
			return nd;
		}

		public static NguoiDung LayNguoiDungTheoMa(int maNd)
		{
			return EntityHelper.QlRapEntities.NguoiDungs.SingleOrDefault(n => n.MaND==(maNd));
		}
	}
}
