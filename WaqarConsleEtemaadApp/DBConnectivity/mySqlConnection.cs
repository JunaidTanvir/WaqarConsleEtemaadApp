using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaqarConsleEtemaadApp.DBConnectivity
{
    static class  mySqlConnection
    {
        public static SqlConnection GetSqlConnection()
        {

            string conString = @"Data Source=DESKTOP-R3VUUNE\SQLEXPRESS;Initial Catalog=EtemaadConsole;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
            return sqlConnection;
        }

    }
}
