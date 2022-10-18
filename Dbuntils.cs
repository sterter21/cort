using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ba_Zara
{
    internal class Dbuntils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "cloths_store";
            string user = "root";
            string password = "0000";

            return DBconn.GetDBConnection(host, port, database, user, password);
        }
    }
}
