using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using NWN.MasterList.Data;

namespace NWN.MasterList {
  public static class Extend {
    public static async Task<List<NwServer>> GetServers(this Client client) {
      string response = await client.HttpClient.GetStringAsync("https://api.nwn.beamdog.net/v1/servers");
      return JsonSerializer.Deserialize<List<NwServer>>(json: response);
    }

    public static async Task<NwServer> GetServer(this Client client, string publicKey) {
      string response = await client.HttpClient.GetStringAsync($"https://api.nwn.beamdog.net/v1/servers/{publicKey}");
      return JsonSerializer.Deserialize<NwServer>(response);
    }

    public static async Task<NwServer> GetServer(this Client client, string ip, int port) {
      string response = await client.HttpClient.GetStringAsync($"https://api.nwn.beamdog.net/v1/servers/{ip}/{port}");
      return JsonSerializer.Deserialize<NwServer>(response);
    }

    public static async Task<Me> GetMe(this Client client) {
      string response = await client.HttpClient.GetStringAsync("https://api.nwn.beamdog.net/v1/me");
      return JsonSerializer.Deserialize<Me>(response);
    }
  }

  public class Client {
    public HttpClient HttpClient { get; }
    public Client(){
        HttpClient = new HttpClient();
    }
  }
}
