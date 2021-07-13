using Xunit;

namespace NWN.MasterList.Test
{
    public class Client
    {
        [Fact]
        public async void GetServersTest()
        {
            var connection = new MasterList.Client();
            Assert.NotEmpty(await connection.GetServers());
        }

        [Fact]
        public async void TestGetAllFirstSeen()
        {
            var connection = new MasterList.Client();
            Assert.NotEmpty(await connection.GetAllFirstSeen());
        }
    }
}