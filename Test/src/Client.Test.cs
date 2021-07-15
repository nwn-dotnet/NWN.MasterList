using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace NWN.MasterList.Test
{
    public class Client
    {
        private readonly ITestOutputHelper output;

        public Client(ITestOutputHelper output) => this.output = output;

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
            var json = await new MasterList.Client().GetAllFirstSeen();
            Assert.NotEmpty(json);
            Assert.NotNull(json);
        }

        [Fact]
        public async void TestGetAllLastAdvertisement()
        {
            var advertisement = await new MasterList.Client().GetAllLastAdvertisement();
            Assert.NotEmpty(advertisement);
            Assert.NotNull(advertisement);
        }

        [Fact]
        public async void TestGetAllBuild()
        {
            var advertisement = await new MasterList.Client().GetAllBuild();
            Assert.NotEmpty(advertisement);
            Assert.NotNull(advertisement);
        }

        [Fact]
        public async void TestGetAllConnectionHint()
        {
            var advertisement = await new MasterList.Client().GetAllConnectHint();

            Assert.NotEmpty(advertisement);
            Assert.NotNull(advertisement);
        }

        [Fact]
        public async void TestGetAllCurrentPlayersByModuleName()
        {
            var advertisement = await new MasterList.Client().GetAllCurrentPlayersByModuleName();

            Assert.NotEmpty(advertisement);
            Assert.NotNull(advertisement);
        }

        [Fact]
        public async void TestGetTotalPlayerCount()
        {
            int testB = 0;

            foreach (var item in await new MasterList.Client().GetServers())
            {
                testB += item.CurrentPlayers;

            }

            var testA = await new MasterList.Client().GetTotalPlayerCount();
            Assert.Equal(testA, testB);
        }
    }
}
