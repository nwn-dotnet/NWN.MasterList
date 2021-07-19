using System;
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

        public static DateTime FromUnixTime(this long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }

        public static string ParsePvP(int pvp)
        {
            switch (pvp)
            {
                case 0: return "None";
                case 1: return "Party";
                case 2: return "Full";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static string ParseOS(int os)
        {
            switch (os)
            {
                case 0: return "Invalid";
                case 1: return "Windows(x86)";
                case 2: return "Windows(x64)";
                case 10: return "Linux(x86)";
                case 11: return "Linux(x64)";
                case 12: return "Linux(arm32)";
                case 13: return "Linux(arm64)";
                case 20: return "Mac(x86)";
                case 21: return "Mac(x64)";
                case 30: return "IOS";
                case 40: return "Android(arm32)";
                case 41: return "Android(rm64)";
                case 42: return "Android(x64)";
                case 50: return "Nintendo Switch";
                case 60: return "Xbox One";
                case 70: return "PS4";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static string ParseLanguage(int language)
        {
            switch (language)
            {
                case 0: return "English";
                case 1: return "French";
                case 2: return "German";
                case 3: return "Italian";
                case 4: return "Spanish";
                case 5: return "Polish";
                case 128: return "Korean";
                case 129: return "Chinese (traditional)";
                case 130: return "Chinese(simplified)";
                case 131: return "Japanese";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public static string ParseGameType(int gameType)
        {
            switch (gameType)
            {
                case 0: return "Action";
                case 1: return "Story";
                case 2: return "Story Lite";
                case 3: return "Roleplay";
                case 4: return "Team";
                case 5: return "Melee";
                case 6: return "Arena";
                case 7: return "Social";
                case 8: return "Alternative";
                case 9: return "PW Action";
                case 10: return "PW Story";
                case 11: return "Solo";
                case 12: return "Tech Support";
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}