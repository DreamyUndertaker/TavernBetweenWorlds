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
       MySqlConnection connection = new MySqlConnection("Server=mysql.joinserver.ru; port=3306; user=u30506_f3ixYzr7Aq; password=VHlCu1V4wwVqh7K1OZkRg3qS; database=s30506_tavern");

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
