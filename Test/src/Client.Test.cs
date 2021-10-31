using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace NWN.MasterList.Test
{
  public static class Client
  {
    private readonly ITestOutputHelper output;

    public Client(ITestOutputHelper output) => this.output = output;

    [Fact]
    public async void GetServersTest()
    {
      var connection = new MasterList.Client();
      Assert.NotEmpty(await connection.GetServers());
    }

    public static IOrderedEnumerable<Data.NwServer> OrderBy(this IOrderedEnumerable<Data.NwServer> servers)
    {
      return servers;
    }

    [Fact]
    public async void TestGetAllFirstSeen()
    {
      var connection = new MasterList.Client();
      var json = await connection.GetAllFirstSeen();
      var test = await connection.GetServers().OrderByDescending(x => x.FirstSeen);
      Assert.NotEmpty(json);
      Assert.NotNull(json);

      foreach (var item in json.OrderBy(x => x.FirstSeen))
      {
        output.WriteLine($"Module Name -> {item.ModuleName}\nFirst Seen -> {item.FirstSeen}\n");
      }
    }
  }
}
