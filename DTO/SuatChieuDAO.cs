using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class SuatChieuDao
    {
        public List<SuatChieuDTO> LayDSSuatChieu()
        {
            var dt = DataProvider.ExecuteQuery("exec usp_LaySuatChieuTheoPhim");
            var ds = new List<SuatChieuDTO>();
            foreach (DataRow r in dt.Rows)
            {
                SuatChieuDTO sc = new SuatChieuDTO();
                int MaSuatChieu;
                int.TryParse(r["MaSuatChieu"].ToString(), out MaSuatChieu);
                sc.MaSuatChieu = MaSuatChieu;
                sc.Phong = r["Phong"].ToString();
                int CaChieu;
                int.TryParse(r["CaChieu"].ToString(), out CaChieu);
                sc.CaChieu = CaChieu;
                int Phim;
                int.TryParse(r["Phim"].ToString(), out Phim);
                sc.Phim = Phim;
                DateTime Ngaychieu = new DateTime();
                DateTime.TryParse(r["NgayChieu"].ToString(), out Ngaychieu);
                sc.NgayChieu = Ngaychieu;
                ds.Add(sc);
            }
            return ds;
        }

        public List<SuatChieuDTO> LaySuatChieuTheoTieuChi(DateTime ngay, string MaRap, string DinhDang, string TheLoai, int Ca)
        {
            string sql = string.Format("select sc.*,p.* from Phim p,SuatChieu sc, PhongChieuPhim pc where p.MaPhim = sc.Phim and sc.Phong = pc.MaPhong and sc.NgayChieu = '{0}'", ngay.ToString("MM/dd/yyyy"));
            if (MaRap != "0")
            {
                sql += string.Format(" and pc.ThuocRap = '{0}'", MaRap);
            }
            if (DinhDang != "-- Chọn định dạng --")
            {
                sql += string.Format(" and p.DinhDang = '{0}'", DinhDang);
            }
            if (TheLoai != "0")
            {
                sql += string.Format(" and p.TheLoai = '{0}'", TheLoai);
            }
            if (Ca != 0)
            {
                sql += string.Format(" and sc.CaChieu = {0}", Ca);
            }
            if (sql.Contains("CaChieu"))
                sql += " order by p.TenPhim asc";
            else
                sql += " order by sc.CaChieu asc";
            var dt = DataProvider.ExecuteQuery(sql);

            List<SuatChieuDTO> ds = new List<SuatChieuDTO>();
            foreach (DataRow r in dt.Rows)
            {
                SuatChieuDTO sc = new SuatChieuDTO();
                int temp;
                int.TryParse(r["CaChieu"].ToString(), out temp);
                sc.CaChieu = temp;
                int.TryParse(r["MaSuatChieu"].ToString(), out temp);
                sc.MaSuatChieu = temp;
                int.TryParse(r["Phim"].ToString(), out temp);
                sc.Phim = temp;
                sc.Phong = r["Phong"].ToString();
                DateTime time = new DateTime();
                DateTime.TryParse(r["NgayChieu"].ToString(), out time);
                sc.NgayChieu = time;
                ds.Add(sc);
            }
            return ds;
        }

        public List<SuatChieuDTO> LaySuatChieuHienTaiTheoPhim(PhimDTO p)
        {
            string sql = string.Format("usp_LaySuatChieuHienTaiTheoPhim {0}", p.MaPhim);
            var dt = DataProvider.ExecuteQuery(sql);
            List<SuatChieuDTO> ds = new List<SuatChieuDTO>();
            foreach (DataRow r in dt.Rows)
            {
                SuatChieuDTO sc = new SuatChieuDTO();
                int temp;
                int.TryParse(r["CaChieu"].ToString(), out temp);
                sc.CaChieu = temp;
                int.TryParse(r["MaSuatChieu"].ToString(), out temp);
                sc.MaSuatChieu = temp;
                int.TryParse(r["Phim"].ToString(), out temp);
                sc.Phim = temp;
                sc.Phong = r["Phong"].ToString();
                DateTime time = new DateTime();
                DateTime.TryParse(r["NgayChieu"].ToString(), out time);
                sc.NgayChieu = time;
                ds.Add(sc);
            }
            return ds;
        }

        public List<SuatChieuDTO> TimSuatChieuNangCao(DateTime ngay, string MaRap, string DinhDang, string TheLoai, int ca)
        {
            string sql = string.Format("select * from Phim p,SuatChieu sc, PhongChieuPhim pc where p.MaPhim = sc.Phim and sc.Phong = pc.MaPhong");
            if (MaRap != "0")
            {
                sql += string.Format(" and pc.ThuocRap = '{0}'", MaRap);
            }
            if (DinhDang != "-- Chọn định dạng --")
            {
                sql += string.Format(" and p.DinhDang = '{0}'", DinhDang);
            }
            if (TheLoai != "0")
            {
                sql += string.Format(" and p.TheLoai = '{0}'", TheLoai);
            }
            if (ngay != (new DateTime(1, 1, 1)))
            {
                sql += string.Format(" and sc.NgayChieu = '{0}'", ngay.ToString("MM/dd/yyyy"));
            }
            if (ca != 0)
            {
                sql += string.Format(" and sc.CaChieu = {0}", ca);
            }
            sql += " order by sc.MaSuatChieu ASC";
            var dt =  DataProvider.ExecuteQuery(sql);
            List<SuatChieuDTO> ds = new List<SuatChieuDTO>();
            foreach (DataRow r in dt.Rows)
            {
                SuatChieuDTO sc = new SuatChieuDTO();
                int MaSuatChieu;
                int.TryParse(r["MaSuatChieu"].ToString(), out MaSuatChieu);
                sc.MaSuatChieu = MaSuatChieu;
                sc.Phong = r["Phong"].ToString();
                int CaChieu;
                int.TryParse(r["CaChieu"].ToString(), out CaChieu);
                sc.CaChieu = CaChieu;
                int Phim;
                int.TryParse(r["Phim"].ToString(), out Phim);
                sc.Phim = Phim;
                DateTime Ngaychieu = new DateTime();
                DateTime.TryParse(r["NgayChieu"].ToString(), out Ngaychieu);
                sc.NgayChieu = Ngaychieu;
                ds.Add(sc);
            }
            return ds;
        }

        //Hàm thêm lần 3
        public SuatChieuDTO LaySuatChieuTheoMa(int MaSC)
        {
            string sql = String.Format("exec usp_LaySuatChieuTheoMa {0}", MaSC);
            var  dt =  DataProvider.ExecuteQuery(sql);
            SuatChieuDTO sc = new SuatChieuDTO();
            int MaSuatChieu;
            int.TryParse(dt.Rows[0]["MaSuatChieu"].ToString(), out MaSuatChieu);
            sc.MaSuatChieu = MaSuatChieu;
            sc.Phong = dt.Rows[0]["Phong"].ToString();
            int CaChieu;
            int.TryParse(dt.Rows[0]["CaChieu"].ToString(), out CaChieu);
            sc.CaChieu = CaChieu;
            int Phim;
            int.TryParse(dt.Rows[0]["Phim"].ToString(), out Phim);
            sc.Phim = Phim;
            DateTime Ngaychieu = new DateTime();
            DateTime.TryParse(dt.Rows[0]["NgayChieu"].ToString(), out Ngaychieu);
            sc.NgayChieu = Ngaychieu;
            return sc;
        }

        public int ThemSuatChieu(string Phong, int CaChieu, int Phim, DateTime NgayChieu)
        {
            string sql = string.Format("exec usp_ThemSuatChieu '{0}',{1},{2},'{3}'", Phong, CaChieu, Phim, NgayChieu.ToString("MM/dd/yyyy"));
            return DataProvider.ExecuteNonQuery(sql);
        }

        public int CapnhatSuatChieu(string Phong, int CaChieu, int Phim, DateTime NgayChieu, int Masuatchieu)
        {
            string sql = string.Format("exec usp_CapnhatSuatchieu '{0}',{1},{2},'{3}',{4}", Phong, CaChieu, Phim, NgayChieu.ToString("MM/dd/yyyy"), Masuatchieu);
            return DataProvider.ExecuteNonQuery(sql);
        }

        public int XoaSuatChieu(int Masuatchieu)
        {
            string sql = string.Format("exec usp_XoaSuatChieu {0}", Masuatchieu);
            return DataProvider.ExecuteNonQuery(sql);
        }

        public List<SuatChieuDTO> LaySuatChieuTheoTenPhim(string tenphim)
        {
            List<SuatChieuDTO> ds = new List<SuatChieuDTO>();
            string sql = String.Format("exec usp_LaySuatChieuTheoPhim N'{0}'", tenphim);
            var dt =  DataProvider.ExecuteQuery(sql);
            foreach(DataRow r in dt.Rows)
            {
                SuatChieuDTO sc = new SuatChieuDTO();
                int temp;
                int.TryParse(r["CaChieu"].ToString(), out temp);
                sc.CaChieu = temp;
                int.TryParse(r["MaSuatChieu"].ToString(), out temp);
                sc.MaSuatChieu = temp;
                int.TryParse(r["Phim"].ToString(), out temp);
                sc.Phim = temp;
                sc.Phong = r["Phong"].ToString();
                DateTime time = new DateTime();
                DateTime.TryParse(r["NgayChieu"].ToString(), out time);
                sc.NgayChieu = time;
                ds.Add(sc);
            }
            return ds;
        }
        public List<SuatChieuDTO> LaySuatChieuAdmin(int MaND)
        {
            List<SuatChieuDTO> ds = new List<SuatChieuDTO>();
            string sql = String.Format("exec usp_LaySuatChieuAdmin {0}", MaND);
            var dt =  DataProvider.ExecuteQuery(sql);
            foreach (DataRow r in dt.Rows)
            {
                SuatChieuDTO sc = new SuatChieuDTO();
                int temp;
                int.TryParse(r["CaChieu"].ToString(), out temp);
                sc.CaChieu = temp;
                int.TryParse(r["MaSuatChieu"].ToString(), out temp);
                sc.MaSuatChieu = temp;
                int.TryParse(r["Phim"].ToString(), out temp);
                sc.Phim = temp;
                sc.Phong = r["Phong"].ToString();
                DateTime time = new DateTime();
                DateTime.TryParse(r["NgayChieu"].ToString(), out time);
                sc.NgayChieu = time;
                ds.Add(sc);
            }
            return ds;
        }

    }
}
