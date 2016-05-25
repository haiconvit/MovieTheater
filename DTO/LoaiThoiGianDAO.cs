namespace DAO
{
    public class LoaiThoiGianDAO
    {
        public LoaiThoiGian LayLoaiThoiGianTheoMa(int ma)
        {
            string sql = $"exec usp_LayLoaiThoiGianTheoMa {ma}";
            var dt = DataProvider.ExecuteQuery(sql);
            LoaiThoiGian ds = new LoaiThoiGian();
            int maLoai;
            int.TryParse(dt.Rows[0]["MaLoaiTG"].ToString(), out maLoai);
            ds.MaLoaiTG = maLoai;
            ds.TenLoaiTG = dt.Rows[0]["TenLoaiTG"].ToString();
            return ds;
        }
    }
}
