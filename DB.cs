using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunhcerForMinecraft
{
    class DB
    {
       MySqlConnection connection = new MySqlConnection("Server=mysql3.joinserver.ru; port=3306; user=u63691_EFbmN7i36W; password=kYpc8BZDyk0jAbB6zhWDqZ3b; database=s63691_TavernBetweenWorlds");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
       
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)

            {
                connection.Close();
            }

        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
