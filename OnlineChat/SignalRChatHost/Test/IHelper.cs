using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChatHost.Test
{
    public interface IHelper
    {
        int AddLog(string clientName, DateTime sendDate, string message);
    }
}
