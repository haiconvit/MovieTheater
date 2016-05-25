using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class GiaVeDAO
    {
        public GiaVe LayGiaVeTheoTieuChi(int loaiNgay, int loaiTg, string dinhDang)
        {
            string sql = $"exec usp_LayGiaVeTheoTieuChi {loaiNgay},{loaiTg},'{dinhDang}'";
            var temp = DataProvider.ExecuteQuery(sql);
            GiaVe kq = new GiaVe();
            kq.NguoiLon = (float)temp.Rows[0]["NguoiLon"];
            kq.SinhVien = (float)temp.Rows[0]["SinhVien"];
            kq.TreEm = (float)temp.Rows[0]["TreEm"];
            return kq;
        }

        #region 2D
        
        public List<GiaVe> LayDsGiaVeThu2456()
        {       
            var dt =  DataProvider.ExecuteQuery("exec usp_LayDSGiaVeThu2456");
            List<GiaVe> ds = new List<GiaVe>();
            foreach(DataRow r in dt.Rows)
            {
                GiaVe gv = new GiaVe();
                int loaiNgay;
                int.TryParse(r["LoaiNgay"].ToString(), out loaiNgay);
                gv.LoaiNgay = loaiNgay.ToString();
                int thoiGian;
                int.TryParse(r["ThoiGian"].ToString(), out thoiGian);
                gv.ThoiGian = thoiGian;
                gv.DinhDang = r["DinhDang"].ToString();
                float nguoiLon;
                float.TryParse(r["NguoiLon"].ToString(), out nguoiLon);
                gv.NguoiLon = nguoiLon;
                float sinhVien;
                float.TryParse(r["SinhVien"].ToString(), out sinhVien);
                gv.SinhVien = sinhVien;
                float treEm;
                float.TryParse(r["TreEm"].ToString(), out treEm);
                gv.TreEm = treEm;
                ds.Add(gv);
            }
            return ds;   
        }

        public List<GiaVe> LayDsGiaVeThu3()
        {
            var dt = DataProvider.ExecuteQuery("exec usp_LayDSGiaVeThu3");
            List<GiaVe> ds = new List<GiaVe>();
            foreach (DataRow r in dt.Rows)
            {
                GiaVe gv = new GiaVe();
                int loaiNgay;
                int.TryParse(r["LoaiNgay"].ToString(), out loaiNgay);
                gv.LoaiNgay = loaiNgay.ToString();
                int thoiGian;
                int.TryParse(r["ThoiGian"].ToString(), out thoiGian);
                gv.ThoiGian = thoiGian;
                gv.DinhDang = r["DinhDang"].ToString();
                float nguoiLon;
                float.TryParse(r["NguoiLon"].ToString(), out nguoiLon);
                gv.NguoiLon = nguoiLon;
                float sinhVien;
                float.TryParse(r["SinhVien"].ToString(), out sinhVien);
                gv.SinhVien = sinhVien;
                float treEm;
                float.TryParse(r["TreEm"].ToString(), out treEm);
                gv.TreEm = treEm;
                ds.Add(gv);
            }
            return ds;
        }

        public List<GiaVe> LayDsGiaVeThu7Cn()
        {
            var dt =  DataProvider.ExecuteQuery("exec usp_LayDSGiaVeThu7CN");
            List<GiaVe> ds = new List<GiaVe>();
            foreach (DataRow r in dt.Rows)
            {
                GiaVe gv = new GiaVe();
                int loaiNgay;
                int.TryParse(r["LoaiNgay"].ToString(), out loaiNgay);
                gv.LoaiNgay = loaiNgay.ToString();
                int thoiGian;
                int.TryParse(r["ThoiGian"].ToString(), out thoiGian);
                gv.ThoiGian = thoiGian;
                gv.DinhDang = r["DinhDang"].ToString();
                float nguoiLon;
                float.TryParse(r["NguoiLon"].ToString(), out nguoiLon);
                gv.NguoiLon = nguoiLon;
                float sinhVien;
                float.TryParse(r["SinhVien"].ToString(), out sinhVien);
                gv.SinhVien = sinhVien;
                float treEm;
                float.TryParse(r["TreEm"].ToString(), out treEm);
                gv.TreEm = treEm;
                ds.Add(gv);
            }
            return ds;
        }

        public List<GiaVe> LayDsGiaVeNgayle()
        {
            var dt = DataProvider.ExecuteQuery("exec usp_LayDSGiaVeNgayle");
            List<GiaVe> ds = new List<GiaVe>();
            foreach (DataRow r in dt.Rows)
            {
                GiaVe gv = new GiaVe();
                int loaiNgay;
                int.TryParse(r["LoaiNgay"].ToString(), out loaiNgay);
                gv.LoaiNgay = loaiNgay.ToString();
                int thoiGian;
                int.TryParse(r["ThoiGian"].ToString(), out thoiGian);
                gv.ThoiGian = thoiGian;
                gv.DinhDang = r["DinhDang"].ToString();
                float nguoiLon;
                float.TryParse(r["NguoiLon"].ToString(), out nguoiLon);
                gv.NguoiLon = nguoiLon;
                float sinhVien;
                float.TryParse(r["SinhVien"].ToString(), out sinhVien);
                gv.SinhVien = sinhVien;
                float treEm;
                float.TryParse(r["TreEm"].ToString(), out treEm);
                gv.TreEm = treEm;
                ds.Add(gv);
            }
            return ds;
        }

        public List<GiaVe> LayGiaVeTheoMa_2D(string loaiNgay)
        {
            string sql = $"exec usp_LayGiaVeTheoMa_2D {loaiNgay}";
            var dt = DataProvider.ExecuteQuery(sql);
            List<GiaVe> ds = new List<GiaVe>();
            foreach (DataRow r in dt.Rows)
            {
                GiaVe gv = new GiaVe();
                int loaiNgayGv;
                int.TryParse(r["LoaiNgay"].ToString(), out loaiNgayGv);
                gv.LoaiNgay = loaiNgayGv.ToString();
                int thoiGian;
                int.TryParse(r["ThoiGian"].ToString(), out thoiGian);
                gv.ThoiGian = thoiGian;
                gv.DinhDang = r["DinhDang"].ToString();
                float nguoiLon;
                float.TryParse(r["NguoiLon"].ToString(), out nguoiLon);
                gv.NguoiLon = nguoiLon;
                float sinhVien;
                float.TryParse(r["SinhVien"].ToString(), out sinhVien);
                gv.SinhVien = sinhVien;
                float treEm;
                float.TryParse(r["TreEm"].ToString(), out treEm);
                gv.TreEm = treEm;
                ds.Add(gv);
            }
            return ds;
        }

        public int Update(int nguoiLon, int sinhVien, int treEm, string dinhDang, string loaiNgay, int thoiGian)
        {
            string sql = $"exec usp_UpdateGiaVe {nguoiLon},{sinhVien},{treEm},'{dinhDang}',{loaiNgay},{thoiGian}";
            return DataProvider.ExecuteNonQuery(sql);
        }
        #endregion

        #region 3D
        public List<GiaVe> LayDSGiaVeThu2456_3D()
        {
            var dt =  DataProvider.ExecuteQuery("exec usp_LayDSGiaVeThu2456_3D");
            List<GiaVe> ds = new List<GiaVe>();
            foreach (DataRow r in dt.Rows)
            {
                GiaVe gv = new GiaVe();
                int loaiNgay;
                int.TryParse(r["LoaiNgay"].ToString(), out loaiNgay);
                gv.LoaiNgay = loaiNgay.ToString();
                int thoiGian;
                int.TryParse(r["ThoiGian"].ToString(), out thoiGian);
                gv.ThoiGian = thoiGian;
                gv.DinhDang = r["DinhDang"].ToString();
                float nguoiLon;
                float.TryParse(r["NguoiLon"].ToString(), out nguoiLon);
                gv.NguoiLon = nguoiLon;
                float sinhVien;
                float.TryParse(r["SinhVien"].ToString(), out sinhVien);
                gv.SinhVien = sinhVien;
                float treEm;
                float.TryParse(r["TreEm"].ToString(), out treEm);
                gv.TreEm = treEm;
                ds.Add(gv);
            }
            return ds;
        }

        public List<GiaVe> LayDSGiaVeThu3_3D()
        {
            var dt =  DataProvider.ExecuteQuery("exec usp_LayDSGiaVeThu3_3D");
            List<GiaVe> ds = new List<GiaVe>();
            foreach (DataRow r in dt.Rows)
            {
                GiaVe gv = new GiaVe();
                int loaiNgay;
                int.TryParse(r["LoaiNgay"].ToString(), out loaiNgay);
                gv.LoaiNgay = loaiNgay.ToString();
                int thoiGian;
                int.TryParse(r["ThoiGian"].ToString(), out thoiGian);
                gv.ThoiGian = thoiGian;
                gv.DinhDang = r["DinhDang"].ToString();
                float nguoiLon;
                float.TryParse(r["NguoiLon"].ToString(), out nguoiLon);
                gv.NguoiLon = nguoiLon;
                float sinhVien;
                float.TryParse(r["SinhVien"].ToString(), out sinhVien);
                gv.SinhVien = sinhVien;
                float treEm;
                float.TryParse(r["TreEm"].ToString(), out treEm);
                gv.TreEm = treEm;
                ds.Add(gv);
            }
            return ds;
        }

        public List<GiaVe> LayDSGiaVeThu7CN_3D()
        {
            var dt =  DataProvider.ExecuteQuery("exec usp_LayDSGiaVeThu7CN_3D");
            List<GiaVe> ds = new List<GiaVe>();
            foreach (DataRow r in dt.Rows)
            {
                GiaVe gv = new GiaVe();
                int loaiNgay;
                int.TryParse(r["LoaiNgay"].ToString(), out loaiNgay);
                gv.LoaiNgay = loaiNgay.ToString();
                int thoiGian;
                int.TryParse(r["ThoiGian"].ToString(), out thoiGian);
                gv.ThoiGian = thoiGian;
                gv.DinhDang = r["DinhDang"].ToString();
                float nguoiLon;
                float.TryParse(r["NguoiLon"].ToString(), out nguoiLon);
                gv.NguoiLon = nguoiLon;
                float sinhVien;
                float.TryParse(r["SinhVien"].ToString(), out sinhVien);
                gv.SinhVien = sinhVien;
                float treEm;
                float.TryParse(r["TreEm"].ToString(), out treEm);
                gv.TreEm = treEm;
                ds.Add(gv);
            }
            return ds;
        }

        public List<GiaVe> LayDSGiaVeNgayle_3D()
        {
            var dt = DataProvider.ExecuteQuery("exec usp_LayDSGiaVeNgayle_3D");
            List<GiaVe> ds = new List<GiaVe>();
            foreach (DataRow r in dt.Rows)
            {
                GiaVe gv = new GiaVe();
                int loaiNgay;
                int.TryParse(r["LoaiNgay"].ToString(), out loaiNgay);
                gv.LoaiNgay = loaiNgay.ToString();
                int thoiGian;
                int.TryParse(r["ThoiGian"].ToString(), out thoiGian);
                gv.ThoiGian = thoiGian;
                gv.DinhDang = r["DinhDang"].ToString();
                float nguoiLon;
                float.TryParse(r["NguoiLon"].ToString(), out nguoiLon);
                gv.NguoiLon = nguoiLon;
                float sinhVien;
                float.TryParse(r["SinhVien"].ToString(), out sinhVien);
                gv.SinhVien = sinhVien;
                float treEm;
                float.TryParse(r["TreEm"].ToString(), out treEm);
                gv.TreEm = treEm;
                ds.Add(gv);
            }
            return ds;
        }
        public List<GiaVe> LayGiaVeTheoMa_3D(string loaiNgay)
        {
            string sql = $"exec usp_LayGiaVeTheoMa_3D {loaiNgay}";
            var dt =  DataProvider.ExecuteQuery(sql);
            List<GiaVe> ds = new List<GiaVe>();
            foreach (DataRow r in dt.Rows)
            {
                GiaVe gv = new GiaVe();
                int loaiNgayGv;
                int.TryParse(r["LoaiNgay"].ToString(), out loaiNgayGv);
                gv.LoaiNgay = loaiNgayGv.ToString();
                int thoiGian;
                int.TryParse(r["ThoiGian"].ToString(), out thoiGian);
                gv.ThoiGian = thoiGian;
                gv.DinhDang = r["DinhDang"].ToString();
                float nguoiLon;
                float.TryParse(r["NguoiLon"].ToString(), out nguoiLon);
                gv.NguoiLon = nguoiLon;
                float sinhVien;
                float.TryParse(r["SinhVien"].ToString(), out sinhVien);
                gv.SinhVien = sinhVien;
                float treEm;
                float.TryParse(r["TreEm"].ToString(), out treEm);
                gv.TreEm = treEm;
                ds.Add(gv);
            }
            return ds;
        }
        #endregion
    }
}