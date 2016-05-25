using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
	public class PhimDao
	{
		public List<PhimDTO> LayDSPhim()
		{
			List<PhimDTO> ds = new List<PhimDTO>();
			var dt = DataProvider.ExecuteQuery("exec usp_LayDSPhim");
			foreach (DataRow r in dt.Rows)
			{
				PhimDTO p = new PhimDTO();
				p.CacDienVien = r["CacDienVien"].ToString();
				float diem;
				float.TryParse(r["DiemBinhChon"].ToString(), out diem);
				p.DiemBinhChon = diem;
				p.DinhDang = r["DinhDang"].ToString();
				p.GioiThieu = r["GioiThieu"].ToString();
				p.HangPhim = r["HangPhim"].ToString();
				int temp;
				int.TryParse(r["MaPhim"].ToString(), out temp);
				p.MaPhim = temp;
				int.TryParse(r["NamSX"].ToString(), out temp);
				p.NamSX = temp;
				p.NuocSX = r["NuocSX"].ToString();
				p.Poster = r["Poster"].ToString();
				p.TenPhim = r["TenPhim"].ToString();
				p.TheLoai = r["TheLoai"].ToString();
				int.TryParse(r["ThoiLuong"].ToString(), out temp);
				p.ThoiLuong = temp;
				p.Trailer = r["Trailer"].ToString();
				ds.Add(p);
			}
			return ds;
		}

		public List<PhimDTO> TimPhimTheoTuKhoa(string TuKhoa)
		{
			string sql = string.Format("exec usp_TimPhimTheoTuKhoa N'{0}'", TuKhoa);
			List<PhimDTO> ds = new List<PhimDTO>();
			var dt = DataProvider.ExecuteQuery(sql);
			foreach (DataRow r in dt.Rows)
			{
				PhimDTO p = new PhimDTO();
				p.CacDienVien = r["CacDienVien"].ToString();
				float diem;
				float.TryParse(r["DiemBinhChon"].ToString(), out diem);
				p.DiemBinhChon = diem;
				p.DinhDang = r["DinhDang"].ToString();
				p.GioiThieu = r["GioiThieu"].ToString();
				p.HangPhim = r["HangPhim"].ToString();
				int temp;
				int.TryParse(r["MaPhim"].ToString(), out temp);
				p.MaPhim = temp;
				int.TryParse(r["NamSX"].ToString(), out temp);
				p.NamSX = temp;
				p.NuocSX = r["NuocSX"].ToString();
				p.Poster = r["Poster"].ToString();
				p.TenPhim = r["TenPhim"].ToString();
				p.TheLoai = r["TheLoai"].ToString();
				int.TryParse(r["ThoiLuong"].ToString(), out temp);
				p.ThoiLuong = temp;
				p.Trailer = r["Trailer"].ToString();
				ds.Add(p);
			}
			return ds;
		}

		public int ThemPhim(PhimDTO p)
		{
			string sql = string.Format("exec usp_ThemPhim N'{0}',N'{1}',{2},N'{3}',N'{4}',{5},N'{6}',N'{7}','{8}','{9}',N'{10}',{11}", p.TenPhim, p.HangPhim, p.NamSX, p.NuocSX, p.DinhDang, p.ThoiLuong, p.GioiThieu, p.CacDienVien, p.Trailer, p.Poster, p.TheLoai, p.DiemBinhChon);
			return DataProvider.ExecuteNonQuery(sql);
		}

		//Hàm thêm Lần 1
		public List<PhimDTO> TimPhimNangCao(string DinhDang, string TheLoai, string HangPhim, string QuocGia)
		{
			string sql = string.Format("select * from Phim p, TheLoaiPhim tl where p.TheLoai = tl.MaTheLoai and p.MaPhim !=0");
			if (DinhDang != "-- Chọn định dạng --")
			{
				sql += string.Format(" and p.DinhDang = '{0}'", DinhDang);
			}
			if (TheLoai != "0")
			{
				sql += string.Format(" and p.TheLoai = '{0}'", TheLoai);
			}
			if (HangPhim != "-- Hãng Phim --")
			{
				sql += string.Format(" and p.HangPhim = N'{0}'", HangPhim);
			}
			if (QuocGia != "-- Chọn quốc gia --")
			{
				sql += String.Format(" and p.NuocSX = N'{0}'", QuocGia);
			}
			sql += " order by p.MaPhim ASC";
			List<PhimDTO> ds = new List<PhimDTO>();
			var dt = DataProvider.ExecuteQuery(sql);
			foreach (DataRow r in dt.Rows)
			{
				PhimDTO p = new PhimDTO();
				p.CacDienVien = r["CacDienVien"].ToString();
				float diem;
				float.TryParse(r["DiemBinhChon"].ToString(), out diem);
				p.DiemBinhChon = diem;
				p.DinhDang = r["DinhDang"].ToString();
				p.GioiThieu = r["GioiThieu"].ToString();
				p.HangPhim = r["HangPhim"].ToString();
				int temp;
				int.TryParse(r["MaPhim"].ToString(), out temp);
				p.MaPhim = temp;
				int.TryParse(r["NamSX"].ToString(), out temp);
				p.NamSX = temp;
				p.NuocSX = r["NuocSX"].ToString();
				p.Poster = r["Poster"].ToString();
				p.TenPhim = r["TenPhim"].ToString();
				p.TheLoai = r["TheLoai"].ToString();
				int.TryParse(r["ThoiLuong"].ToString(), out temp);
				p.ThoiLuong = temp;
				p.Trailer = r["Trailer"].ToString();
				ds.Add(p);
			}
			return ds;
		}

		//Hàm thêm Lần 2

		public PhimDTO LayPhimTheoMa(int Ma)
		{
			string sql = String.Format("exec usp_LayPhimTheoMa {0}", Ma);
			var dt = DataProvider.ExecuteQuery(sql);
			PhimDTO p = new PhimDTO();
			if (dt.Rows.Count > 0)
			{
				p.CacDienVien = dt.Rows[0]["CacDienVien"].ToString();
				float diem;
				float.TryParse(dt.Rows[0]["DiemBinhChon"].ToString(), out diem);
				p.DiemBinhChon = diem;
				p.DinhDang = dt.Rows[0]["DinhDang"].ToString();
				p.GioiThieu = dt.Rows[0]["GioiThieu"].ToString();
				p.HangPhim = dt.Rows[0]["HangPhim"].ToString();
				int temp;
				int.TryParse(dt.Rows[0]["MaPhim"].ToString(), out temp);
				p.MaPhim = temp;
				int.TryParse(dt.Rows[0]["NamSX"].ToString(), out temp);
				p.NamSX = temp;
				p.NuocSX = dt.Rows[0]["NuocSX"].ToString();
				p.Poster = dt.Rows[0]["Poster"].ToString();
				p.TenPhim = dt.Rows[0]["TenPhim"].ToString();
				p.TheLoai = dt.Rows[0]["TheLoai"].ToString();
				int.TryParse(dt.Rows[0]["ThoiLuong"].ToString(), out temp);
				p.ThoiLuong = temp;
				p.Trailer = dt.Rows[0]["Trailer"].ToString();
			}
			return p;
		}

		public int CapnhatPhim(PhimDTO p)
		{
			string sql = string.Format("exec usp_CapNhatPhim N'{0}',N'{1}',{2},N'{3}',N'{4}',{5},N'{6}',N'{7}','{8}','{9}',N'{10}',{11}", p.TenPhim, p.HangPhim, p.NamSX, p.NuocSX, p.DinhDang, p.ThoiLuong, p.GioiThieu, p.CacDienVien, p.Trailer, p.Poster, p.TheLoai, p.MaPhim);
			return DataProvider.ExecuteNonQuery(sql);
		}

		public string LayDinhDang(int MaP)
		{
			string sql = string.Format("exec usp_LayDinhDangTheoMaPhim {0}", MaP);
			return (string)DataProvider.ExecuteScalar(sql);
		}

		public int XoaPhimTheoMa(int Ma)
		{
			string sql = String.Format("usp_XoaPhim {0}", Ma);
			return DataProvider.ExecuteNonQuery(sql);
		}

	}
}
