using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class NVDAO
    {
        DBconnect db = new DBconnect();

        public bool login(string userName, string passWord)
        {

            string sqlAcount = "select TaiKhoan, MatKhau from NhanVien where TaiKhoan = '" + userName + "' and MatKhau = '" + passWord + "'";
            DataTable dt = db.ExcuteQuery(sqlAcount);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public NV getAcountByUsername(string ten)
        {
            DataTable data = db.ExcuteQuery("select * from NhanVien where TaiKhoan = '" + ten + "'");
            foreach (DataRow item in data.Rows)
            {
                return new NV(item);
            }
            return null;
        }
    }
}
