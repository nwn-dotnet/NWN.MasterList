using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NWN.MasterList {
  public class Servers {
    public static async Task<List<Server.Data>> Get() {
      using var client = new HttpClient();
      string response;
      try {
        response = await client.GetStringAsync("https://api.nwn.beamdog.net/v1/servers");
      } catch (Exception e) {
        Console.WriteLine(e);
        throw;
      }
      return JsonConvert.DeserializeObject<List<Server.Data>>(response);
    }
  }
}