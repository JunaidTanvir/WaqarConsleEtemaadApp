using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaqarConsleEtemaadApp.DBConnectivity;
using WaqarConsleEtemaadApp.Entities;

namespace WaqarConsleEtemaadApp.DBServices
{
    public class LoginService
    {
        internal List<Login> SelectAll()
        {
            SqlCommand cmd = new SqlCommand("SELECT l.* FROM dbo.Login l ", mySqlConnection.GetSqlConnection());
            return FetchLogins(cmd);
        }

        private List<Login> FetchLogins(SqlCommand cmd)
        {
            List<Login> Logins = null;
            SqlConnection con = cmd.Connection;
       
            using (con)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Logins = new List<Login>();
                    while (dr.Read())
                    {
                        Login login = new Login();
                        login.LoginId = Convert.ToInt32(dr["LoginId"]);
                        login.UserName = (dr["UserName"]).ToString();
                        login.Password = (dr["Password"]).ToString();
                        login.Role = (dr["Role"]).ToString();

                        Logins.Add(login);
                    }
                    Logins.TrimExcess();
                }
            }
            return Logins;
        }








    }
}
