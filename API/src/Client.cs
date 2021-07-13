using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using NWN.MasterList.Data;

namespace NWN.MasterList {



  public class Client {
    public static HttpClient HttpClient { get; set; }

    public Client() {
      HttpClient = new HttpClient();
    }
  }
}
