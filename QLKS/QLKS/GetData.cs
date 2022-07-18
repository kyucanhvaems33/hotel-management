using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLKS
{
    class GetData
    {
        static DataTable tb = null;
        static string url = "Data Source=msi;Initial Catalog=QLKS;User ID=sa;Password=djtcumay";
        static public SqlConnection con = new SqlConnection(url);
        static public SqlCommand com;
        //SqlDataReader read;
        static public DataTable getdata(string query,bool a,bool viewTK)
        {
            con.Open();
            if (!viewTK)
            {
                com = new SqlCommand(query, con);
            }
            tb = new DataTable();
            tb.Load(com.ExecuteReader());
            con.Close();
            com.Dispose();
            if (a)
            {
                if (tb.Columns.Count > 1)
                {
                    foreach (DataRow item in tb.Rows)
                    {
                        for (int i = 0; i < tb.Columns.Count; i++)
                        {
                            item[i] = item[i].ToString().Trim();
                        }
                    }
                }
            }
            else
            {
                if (tb.Columns.Count > 1)
                {
                    foreach (DataRow item in tb.Rows)
                    {
                        for (int i = 1; i < tb.Columns.Count; i++)
                        {
                            item[i] = item[i].ToString().Trim();
                        }
                    }
                }
            }
            return tb;
        }

        public static DataTable getdataview(string query,bool parameters)
        {
            con.Open();
            if (!parameters)
            {
                com = new SqlCommand(query, con);
            }
            tb = new DataTable();
            tb.Load(com.ExecuteReader());
            con.Close();
            com.Dispose();
            return tb;
        }

        static public bool testdata(bool login)
        {
            bool ss = false;
            SqlDataReader read;
            read = com.ExecuteReader();
            if (login)
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        F_LogIn.TK.user = read.GetString(0).Trim();
                        F_LogIn.TK.pass = read.GetString(1).Trim();
                        if (!read.IsDBNull(2))
                        {
                            F_LogIn.TK.MaNV = read.GetInt32(2);
                        }
                        F_LogIn.TK.quyen = read.GetString(3).Trim();
                        F_LogIn.TK.htnv = read.GetString(4).Trim();
                    }
                }
            }
            else
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        ss = read.GetBoolean(0);
                    }
                }
            }
            com.Dispose();
            read.Close();
            con.Close();
            return ss;

        }

        static public int putdata()
        {
            int a = GetData.com.ExecuteNonQuery();
            com.Dispose();
            con.Close();
            return a;
        }


  
    }
}
