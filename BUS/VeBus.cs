using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
	public class VeBus
	{
		public static List<Ve> LayDsVe()
		{
			return EntityHelper.QlRapEntities.Ves.Where(v => v.IsDeleted==(0)).ToList();
		}

		public static List<Ve> LayDsVeTheoSuatChieu(SuatChieu sc)
		{
			return EntityHelper.QlRapEntities.Ves.Where(v => v.SuatChieu==(sc.MaSuatChieu)).Where(v => v.IsDeleted==(0)).ToList();
		}
		public static int XoaveTheoSuatChieu(int maSc)
		{
			var ves = EntityHelper.QlRapEntities.Ves.Where(v => v.SuatChieu==(maSc)).ToList();
			foreach (Ve ve in ves)
			{
				ve.IsDeleted = 1;
			}
			return EntityHelper.QlRapEntities.SaveChanges();
		}
	}
}
