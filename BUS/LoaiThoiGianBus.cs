using System.Linq;
using DAO;

namespace BUS
{
	public class LoaiThoiGianBus
	{
		public static LoaiThoiGian LayLoaiThoiGianTheoMa(int ma)
		{
			return EntityHelper.QlRapEntities.LoaiThoiGians.SingleOrDefault(l => l.MaLoaiTG==(ma));
		}
	}
}
