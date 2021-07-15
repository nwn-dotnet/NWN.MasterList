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
            var collection = await connection.GetServers();

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllFirstSeen()
        {
            var collection = await new MasterList.Client().GetAllFirstSeen();
            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllLastAdvertisement()
        {
            var collection = await new MasterList.Client().GetAllLastAdvertisement();
            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllBuild()
        {
            var collection = await new MasterList.Client().GetAllBuild();
            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllConnectionHint()
        {
            var collection = await new MasterList.Client().GetAllConnectHint();

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllCurrentPlayersByModuleName()
        {
            var collection = await new MasterList.Client().GetAllCurrentPlayersByModuleName();

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
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

        [Fact]
        public async void TestGetAllElC()
        {
            var collection = await new MasterList.Client().GetAllElC();

            foreach (var item in collection)
            {
                
            }
            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }
    }
}
