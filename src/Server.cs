using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NWN.MasterList {
  public class Server {
    public class Manifest {
      [JsonProperty("required")]
      public bool Required { get; set; }
      [JsonProperty("hash")]
      public string? Hash { get; set; }
    }

    public class Nwsync {
      [JsonProperty("manifests")]
      public List<Manifest>? Manifests { get; set; }
      [JsonProperty("url")]
      public string? URL { get; set; }
    }

    public struct Data {
      [JsonProperty("first_seen")]
      public int FirstSeen { get; set; }
      [JsonProperty("last_advertisement")]
      public int LastAdvertisement { get; set; }
      [JsonProperty("session_name")]
      public string SessionName { get; set; }
      [JsonProperty("module_name")]
      public string ModuleName { get; set; }
      [JsonProperty("module_description")]
      public string ModuleDescription { get; set; }
      [JsonProperty("passworded")]
      public bool Passworded { get; set; }
      [JsonProperty("min_level")]
      public int MinLevel { get; set; }
      [JsonProperty("max_level")]
      public int MaxLevel { get; set; }
      [JsonProperty("current_players")]
      public int CurrentPlayers { get; set; }
      [JsonProperty("max_players")]
      public int MaxPlayers { get; set; }
      [JsonProperty("build")]
      public string Build { get; set; }
      [JsonProperty("rev")]
      public int Revision { get; set; }
      [JsonProperty("pvp")]
      public int PVP { get; set; }
      [JsonProperty("servervault")]
      public bool ServerVault { get; set; }
      [JsonProperty("elc")]
      public bool ELC { get; set; }
      [JsonProperty("ilr")]
      public bool ILR { get; set; }
      [JsonProperty("one_party")]
      public bool OneParty { get; set; }
      [JsonProperty("player_pause")]
      public bool PlayerPause { get; set; }
      [JsonProperty("os")]
      public int OS { get; set; }
      [JsonProperty("language")]
      public int Language { get; set; }
      [JsonProperty("game_type")]
      public int GameType { get; set; }
      [JsonProperty("latency")]
      public int Latency { get; set; }
      [JsonProperty("host")]
      public string IP { get; set; }
      [JsonProperty("port")]
      public int Port { get; set; }
      [JsonProperty("kx_pk")]
      public string KxPk { get; set; }
      [JsonProperty("sign_pk")]
      public string SignPk { get; set; }
      [JsonProperty("connecthint")]
      public string ConnectHint { get; set; }
      [JsonProperty("nwsync")]
      public Nwsync NwSync { get; set; }
    }

    
    public static async Task<Data> GetServer(string publicKey) {
      var client = new HttpClient();
      string response;
      try {
        response = await client.GetStringAsync($"https://api.nwn.beamdog.net/v1/servers/{publicKey}");
      } catch (Exception e) {
        Console.WriteLine(e);
        throw;
      }
      return JsonConvert.DeserializeObject<Data>(response);
    }
    
    public static async Task<Data> GetServer(string ip, int port) {
      var client = new HttpClient();
      string response;
      try {
        response = await client.GetStringAsync($"https://api.nwn.beamdog.net/v1/servers/{ip}/{port}");
      } catch (Exception e) {
        Console.WriteLine(e);
        throw;
      }

      return JsonConvert.DeserializeObject<Data>(response);
    }
  }
}