using System.Net.Http;

namespace NWN.MasterList {
  public class Client {
    public static HttpClient HttpClient { get; set; }

    public Client() {
      HttpClient = new HttpClient();
    }
  }
}
