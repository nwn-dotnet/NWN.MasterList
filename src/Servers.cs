using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NWN.MasterList {
  public class Servers {
    public static async Task<List<Server.Self>> Get() {
      using var client = new HttpClient();
      var jsonResponse = await client.GetStringAsync("https://api.nwn.beamdog.net/v1/servers");
      return JsonConvert.DeserializeObject<List<Server.Self>>(jsonResponse);
    }
  }
}