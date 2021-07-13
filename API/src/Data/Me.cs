using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NWN.MasterList.Data {
  public struct Me {
    [JsonPropertyName("address")]
    public string Address { get; set; }
    [JsonPropertyName("servers")]
    public List<NwServer> Servers { get; set; }
  }
}