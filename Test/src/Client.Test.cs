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
            var getServers = await new MasterList.Client().GetServers();

            Assert.Equal(json.Average(x => x.FirstSeen), getServers.Average(x => x.FirstSeen));
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

            foreach (var item in advertisement)
            {
                output.WriteLine($"Module Name -> {item.ModuleName}\nLast Build -> {item.Build}\n");
            }

            Assert.NotEmpty(advertisement);
            Assert.NotNull(advertisement);
        }
    }
}
