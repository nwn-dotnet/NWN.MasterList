using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NWN.MasterList.Data;

namespace NWN.MasterList {
  public class Client {
    private static HttpClient _client { get; set; }
    public List<NwServer> Servers { get; set; }

    public static async Task<List<NwServer>> GetServers() {
      string response = await _client.GetStringAsync("https://api.nwn.beamdog.net/v1/servers");
      return JsonConvert.DeserializeObject<List<NwServer>>(response);
    }

    public static async Task<NwServer> GetServer(string publicKey) {
      string response = await _client.GetStringAsync($"https://api.nwn.beamdog.net/v1/servers/{publicKey}");
      return JsonConvert.DeserializeObject<NwServer>(response);
    }

    public static async Task<NwServer> GetServer(string ip, int port) {
      string response = await _client.GetStringAsync($"https://api.nwn.beamdog.net/v1/servers/{ip}/{port}");
      return JsonConvert.DeserializeObject<NwServer>(response);
    }

    public static async Task<Me> GetMe() {
      string response = await _client.GetStringAsync("https://api.nwn.beamdog.net/v1/me");
      return JsonConvert.DeserializeObject<Me>(response);
    }

    public Client() {
      _client = new HttpClient();
      Servers = GetServers().Result;
    }
  }
}
