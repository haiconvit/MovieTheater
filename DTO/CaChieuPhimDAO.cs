using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class CaChieuPhimDAO
    {
        public List<CaChieuPhim> LayDsCaChieuPhim()
        {
            var dt = DataProvider.ExecuteQuery("exec usp_LayDSCaChieuPhim");
            var ds = new List<CaChieuPhim>();
            foreach(DataRow r in dt.Rows)
            {
                var c = new CaChieuPhim();
                int temp;
                int.TryParse(r["MaCa"].ToString(), out temp);
                c.MaCa = temp;
                TimeSpan time;
                TimeSpan.TryParse(r["ThoiGianBD"].ToString(), out time);
                c.ThoiGianBD = time;
                TimeSpan.TryParse(r["ThoiGianKT"].ToString(), out time);
                c.ThoiGianKT = time;
                ds.Add(c);
            }
            return ds;
        }

        public TimeSpan LayThoiGianBatDau(int maCa)
        {
            string sql = $"exec usp_LayThoiGianBatDau {maCa}";
            return (TimeSpan)DataProvider.ExecuteScalar(sql);
        }

        public int LayLoaiThoiGian(int maCa)
        {
            string sql = $"exec usp_LayLoaiThoiGian {maCa}";
            return (int)DataProvider.ExecuteScalar(sql);
        }
    }
}
