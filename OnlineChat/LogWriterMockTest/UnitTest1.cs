using Moq;
using SignalRChatHost.DataBase;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using SignalRChatHost.Test;
using System;
using Xunit;

namespace LogWriterMockTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var wrapper = new LogsManagerWrapper();

            var wm = new LogsManagerTests(wrapper);                      

            Assert.Equal(0, wm.Bar("UnitTests", DateTime.MaxValue, "This is test message"));
            Assert.Equal(-1, wm.Bar("UnitTests", DateTime.MinValue, "This is test message"));
            Assert.Equal(-1, wm.Bar(null, DateTime.MaxValue, null));
            Assert.Equal(-1, wm.Bar(null, DateTime.MaxValue, null));
            Assert.Equal(0, wm.Bar("UnitTests", DateTime.MaxValue, null));
        }
    }
}
