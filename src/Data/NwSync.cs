using System.Collections.Generic;
using Newtonsoft.Json;

namespace NWN.MasterList.Data {
  public struct NwSync {
    [JsonProperty("manifests")]
    public List<Manifest>? Manifests { get; set; }
    [JsonProperty("url")]
    public string? URL { get; set; }
  }
}