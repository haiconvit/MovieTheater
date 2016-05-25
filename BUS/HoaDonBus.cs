using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
	public class HoaDonBus
	{

		public static int ThemHoaDon(HoaDon hd)
		{
			EntityHelper.QlRapEntities.HoaDons.Add(hd);
			return EntityHelper.QlRapEntities.SaveChanges();
		}

		public static List<HoaDon> TimHoaDon(string tenNd, bool chuaThanhToan)
		{
			var thanhToan = chuaThanhToan ? "chưa thanh toán" : "đã thanh toán";
			var nd = EntityHelper.QlRapEntities.NguoiDungs.SingleOrDefault(n => n.TenND==(tenNd));
			return EntityHelper.QlRapEntities.HoaDons.Where(h => h.NguoiMua==(nd.MaND))
				.Where(hd => hd.TinhTrang==(thanhToan))
				.ToList();
		}

		public static int ThanhToan(int maHd)
		{
			var tt = EntityHelper.QlRapEntities.HoaDons.SingleOrDefault(h => h.MaHD==(maHd));
			tt.TinhTrang = "đã thanh toán";
			return EntityHelper.QlRapEntities.SaveChanges();
		}
	}
}
