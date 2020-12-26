using Newtonsoft.Json;

namespace NWN.MasterList.Data {
  public struct Manifest {
    [JsonProperty("required")]
    public bool Required { get; set; }
    [JsonProperty("hash")]
    public string? Hash { get; set; }
  }
}