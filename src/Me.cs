using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NWN.MasterList {
  public class Me {
    public struct Self {
      public string address { get; set; } 
      public List<Server> servers { get; set; }
    }
    
    public async Task<Self> Get() {
      using var client = new HttpClient();
      string response;
      try {
        response = await client.GetStringAsync("https://api.nwn.beamdog.net/v1/me");
      } catch (Exception e) {
        Console.WriteLine(e);
        throw;
      }

      return JsonConvert.DeserializeObject<Self>(response);
    }
  }
}