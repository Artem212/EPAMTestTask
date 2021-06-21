using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SignalRChatHost
{
    public static class DataBaseConnection
    {
        public static string host = @"golden\chatdbserver"; //server adress
        public static string DBName = "ChatDB"; // Data Base name
        public static bool connected;
        public static SqlConnection connection;
        public static int Connect()
        {          
            connection = new SqlConnection(@"Server="+host+";DataBase="+DBName+";Integrated Security=SSPI;Connection Timeout=1");
            if (connection.State!=ConnectionState.Open)
            {
                try
                {                  
                    connection.Open();
                    return 0;
                }
                catch
                {
                    return -1;
                }                              
            }
            return 0;
        }
    }
}