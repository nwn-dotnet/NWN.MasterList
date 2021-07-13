using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using NWN.MasterList.Data;

namespace NWN.MasterList {
	public class Client {
		public const string jsonUrl = "https://api.nwn.beamdog.net/v1/";
		private static HttpClient _client { get; set; }
		public List<NwServer> Servers { get; set; }

		public static async Task<List<NwServer>> GetServers() {
			string response = await _client.GetStringAsync($"{jsonUrl}/servers");
			return JsonSerializer.Deserialize<List<NwServer>>(response);
		}

		public static async Task<NwServer> GetServer(string publicKey) {
			string response = await _client.GetStringAsync($"{jsonUrl}/servers{publicKey}");
			return JsonSerializer.Deserialize<NwServer>(response);
		}

		public static async Task<NwServer> GetServer(string ip, int port) {
			string response = await _client.GetStringAsync($"{jsonUrl}/servers/{ip}/{port}");
			return JsonSerializer.Deserialize<NwServer>(response);
		}

		public static async Task<Me> GetMe() {
			string response = await _client.GetStringAsync(jsonUrl);
			return JsonSerializer.Deserialize<Me>(response);
		}

		public Client() {
			_client = new HttpClient();
			Servers = GetServers().Result;
		}
	}
}
