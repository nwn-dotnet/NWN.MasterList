using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace NWN.MasterList.Data {
  public struct Me {
    [JsonPropertyName("address")]
    public string Address { get; set; }
    [JsonPropertyName("servers")]
    public List<NwServer> Servers { get; set; }
  }
}