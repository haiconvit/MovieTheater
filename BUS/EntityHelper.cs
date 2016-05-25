using DAO;

namespace BUS
{
	public class EntityHelper
	{
		private static QLRapPhimEntities _qlrp;

		public static QLRapPhimEntities QlRapEntities
		{
			get { return _qlrp ?? (_qlrp = new QLRapPhimEntities()); }
			set { _qlrp = value; }
		}
	}
}