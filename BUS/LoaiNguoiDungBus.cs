using System.Collections.Generic;
using System.Data;
using System.Linq;
using DAO;

namespace BUS
{
	public class LoaiNguoiDungBus
	{
		public static List<LoaiNguoiDung> LayDsLoaiNguoiDung()
		{
			return EntityHelper.QlRapEntities.LoaiNguoiDungs.ToList();
		}

		public static string LayTenLoaiNguoiDung(NguoiDung nd)
		{
			return EntityHelper.QlRapEntities.LoaiNguoiDungs.SingleOrDefault(l => l.MaLoaiND==(nd.LoaiNguoiDung)).TenLoaiND;
		}
	}
}
