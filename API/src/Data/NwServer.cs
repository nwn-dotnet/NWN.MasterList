using System.Text.Json.Serialization;

namespace NWN.MasterList.Data {
    public struct NwServer {
        [JsonPropertyName("first_seen")]
        public int FirstSeen { get; set; }
        [JsonPropertyName("last_advertisement")]
        public int LastAdvertisement { get; set; }
        [JsonPropertyName("session_name")]
        public string SessionName { get; set; }
        [JsonPropertyName("module_name")]
        public string ModuleName { get; set; }
        [JsonPropertyName("module_description")]
        public string ModuleDescription { get; set; }
        [JsonPropertyName("passworded")]
        public bool Passworded { get; set; }
        [JsonPropertyName("min_level")]
        public int MinLevel { get; set; }
        [JsonPropertyName("max_level")]
        public int MaxLevel { get; set; }
        [JsonPropertyName("current_players")]
        public int CurrentPlayers { get; set; }
        [JsonPropertyName("max_players")]
        public int MaxPlayers { get; set; }
        [JsonPropertyName("build")]
        public string Build { get; set; }
        [JsonPropertyName("rev")]
        public int Revision { get; set; }
        [JsonPropertyName("pvp")]
        public int PVP { get; set; }
        [JsonPropertyName("servervault")]
        public bool ServerVault { get; set; }
        [JsonPropertyName("elc")]
        public bool ELC { get; set; }
        [JsonPropertyName("ilr")]
        public bool ILR { get; set; }
        [JsonPropertyName("one_party")]
        public bool OneParty { get; set; }
        [JsonPropertyName("player_pause")]
        public bool PlayerPause { get; set; }
        [JsonPropertyName("os")]
        public int OS { get; set; }
        [JsonPropertyName("language")]
        public int Language { get; set; }
        [JsonPropertyName("game_type")]
        public int GameType { get; set; }
        [JsonPropertyName("latency")]
        public int Latency { get; set; }
        [JsonPropertyName("host")]
        public string IP { get; set; }
        [JsonPropertyName("port")]
        public int Port { get; set; }
        [JsonPropertyName("kx_pk")]
        public string KxPk { get; set; }
        [JsonPropertyName("sign_pk")]
        public string SignPk { get; set; }
        [JsonPropertyName("connecthint")]
        public string ConnectHint { get; set; }
        [JsonPropertyName("nwsync")]
        public NwSync NwSync { get; set; }
    }
}