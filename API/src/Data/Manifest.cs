using System.Text.Json.Serialization;

namespace NWN.MasterList.Data {
    public struct Manifest {
        [JsonPropertyName("required")]
        public bool Required { get; set; }
        [JsonPropertyName("hash")]
        public string Hash { get; set; }
    }
}