using Xunit;

namespace NWN.MasterList.Test {
  public class Client {
    [Fact]
    public async void GetServersTest() {
      var connection = new MasterList.Client();
      var test = await connection.GetServers();
      Assert.NotEmpty(test);
    }
  }
}