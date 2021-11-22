using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_KelompokFiona.connection
{
    
    class DBConnection
    {
        private static string connectionName;
        public static SqlConnection cnn;

        public static void connect()
        {
            connectionName = @"Server=localhost; Database=TA_KelompokFiona; Integrated Security=True";
            cnn = new SqlConnection(connectionName);
            cnn.Open();
            Console.WriteLine("Connected");
        }

        public static void close()
        {
            cnn.Close();
        }
    }
}
