using Xunit;

namespace NWN.MasterList.Test
{
    public class Client
    {
        [Fact]
        public async void GetServersTest()
        {
            var connection = new MasterList.Client();
            var json = await connection.GetServers();
            Assert.NotEmpty(json);
            Assert.NotNull(json);
        }

        [Fact]
        public async void TestGetAllFirstSeen()
        {
            var connection = new MasterList.Client();
            var json = await connection.GetAllFirstSeen();
            Assert.NotEmpty(json);
            Assert.NotNull(json);
        }
    }
}