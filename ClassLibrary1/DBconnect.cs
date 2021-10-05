using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ClassLibrary1
{
    public class DBconnect
    {
        private SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }    

        private string _strConnect, _strServerName, _strDBName, _strUser, _strPassword;

        public string StrPassword
        {
            get { return _strPassword; }
            set { _strPassword = value; }
        }

        public string StrUser
        {
            get { return _strUser; }
            set { _strUser = value; }
        }

        public string StrDBName
        {
            get { return _strDBName; }
            set { _strDBName = value; }
        }

        public string StrServerName
        {
            get { return _strServerName; }
            set { _strServerName = value; }
        }

        public string StrConnect
        {
            get { return _strConnect; }
            set { _strConnect = value; }
        }
        public DBconnect()
        {
            StrServerName = @"WIN2K\WIN2K";
            StrDBName = "QLSACH_BANSACH";
            StrUser = "sa";
            StrPassword = "sa2012";
            StrConnect = "Data Source=" + StrServerName + "; Initial Catalog=" + StrDBName + "; User ID=" + StrUser + "; Password=" + StrPassword;
            Conn = new SqlConnection(StrConnect);
        }
        public DBconnect(string strconnect, string strservername, string strdbname, string struser, string strpassword)
        {
            StrConnect = strconnect;
            StrServerName = strservername;
            StrDBName = strdbname;
            StrUser = struser;
            StrPassword = strpassword;
            StrConnect = "Data Source=" + StrServerName + "; Initial Catalog=" + StrDBName + "; User ID=" + StrUser + "; Password=" + StrPassword;
            Conn = new SqlConnection(StrConnect);
        }

        

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            //using cho dù có vấn đề j đi nữa khi kết thúc khối lệnh trong đó 
            //dữ liệu khai báo sẽ tự giải phóng
            using (SqlConnection conn = new SqlConnection(StrConnect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listpa = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpa)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }
            return data;

        }
        public void openConnection()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }
        public void closeConnection()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }
        public void updateDatabase(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
            closeConnection();
        }
        SqlDataAdapter danhsach;

        public SqlDataAdapter Danhsach
        {
            get { return danhsach; }
            set { danhsach = value; }
        }
        public void truyvanDL(string strSQL)
        {
            openConnection();
            danhsach = new SqlDataAdapter(strSQL, Conn);

            closeConnection();
        }
        public void loadCBO(String strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(strSQL, Conn);
            danhsach = new SqlDataAdapter(cmd);
            closeConnection();
        }

        public int getCount(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = strSQL;
            int count = (int)cmd.ExecuteScalar();
            closeConnection();
            return count;
        }
        public bool KiemTraTrung(string strSQL)
        {
            return getCount(strSQL) > 0 ? true : false;
        }
        public SqlDataReader getDataReader(String strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = strSQL;
            SqlDataReader data = cmd.ExecuteReader();

            return data;
        }


        
    }
}
