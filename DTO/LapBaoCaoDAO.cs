using System;
using System.Data;

namespace DAO
{
    public class LapBaoCaoDAO
    {
        public DataTable XemLichChieu_report(int maNd)
        {
            string sql = $"exec usp_XemLichChieu {maNd}";
            return DataProvider.ExecuteQuery(sql);
        }

        public DataTable ThongKeVe_report(int maNd)
        {
            string sql = $"exec usp_ThongKeVe {maNd}";
            return DataProvider.ExecuteQuery(sql);
        }

        public DataTable DoanhThuTheoRap_report(int maNd)
        {
            string sql = $"exec usp_DoanhThuTheoPhongChieu {maNd}";
            return DataProvider.ExecuteQuery(sql);
        }

        public DataTable DoanhThuTheoPhim_Report(int maNd)
        {
            string sql = $"exec usp_DoanhThuTheoPhim {maNd}";
            return DataProvider.ExecuteQuery(sql);
        }

        public DataTable DoanhThuTheoCaChieu(int maNd)
        {
            string sql = $"exec usp_DoanhThuTheoCaChieu {maNd}";
            return DataProvider.ExecuteQuery(sql);
        }
        public DataTable DoanhThuTheoNgay(int maNd, DateTime tuNgay, DateTime denNgay)
        {
            string sql =
                $"exec usp_DoanhThuTheoNgayThang {maNd},'{tuNgay.ToString("MM/dd/yyyy")}','{denNgay.ToString("MM/dd/yyyy")}'";
            return DataProvider.ExecuteQuery(sql);
        }
    }
}
