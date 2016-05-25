using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class HoaDonDAO
    {
        public int ThemHoaDon(HoaDon hd)
        {
            string sql = $"exec usp_DatVe '{hd.MaVe}',{hd.NguoiMua},'{hd.ThoiGianDat}',N'{hd.TinhTrang}',{hd.TongTien}";
            return DataProvider.ExecuteNonQuery(sql);
        }

        public List<HoaDon> TimHoaDon(string tenNd, bool chuaThanhToan)
        {
            string sql = $"exec usp_TimHoaDonTheoNguoiDung N'{tenNd}'";
            if (chuaThanhToan)
            {
                sql = $"exec usp_TimHoaDonTheoNguoiDungChuaThanhToan N'{tenNd}'";
            }
            var dt = DataProvider.ExecuteQuery(sql);
            var ds = new List<HoaDon>();
            foreach (DataRow r in dt.Rows)
            {
                var hd = new HoaDon();
                int temp;
                int.TryParse(r["MaHD"].ToString(), out temp);
                hd.MaHD = temp;
                hd.MaVe = r["MaVe"].ToString();
                int.TryParse(r["NguoiMua"].ToString(), out temp);
                hd.NguoiMua = temp;
                DateTime time;
                DateTime.TryParse(r["ThoiGianDat"].ToString(), out time);
                hd.ThoiGianDat = time;
                hd.TinhTrang = r["TinhTrang"].ToString();
                int.TryParse(r["TongTien"].ToString(), out temp);
                hd.TongTien = temp;
                ds.Add(hd);
            }
            return ds;
        }

        public int ThanhToan(int maHd)
        {
            string sql = $"exec usp_ThanhToan {maHd}";
            return DataProvider.ExecuteNonQuery(sql);
        }
    }
}
