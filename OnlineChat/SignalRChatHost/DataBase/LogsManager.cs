using SignalRChatHost.Test;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SignalRChatHost.DataBase
{
    public static class LogsManager
    {
        public static int AddLog(string clientName, DateTime sendDate, string message)
        {
            if (DataBaseConnection.Connect() == 0)
            {
                SqlCommand cmd = new SqlCommand("AddLog", DataBaseConnection.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                if (clientName !=null) cmd.Parameters.Add(new SqlParameter("@UserName", clientName)); else cmd.Parameters.Add(new SqlParameter("@UserName", DBNull.Value));
                if (sendDate != null) cmd.Parameters.Add(new SqlParameter("@SendDate", sendDate)); else cmd.Parameters.Add(new SqlParameter("@SendDate", DBNull.Value));
                if (message != null) cmd.Parameters.Add(new SqlParameter("@Message", message)); else cmd.Parameters.Add(new SqlParameter("@Message", DBNull.Value));
                try
                {
                    cmd.ExecuteNonQuery();
                    return 0;
                }
                catch
                {
                    return -1;
                }                           
            }
            else
            {
                return -1;
            }
        }
        public static int Bar(string clientName, DateTime sendDate, string message)
        {
            return Bar(new LogsManagerWrapper(), clientName, sendDate, message);
        }
        public static int Bar(IHelper helper, string clientName, DateTime sendDate, string message)
        {
            return helper.AddLog(clientName,sendDate,message);
        }
    }
}