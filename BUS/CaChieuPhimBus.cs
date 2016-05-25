using System;
using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
	public class CaChieuPhimBus
	{
		public static List<CaChieuPhim> LayDsCaChieuPhim()
		{
			return EntityHelper.QlRapEntities.CaChieuPhims.ToList();
		}

		public static TimeSpan LayThoiGianBatDau(int maCa)
		{
			return EntityHelper.QlRapEntities.CaChieuPhims.FirstOrDefault(c => c.MaCa ==(maCa)).ThoiGianBD.Value;
		}

		public static int LayLoaiThoiGian(int maCa)
		{
			return EntityHelper.QlRapEntities.CaChieuPhims.SingleOrDefault(c => c.MaCa ==(maCa)).LoaiTG;
		}
	}
}
