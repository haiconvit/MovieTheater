using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RapChieuPhimDAO
    {
        public List<RapChieuPhimDTO> LayDSRapChieuPhim()
        {
            var dt = DataProvider.ExecuteQuery("exec usp_LayDSRapChieuPhim");
            List<RapChieuPhimDTO> ds = new List<RapChieuPhimDTO>();
            foreach (DataRow r in dt.Rows)
            {
                RapChieuPhimDTO rc = new RapChieuPhimDTO();
                rc.MaRap = r["MaRap"].ToString();
                rc.TenRap = r["TenRap"].ToString();
                rc.DiaChi = r["DiaChi"].ToString();
                int temp;
                int.TryParse(r["SoPhongChieu"].ToString(), out temp);
                rc.SoPhongChieu = temp;
                int ChuRap;
                int.TryParse(r["ChuRap"].ToString(), out ChuRap);
                rc.ChuRap = ChuRap;
                ds.Add(rc);
            }
            return ds;
        }

        public RapChieuPhimDTO LayDSRapPhimTheoMa(string Ma)
        {
            string sql = string.Format("exec usp_LayDSRapPhimTheoMa '{0}'", Ma);
            var dt =  DataProvider.ExecuteQuery(sql);
            RapChieuPhimDTO rc = new RapChieuPhimDTO();
            rc.MaRap = dt.Rows[0]["MaRap"].ToString();
            rc.TenRap = dt.Rows[0]["TenRap"].ToString();
            rc.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            int temp;
            int.TryParse(dt.Rows[0]["SoPhongChieu"].ToString(),out temp);
            rc.SoPhongChieu = temp;
            int ChuRap;
            int.TryParse(dt.Rows[0]["ChuRap"].ToString(), out ChuRap);
            rc.ChuRap = ChuRap;
            return rc;
        }
        public int ThemRapChieuPhim(RapChieuPhimDTO rap)
        {
            string sql = string.Format("exec usp_ThemRapChieuPhim '{0}',N'{1}',N'{2}',{3},'{4}'", rap.MaRap, rap.TenRap, rap.DiaChi, rap.SoPhongChieu, rap.ChuRap);
            return DataProvider.ExecuteNonQuery(sql);
        }
        public int UpdateRapChieuPhim(RapChieuPhimDTO rap)
        {
            string sql = string.Format("exec usp_CapnhatRapChieuPhim N'{0}',N'{1}',N'{2}',{3},{4}", rap.MaRap, rap.TenRap, rap.DiaChi, rap.SoPhongChieu, rap.ChuRap);
            return DataProvider.ExecuteNonQuery(sql);
        }

        public int DeleteRapChieuPhim(string ma)
        {
            string sql = string.Format("exec usp_XoaRapChieuPhim '{0}'", Ma);
            return DataProvider.ExecuteNonQuery(sql);
        }
        public List<RapChieuPhimDTO> TimKiemRapTheoTuKhoa(string keyWord, int MaND)
        {
            string sql = string.Format("exec usp_TimRapTheoTuKhoa N'{0}',{1}", keyWord,MaND);
            var dt = DataProvider.ExecuteQuery(sql);
            List<RapChieuPhimDTO> ds = new List<RapChieuPhimDTO>();
            foreach(DataRow r in dt.Rows)
            {
                RapChieuPhimDTO rc = new RapChieuPhimDTO();
                rc.MaRap = r["MaRap"].ToString();
                rc.TenRap = r["TenRap"].ToString();
                rc.DiaChi = r["DiaChi"].ToString();
                int temp;
                int.TryParse(r["SoPhongChieu"].ToString(), out temp);
                rc.SoPhongChieu = temp;
                int ChuRap;
                int.TryParse(r["ChuRap"].ToString(), out ChuRap);
                rc.ChuRap = ChuRap;
                ds.Add(rc);
            }
            return ds;
        }
        public List<RapChieuPhimDTO> LayRapAdmin(int MaNd)
        {
            string sql = string.Format("exec usp_LayrapAdmin {0}", MaNd);
            var dt = DataProvider.ExecuteQuery(sql);
            List<RapChieuPhimDTO> ds = new List<RapChieuPhimDTO>();
            foreach (DataRow r in dt.Rows)
            {
                RapChieuPhimDTO rc = new RapChieuPhimDTO();
                rc.MaRap = r["MaRap"].ToString();
                rc.TenRap = r["TenRap"].ToString();
                rc.DiaChi = r["DiaChi"].ToString();
                int temp;
                int.TryParse(r["SoPhongChieu"].ToString(), out temp);
                rc.SoPhongChieu = temp;
                int ChuRap;
                int.TryParse(r["ChuRap"].ToString(), out ChuRap);
                rc.ChuRap = ChuRap;
                ds.Add(rc);
            }
            return ds;
        }

        public DataTable LayMaRap()
        {
            return DataProvider.ExecuteQuery("exec usp_LayMaRap");
        }

    }
}
