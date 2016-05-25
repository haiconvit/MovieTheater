using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PhongChieuPhimDAO
    {
        public List<PhongChieuPhimDTO> LayDSPhongChieuPhim(int MaND)
        {
            List<PhongChieuPhimDTO> ds = new List<PhongChieuPhimDTO>();
            string sql = string.Format("exec usp_LayPhongChieuAdmin {0}", MaND);
            var dt = DataProvider.ExecuteQuery(sql);
            foreach(DataRow r in dt.Rows)
            {
                PhongChieuPhimDTO dto = new PhongChieuPhimDTO();
                dto.MaPhong = r["MaPhong"].ToString();
                int SoHangGhe;
                int.TryParse(r["SoHangGhe"].ToString(), out SoHangGhe);
                dto.SoHangGhe = SoHangGhe;
                int SoDayGhe;
                int.TryParse(r["SoDayGhe"].ToString(), out SoDayGhe);
                dto.SoDayGhe = SoDayGhe;
                dto.TinhTrang = r["TinhTrang"].ToString();
                dto.KyThuat = r["KyThuat"].ToString();
                dto.ThuocRap = r["ThuocRap"].ToString();
                ds.Add(dto);
            }
            return ds;
        }

        //Hàm thêm lần 2
        public List<PhongChieuPhimDTO> LayDSPhongDangHoatDong(int MaND)
        {
            List<PhongChieuPhimDTO> ds = new List<PhongChieuPhimDTO>();
            string sql = string.Format("exec usp_LayDSPhongChieuDangHoatDong {0}", MaND);
            var dt = DataProvider.ExecuteQuery(sql);
            foreach (DataRow r in dt.Rows)
            {
                PhongChieuPhimDTO dto = new PhongChieuPhimDTO();
                dto.MaPhong = r["MaPhong"].ToString();
                int SoHangGhe;
                int.TryParse(r["SoHangGhe"].ToString(), out SoHangGhe);
                dto.SoHangGhe = SoHangGhe;
                int SoDayGhe;
                int.TryParse(r["SoDayGhe"].ToString(), out SoDayGhe);
                dto.SoDayGhe = SoDayGhe;
                dto.TinhTrang = r["TinhTrang"].ToString();
                dto.KyThuat = r["KyThuat"].ToString();
                dto.ThuocRap = r["ThuocRap"].ToString();
                ds.Add(dto);
            }
            return ds;
        }

        public PhongChieuPhimDTO LayPhongChieuTheoMa(string Ma)
        {
            PhongChieuPhimDTO p = new PhongChieuPhimDTO();
            string sql = string.Format("exec usp_LayPhongChieuTheoMa '{0}'", Ma);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            p.MaPhong = Ma;
            p.SoDayGhe = (int)dt.Rows[0]["SoDayGhe"];
            p.SoHangGhe = (int)dt.Rows[0]["SoHangGhe"];
            p.ThuocRap = (string)dt.Rows[0]["ThuocRap"];
            p.KyThuat = (string)dt.Rows[0]["KyThuat"];
            p.TinhTrang = (string)dt.Rows[0]["TinhTrang"];
            return p;
        }

        public int ThemPhongChieu(PhongChieuPhimDTO dto)
        {
            string sql = string.Format("exec usp_ThemPhongChieu '{0}',{1},{2},N'{3}','{4}','{5}'", dto.MaPhong, dto.SoHangGhe, dto.SoDayGhe, dto.TinhTrang, dto.KyThuat, dto.ThuocRap);
            return DataProvider.ExecuteNonQuery(sql);
        }

        public int UpdatePhongChieu(PhongChieuPhimDTO dto)
        {
            string sql = string.Format("exec usp_UpdatePhongChieu {0},{1},N'{2}','{3}','{4}','{5}'", dto.SoHangGhe, dto.SoDayGhe, dto.TinhTrang, dto.KyThuat, dto.ThuocRap, dto.MaPhong);
            return DataProvider.ExecuteNonQuery(sql);
        }

        public int DeletePhongChieu(string Ma)
        {
            string sql = string.Format("exec usp_XoaPhongChieu '{0}'", Ma);
            return DataProvider.ExecuteNonQuery(sql);
        }
        public List<PhongChieuPhimDTO> LayDSPhongChieu()
        {
            List<PhongChieuPhimDTO> ds = new List<PhongChieuPhimDTO>();
            var dt=  DataProvider.ExecuteQuery("exec usp_LayDSPhongChieu");
            foreach (DataRow r in dt.Rows)
            {
                PhongChieuPhimDTO dto = new PhongChieuPhimDTO();
                dto.MaPhong = r["MaPhong"].ToString();
                int SoHangGhe;
                int.TryParse(r["SoHangGhe"].ToString(), out SoHangGhe);
                dto.SoHangGhe = SoHangGhe;
                int SoDayGhe;
                int.TryParse(r["SoDayGhe"].ToString(), out SoDayGhe);
                dto.SoDayGhe = SoDayGhe;
                dto.TinhTrang = r["TinhTrang"].ToString();
                dto.KyThuat = r["KyThuat"].ToString();
                dto.ThuocRap = r["ThuocRap"].ToString();
                ds.Add(dto);
            }
            return ds;
        }
        public List<PhongChieuPhimDTO> TimPhongTheoTuKhoa(string keywword, int MaND)
        {
            List<PhongChieuPhimDTO> ds = new List<PhongChieuPhimDTO>();
            string sql = string.Format("exec usp_TimPhongTheoTuKhoa N'%{0}%',{1}", keywword, MaND);
            var dt = DataProvider.ExecuteQuery(sql); foreach (DataRow r in dt.Rows)
            {
                PhongChieuPhimDTO dto = new PhongChieuPhimDTO();
                dto.MaPhong = r["MaPhong"].ToString();
                int SoHangGhe;
                int.TryParse(r["SoHangGhe"].ToString(), out SoHangGhe);
                dto.SoHangGhe = SoHangGhe;
                int SoDayGhe;
                int.TryParse(r["SoDayGhe"].ToString(), out SoDayGhe);
                dto.SoDayGhe = SoDayGhe;
                dto.TinhTrang = r["TinhTrang"].ToString();
                dto.KyThuat = r["KyThuat"].ToString();
                dto.ThuocRap = r["ThuocRap"].ToString();
                ds.Add(dto);
            }
            return ds;
        }

        public List<PhongChieuPhimDTO> TimPhongNangCao(string TinhTrang, string Rap, string DinhDang, int MaND)
        {
            string sql = "select * from PhongChieuPhim pc, RapChieuPhim r, NguoiDung nd where pc.ThuocRap=r.MaRap and r.ChuRap=nd.MaND";
            if (TinhTrang != "-- Chọn tình trạng phòng --")
                sql += string.Format(" and pc.TinhTrang = N'{0}'", TinhTrang);
            if (Rap != "-- Chọn rạp chiếu --")
                sql += string.Format(" and pc.ThuocRap = '{0}'", Rap);
            if (DinhDang != "-- Chọn định dạng --")
                sql += string.Format(" and pc.KyThuat = '{0}'", DinhDang);
            sql += string.Format(" and nd.MaND = {0}", MaND);
            sql += " order by pc.MaPhong ASC";
            List<PhongChieuPhimDTO> ds = new List<PhongChieuPhimDTO>();
            var dt = DataProvider.ExecuteQuery(sql);
            foreach (DataRow r in dt.Rows)
            {
                PhongChieuPhimDTO dto = new PhongChieuPhimDTO();
                dto.MaPhong = r["MaPhong"].ToString();
                int SoHangGhe;
                int.TryParse(r["SoHangGhe"].ToString(), out SoHangGhe);
                dto.SoHangGhe = SoHangGhe;
                int SoDayGhe;
                int.TryParse(r["SoDayGhe"].ToString(), out SoDayGhe);
                dto.SoDayGhe = SoDayGhe;
                dto.TinhTrang = r["TinhTrang"].ToString();
                dto.KyThuat = r["KyThuat"].ToString();
                dto.ThuocRap = r["ThuocRap"].ToString();
                ds.Add(dto);
            }
            return ds;
        }
    }
}
