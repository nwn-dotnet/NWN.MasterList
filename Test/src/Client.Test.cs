using System.Collections.Generic;
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

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllFirstSeen()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllFirstSeen();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.FirstSeen}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllLastAdvertisement()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllFirstSeen();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.LastAdvertisement}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllBuild()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllFirstSeen();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.Build}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllBuildByType()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllFirstSeen();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.Build}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllConnectionHint()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllFirstSeen();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.ConnectHint}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllCurrentPlayersByModuleName()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllFirstSeen();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.CurrentPlayers}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetTotalPlayerCount()
        {
            var testB = 0;
            var testA = (await new MasterList.Client().GetServers()).GetTotalPlayerCount();

            foreach (var item in await new MasterList.Client().GetServers())
            {
                testB += item.CurrentPlayers;
            }

            Assert.Equal(testA, testB);
        }

        [Fact]
        public async void TestGetAllElC()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllFirstSeen();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.ELC}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllElcByType()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllFirstSeen();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.ELC}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllGameType()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllFirstSeen();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.GameType}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllGameTypeByType()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllGameTypeByType(10);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.GameType}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetIRLAll()
        {
            var collection = (await new MasterList.Client().GetServers()).GetILRAll();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.ILR}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllIrlByType()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllIlrByType(true);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.ILR}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllServersByIp()
        {
            //  A Carpathian Nightmare
            var collection = (await new MasterList.Client().GetServers()).GetAllServersByIp("68.183.104.164");

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
            var collection = (await new MasterList.Client().GetServers()).GetAllKxPk();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.KxPk}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllServersByKxPk()
        {
            //  A Carpathian Nightmare
            var collection = (await new MasterList.Client().GetServers()).GetAllServersByKxPk("6FttLhv6ICT0EEIQC8DnBnZeGJUzTZE/iGbsXsdhrwI=");

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
            var collection = (await new MasterList.Client().GetServers()).GetAllLanguage();

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
            var collection = (await new MasterList.Client().GetServers()).GetAllLanguageByType(0);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.Language}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllLatency()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllLatency();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.Latency}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetLatencyGreaterThan()
        {
            var collection = (await new MasterList.Client().GetServers()).GetLatencyGreaterThan(200);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.Latency}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetLatencyRange()
        {
            var collection = (await new MasterList.Client().GetServers()).GetLatencyRange(100, 200);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.Latency}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetMaxLevelGreaterThan()
        {
            var collection = (await new MasterList.Client().GetServers()).GetMaxLevelGreaterThan(20);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.MaxLevel}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetMaxLevelRange()
        {
            var collection = (await new MasterList.Client().GetServers()).GetMaxLevelRange(20, 40);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.MaxLevel}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllModuleDescription()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllModuleDescription();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.ModuleDescription}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllByModuleName()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllByModuleName();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.ModuleName}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllNwSyncUrls()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllNwSyncUrls();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.NwSync.URL}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        /*[Fact]
        public async void TestGetAllNwSyncManifestHash()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllNwSyncManifestHash();

            foreach (var item in collection)
            {
                //output.WriteLine($"{item.ModuleName} -> {item.NwSync.Manifests}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }*/

        [Fact]
        public async void TestGetAllOneParty()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllOneParty();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.OneParty}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetOnePartyByType()
        {
            var collection = (await new MasterList.Client().GetServers()).GetOnePartyByType(true);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.OneParty}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllOS()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllOS();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.OS}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllOSByType()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllOSByType(1);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.OS}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllPassworded()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllPassworded();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.Passworded}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetPasswordedByType()
        {
            var collection = (await new MasterList.Client().GetServers()).GetPasswordedByType(true);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.Passworded}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllPlayerPause()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllPlayerPause();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.PlayerPause}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetPlayerPauseByType()
        {
            var collection = (await new MasterList.Client().GetServers()).GetPlayerPauseByType(true);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.PlayerPause}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllByPortNumber()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllByPortNumber(5121);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.Port}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllSignPk()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllSignPk();

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.SignPk}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllSignPkByType()
        {
            //  Amia
            var collection = (await new MasterList.Client().GetServers()).GetAllSignPkByType("1r7bU9BtpiAmiWLQz7xaCuZaLf3lQE8mn4T675u8HDQ=");

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.SignPk}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAllOsByTypePlayerDescending()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllOsByTypePlayerDescending(1);

            foreach (var item in collection)
            {
                output.WriteLine($"{item.ModuleName} -> {item.OS} -> {item.CurrentPlayers}");
            }

            Assert.NotEmpty(collection);
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetAverageLatency()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAverageLatency();
            output.WriteLine($"{collection}");
            Assert.NotEqual(-1, collection);
        }

        [Fact]
        public async void GetBuildCountByBuildType()
        {
            var collection = (await new MasterList.Client().GetServers()).GetBuildCountByType("8193");
            output.WriteLine($"{collection}");
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetElcCountByType()
        {
            var collection = (await new MasterList.Client().GetServers()).GetElcCountByType(true);
            output.WriteLine($"{collection}");
            Assert.NotEqual(-1, collection);
        }

        [Fact]
        public async void TestFromUnixTime()
        {
            var collection = (await new MasterList.Client().GetServers()).GetAllFirstSeen();
            var firstSeen = ((long)collection.FirstOrDefault().FirstSeen).FromUnixTime();
            var lastAdvertisement = ((long)collection.FirstOrDefault().LastAdvertisement).FromUnixTime();
            output.WriteLine($"FirstSeen -> {firstSeen}");
            output.WriteLine($"Last Advertisement -> {lastAdvertisement}");
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetUniqueVersions()
        {
            var collection = (await new MasterList.Client().GetServers()).GetUniqueVersion();
            foreach (var item in collection)
            {
                output.WriteLine(item);
            }
            Assert.NotNull(collection);
        }

        [Fact]
        public async void TestGetUniqueVersionCount()
        {
            Dictionary<string, int> collection = (await new MasterList.Client().GetServers()).GetUniqueVersionCount();
            foreach (KeyValuePair<string, int> server in collection)
            {
                output.WriteLine($"{server.Key} -> {server.Value}");
            }
            Assert.NotNull(collection);
        }
    }
}
