using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace csharpHola.utils
{
    class Connection
    {
        //here you need to write your info about your  MYSQL database configuration
        private const String ConnectionString = "datasource=localhost;username=root;Password=;Database=crudcs";
        public static MySqlConnection con = new MySqlConnection(ConnectionString);
        private static Connection _con;
        public static Connection GetInstance() {
            if (_con == null)
            {
                _con = new Connection();
            }
            return _con;
        }
        public MySqlConnection getConnection() {
            return con;
        }
        private Connection()
        {

        }
    }
}
