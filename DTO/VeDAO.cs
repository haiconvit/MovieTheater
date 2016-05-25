using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class VeDAO
    {
        public List<VeDTO> LayDSVe()
        {
            DataTable dt = DataProvider.ExecuteQuery("exec usp_LayDSVe");
            List<VeDTO> ds = new List<VeDTO>();
            foreach (DataRow r in dt.Rows)
            {
                VeDTO ve = new VeDTO();
                ve.MaVe = r["MaVe"].ToString();
                int temp;
                int.TryParse(r["SuatChieu"].ToString(), out temp);
                ve.SuatChieu = temp;
                ve.TinhTrang = r["TinhTrang"].ToString();
                ve.ViTriGhe = r["ViTriGhe"].ToString();
                ds.Add(ve);
            }
            return ds;
        }

        public List<VeDTO> LayDSVeTheoSuatChieu(SuatChieuDTO sc)
        {
            string sql = string.Format("exec usp_LayDSVeTheoSuatChieu {0}", sc.MaSuatChieu);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            List<VeDTO> ds = new List<VeDTO>();
            foreach (DataRow r in dt.Rows)
            {
                VeDTO ve = new VeDTO();
                ve.MaVe = r["MaVe"].ToString();
                int temp;
                int.TryParse(r["SuatChieu"].ToString(), out temp);
                ve.SuatChieu = temp;
                ve.TinhTrang = r["TinhTrang"].ToString();
                ve.ViTriGhe = r["ViTriGhe"].ToString();
                ds.Add(ve);
            }
            return ds;
        }

        public int XoaveTheoSuatChieu(int MaSC)
        {
            string sql = string.Format("exec usp_XoaVeTheoSuatChieu {0}", MaSC);
            return DataProvider.ExecuteNonQuery(sql);
        }
    }
}
