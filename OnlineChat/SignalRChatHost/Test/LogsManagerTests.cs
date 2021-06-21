using Moq;
using NUnit.Framework;
using SignalRChatHost.DataBase;
using System;
using Xunit;

namespace SignalRChatHost.Test
{
    public class LogsManagerTests
    {
        private readonly IHelper _helper;
        public LogsManagerTests() : this(new LogsManagerWrapper())
        {

        }
        public LogsManagerTests(IHelper helper)
        {
            _helper = helper;
        }
        public int Bar(string a, DateTime b, string c)
        {
            return _helper.AddLog(a,b,c);
        }      

    }
}