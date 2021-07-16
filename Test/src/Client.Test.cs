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
        public async void TestGetAllBuildByType()
        {
            var collection = await new MasterList.Client().GetAllBuildByType("8186");

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
            var testB = 0;
            var testA = await new MasterList.Client().GetTotalPlayerCount();

            foreach (var item in await new MasterList.Client().GetServers())
            {
                testB += item.CurrentPlayers;

            }
            
            Assert.Equal(testA, testB);
        }

        [Fact]
        public async void TestGetAllElC()
        {
            var collection = await new MasterList.Client().GetAllElc();

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllElcByType()
        {
            var collection = await new MasterList.Client().GetAllElcByType(false);

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllGameType()
        {
            var collection = await new MasterList.Client().GetAllGameType();

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllGameTypeByType()
        {
            var collection = await new MasterList.Client().GetAllGameTypeByType(10);

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetIRLAll()
        {
            var collection = await new MasterList.Client().GetIRLAll();

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllIrlByType()
        {
            var collection = await new MasterList.Client().GetAllIrlByType(true);
            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllServersByIp()
        {
            //  A Carpathian Nightmare
            var collection = await new MasterList.Client().GetAllServersByIp("68.183.104.164");

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.IP}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllKxPk()
        {
            var collection = await new MasterList.Client().GetAllKxPk();

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllServersByKxPk()
        {
            //  A Carpathian Nightmare
            var collection = await new MasterList.Client().GetAllServersByKxPk("6FttLhv6ICT0EEIQC8DnBnZeGJUzTZE/iGbsXsdhrwI=");

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.KxPk}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllLanguage()
        {
            var collection = await new MasterList.Client().GetAllLanguage();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.Language}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllLanguageByType()
        {
            var collection = await new MasterList.Client().GetAllLanguageByType(0);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.Language}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }
    }
}
