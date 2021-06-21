using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SignalRChatHost.DataBase;

namespace SignalRChatHost.Test
{
    public class LogsManagerWrapper : IHelper
    {       
        public int AddLog(string clientName, DateTime sendDate, string message)
        {
            return LogsManager.AddLog(clientName, sendDate, message);
        }
    }
}