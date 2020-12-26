using System.Collections.Generic;
using Newtonsoft.Json;

namespace NWN.MasterList.Data {
  public struct Me {
    [JsonProperty("address")]
    public string Address { get; set; }
    [JsonProperty("servers")]
    public List<NwServer> Servers { get; set; }
  }
}