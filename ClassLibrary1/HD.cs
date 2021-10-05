using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class HD
    {
        DBconnect db = new DBconnect();
        public string loadOrderLastID()
        {
            string maDH = "";
            string sql = "select max(MaHD) from HoaDon";
            DataTable dt = db.ExcuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                maDH = dt.Rows[0][0].ToString();
            }
            return maDH;
        }
    }
}
