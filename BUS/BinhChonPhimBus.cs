using System.Linq;
using DAO;

namespace BUS
{
	public class BinhChonPhimBus
	{
		public static int BinhChon(BinhChonPhim bc)
		{
			EntityHelper.QlRapEntities.BinhChonPhims.Add(bc);
			return EntityHelper.QlRapEntities.SaveChanges();
		}

		public static int DemSoLanBinhChon(int maPhim)
		{
			return EntityHelper.QlRapEntities.BinhChonPhims.Select(m => m.MaPhim==(maPhim)).Count();
		}
	}
}
