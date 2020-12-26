using Xunit;

namespace NWN.MasterList.Test {
  public class Client {
    [Fact]
    public void GetServersTest() {
      var connection = new MasterList.Client();
      Assert.NotEmpty(connection.Servers);
    }
  }
}