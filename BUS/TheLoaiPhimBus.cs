using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
	public class TheLoaiPhimBus
	{
		public static List<TheLoaiPhim> LayDsTheLoaiPhim()
		{
			return EntityHelper.QlRapEntities.TheLoaiPhims.ToList();
		}

		public static string LayTenTheLoai(TheLoaiPhim tl)
		{
			return EntityHelper.QlRapEntities.TheLoaiPhims.SingleOrDefault(t => t.MaTheLoai==(tl.MaTheLoai)).TenTheLoai;
		}
	}
}
