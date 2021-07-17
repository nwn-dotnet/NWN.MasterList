using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using NWN.MasterList.Data;

namespace NWN.MasterList
{
    public static class Server
    {
        public static string jsonUrl = "https://api.nwn.beamdog.net/v1/";

        public static async Task<List<NwServer>> GetServers(this Client client)
        {
            string response = await Client.HttpClient.GetStringAsync($"{jsonUrl}/servers");
            return JsonSerializer.Deserialize<List<NwServer>>(response);
        }

        public static async Task<NwServer> GetServer(this Client client, string publicKey)
        {
            string response = await Client.HttpClient.GetStringAsync($"{jsonUrl}/servers{publicKey}");
            return JsonSerializer.Deserialize<NwServer>(response);
        }

        public static async Task<NwServer> GetServer(this Client client, string ip, int port)
        {
            string response = await Client.HttpClient.GetStringAsync($"{jsonUrl}/servers/{ip}/{port}");
            return JsonSerializer.Deserialize<NwServer>(response);
        }

        public static async Task<Me> GetMe(this Client client)
        {
            string response = await Client.HttpClient.GetStringAsync(jsonUrl);
            return JsonSerializer.Deserialize<Me>(response);
        }
    }
}