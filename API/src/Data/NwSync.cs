using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NWN.MasterList.Data {
  public struct NwSync {
    [JsonPropertyName("manifests")]
    public List<Manifest>? Manifests { get; set; }
    [JsonPropertyName("url")]
    public string? URL { get; set; }
  }
}