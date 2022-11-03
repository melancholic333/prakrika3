using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace College
{
    class DB
    {
        public static MySqlConnection GetDBConnection()
        {
           

            string host = "localhost";
            int port = 3306;
            string database = "college";
            string user = "root";
            string password = "melancholic666";

            return DBSQL.GetDBConnection(host, port, database, user, password);
        }

        
    }
}
