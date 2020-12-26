using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NWN.MasterList {
  public class Server {
    public class Manifest {
      public bool required { get; set; } 
      public string? hash { get; set; }
    }

    public class Nwsync {
      public List<Manifest>? manifests { get; set; }
      public string? url { get; set; }
    }

    public struct Data {
      public int FirstSeen { get; set; } 
      public int LastAdvertisement { get; set; } 
      public string SessionName { get; set; } 
      public string ModuleName { get; set; } 
      public string ModuleDescription { get; set; } 
      public bool Passworded { get; set; } 
      public int MinLevel { get; set; } 
      public int MaxLevel { get; set; } 
      public int CurrentPlayers { get; set; } 
      public int MaxPlayers { get; set; } 
      public string Build { get; set; } 
      public int Rev { get; set; } 
      public int Pvp { get; set; } 
      public bool Servervault { get; set; } 
      public bool Elc { get; set; } 
      public bool Ilr { get; set; } 
      public bool OneParty { get; set; } 
      public bool PlayerPause { get; set; } 
      public int Os { get; set; } 
      public int Language { get; set; } 
      public int GameType { get; set; } 
      public int Latency { get; set; } 
      public string Host { get; set; } 
      public int Port { get; set; } 
      public string KxPk { get; set; } 
      public string SignPk { get; set; } 
      public string Connecthint { get; set; } 
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