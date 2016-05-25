using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO
{
    public class DataProvider
    {
        private static readonly string ConStr = ConfigurationManager.ConnectionStrings["QLRapPhim"].ConnectionString;
        private static SqlConnection _con;

        public static bool OpenConnect()
        {
            if (_con == null)
            {
                _con = new SqlConnection(ConStr);
            }
            try
            {
                _con.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            if(OpenConnect())
            {
                SqlCommand cmd = new SqlCommand(sql, _con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _con.Close();
            }
            return dt;
        }
        public static void CloseConnect()
        {
            _con.Close();
        }
        public static int ExecuteNonQuery(string sql)
        {
            int rs = -1;
            if (OpenConnect())
            {
                SqlCommand cmd = new SqlCommand(sql, _con);
                rs = cmd.ExecuteNonQuery();
                _con.Close();
            }
            return rs;
        }

        public static object ExecuteScalar(string sql)
        {
            if (OpenConnect())
            {
                SqlCommand cmd = new SqlCommand(sql, _con);
                var rs = cmd.ExecuteScalar();
                _con.Close();
                return rs;
            }
            return new object();
        }
    }
}
