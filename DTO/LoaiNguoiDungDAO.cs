using System.Data;

namespace DAO
{
    public class LoaiNguoiDungDAO
    {
        public DataTable LayDsLoaiNguoiDung()
        {
            return DataProvider.ExecuteQuery("exec usp_LayDSLoaiNguoiDung");
        }

        public string LayTenLoaiNguoiDung(NguoiDung nd)
        {
            string sql = $"exec usp_LayTenLoaiNguoiDung {nd.LoaiNguoiDung}";
            return (string)DataProvider.ExecuteScalar(sql);
        }
    }
}
