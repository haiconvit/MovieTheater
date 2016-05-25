using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class NguoiDungDAO
    {
        public List<NguoiDung> LayDsNguoiDung()
        {
            var dt = DataProvider.ExecuteQuery("exec usp_LayDSNguoiDung");
            List<NguoiDung> ds = new List<NguoiDung>();
            foreach(DataRow r in dt.Rows)
            {
                NguoiDung nd = new NguoiDung();
                int temp;
                int.TryParse(r["MaND"].ToString(), out temp);
                nd.MaND = temp;
                nd.MatKhau = r["MatKhau"].ToString();
                nd.TenND = r["TenND"].ToString();
                DateTime nsinh;
                DateTime.TryParse(r["NgaySinh"].ToString(), out nsinh);
                nd.NgaySinh = nsinh;
                nd.HoTen = r["HoTen"].ToString();
                nd.Email = r["Email"].ToString();
                nd.DienThoai = r["DienThoai"].ToString();
                int.TryParse(r["LoaiNguoiDung"].ToString(), out temp);
                nd.LoaiNguoiDung = temp;
                ds.Add(nd);
            }
            return ds;
        }

        public int ThemNguoiDung(NguoiDung nd)
        {
            string sql =
                $"exec usp_ThemNguoiDung N'{nd.TenND}',N'{nd.HoTen}','{nd.MatKhau}','{nd.Email}','{nd.DienThoai}','{nd.NgaySinh}',{nd.LoaiNguoiDung}";
            return DataProvider.ExecuteNonQuery(sql);
        }

        public NguoiDung LayNguoiDungTheoTenNd(string tenNd)
        {
            NguoiDung nd = new NguoiDung();
            string sql = $"exec usp_LayNguoiDungTheoTenND N'{tenNd}'";
            var dt = DataProvider.ExecuteQuery(sql);
            if(dt.Rows.Count > 0)
            {
                int temp;
                int.TryParse(dt.Rows[0]["MaND"].ToString(), out temp);
                nd.MaND = temp;
                nd.MatKhau = dt.Rows[0]["MatKhau"].ToString();
                nd.TenND = dt.Rows[0]["TenND"].ToString();
                DateTime nsinh = new DateTime();
                DateTime.TryParse(dt.Rows[0]["NgaySinh"].ToString(), out nsinh);
                nd.NgaySinh = nsinh;
                nd.HoTen = dt.Rows[0]["HoTen"].ToString();
                nd.Email = dt.Rows[0]["Email"].ToString();
                nd.DienThoai = dt.Rows[0]["DienThoai"].ToString();
                int.TryParse(dt.Rows[0]["LoaiNguoiDung"].ToString(), out temp);
                nd.LoaiNguoiDung = temp;
            }
            return nd;
        }

        public NguoiDung TaoNguoiDungMacDinh()
        {
            NguoiDung nd = new NguoiDung();
            nd.MaND = 0;
            nd.TenND = "khach";
            nd.HoTen = "khách";
            nd.LoaiNguoiDung = 3;
            return nd;
        }

        public NguoiDung LayNguoiDungTheoMa(int MaND)
        {
            string sql = String.Format("exec usp_LayNguoiDungTheoMa {0}", MaND);
            var dt =  DataProvider.ExecuteQuery(sql);
            NguoiDung nd = new NguoiDung();
            if (dt.Rows.Count > 0)
            {
                int temp;
                int.TryParse(dt.Rows[0]["MaND"].ToString(), out temp);
                nd.MaND = temp;
                nd.MatKhau = dt.Rows[0]["MatKhau"].ToString();
                nd.TenND = dt.Rows[0]["TenND"].ToString();
                DateTime nsinh = new DateTime();
                DateTime.TryParse(dt.Rows[0]["NgaySinh"].ToString(), out nsinh);
                nd.NgaySinh = nsinh;
                nd.HoTen = dt.Rows[0]["HoTen"].ToString();
                nd.Email = dt.Rows[0]["Email"].ToString();
                nd.DienThoai = dt.Rows[0]["DienThoai"].ToString();
                int.TryParse(dt.Rows[0]["LoaiNguoiDung"].ToString(), out temp);
                nd.LoaiNguoiDung = temp;
            }
            return nd;
        } 
    }
}
