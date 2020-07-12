using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NWN.MasterList {
  public class Server {
    public class Manifest {
      public bool required { get; set; } 
      public string hash { get; set; }
    }

    public class Nwsync {
      public List<Manifest> manifests { get; set; }
      public string url { get; set; }
    }

    public struct Self {
      public int first_seen { get; set; } 
      public int last_advertisement { get; set; } 
      public string session_name { get; set; } 
      public string module_name { get; set; } 
      public string module_description { get; set; } 
      public bool passworded { get; set; } 
      public int min_level { get; set; } 
      public int max_level { get; set; } 
      public int current_players { get; set; } 
      public int max_players { get; set; } 
      public string build { get; set; } 
      public int rev { get; set; } 
      public int pvp { get; set; } 
      public bool servervault { get; set; } 
      public bool elc { get; set; } 
      public bool ilr { get; set; } 
      public bool one_party { get; set; } 
      public bool player_pause { get; set; } 
      public int os { get; set; } 
      public int language { get; set; } 
      public int game_type { get; set; } 
      public int latency { get; set; } 
      public string host { get; set; } 
      public int port { get; set; } 
      public string kx_pk { get; set; } 
      public string sign_pk { get; set; } 
      public string connecthint { get; set; } 
      public Nwsync nwsync { get; set; }
    }

    
    public static async Task<Self> Get(string publicKey) {
      using var client = new HttpClient();
      var response = await client.GetStringAsync($"https://api.nwn.beamdog.net/v1/servers/{publicKey}");
      return JsonConvert.DeserializeObject<Self>(jsonResponse);
    }
    
    
    public async Task<Self> Get(string ip, int port) {
      using var client = new HttpClient();
      var jsonResponse = await client.GetStringAsync($"https://api.nwn.beamdog.net/v1/servers/{ip}/{port}");
      return JsonConvert.DeserializeObject<Self>(jsonResponse);
    }
  }
}