namespace DAO
{
    public class BinhChonPhimDAO
    {
        public int BinhChon(BinhChonPhim bc)
        {
            string sql = $"exec usp_BinhChon {bc.MaKH},{bc.MaPhim},{bc.Diem}";
            return DataProvider.ExecuteNonQuery(sql);
        }

        public int DemSoLanBinhChon(int maPhim)
        {
            string sql = $"exec usp_DemSoLanBinhChon {maPhim}";
            return (int)DataProvider.ExecuteScalar(sql);
        }
    }
}
