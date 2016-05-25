using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class TheLoaiPhimDAO
    {
        public List<TheLoaiPhimDTO> LayDSTheLoaiPhim()
        {
            var dt = DataProvider.ExecuteQuery("exec usp_LayDSTheLoaiPhim");
            List<TheLoaiPhimDTO> ds = new List<TheLoaiPhimDTO>();
            foreach(DataRow r in dt.Rows)
            {
                TheLoaiPhimDTO tl = new TheLoaiPhimDTO();
                tl.MaTheLoai = r["MaTheLoai"].ToString();
                tl.TenTheLoai = r["TenTheLoai"].ToString();
                ds.Add(tl);
            }
            return ds;
        }

        public string LayTenTheLoai(TheLoaiPhimDTO tl)
        {
            string sql = string.Format("exec usp_LayTenTheLoai '{0}'", tl.MaTheLoai);
            return (string)DataProvider.ExecuteScalar(sql);
        }

    }
}
