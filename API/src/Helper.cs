﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using NWN.MasterList.Data;

namespace NWN.MasterList
{
    public static class Helper
    {
        public static string jsonUrl = "https://api.nwn.beamdog.net/v1/";

        public static int MasterListPositionFromSessionName(this Client client, List<NwServer> servers, string sessionName) =>
            servers.Where(s => s.SessionName == sessionName).Select(self => servers.IndexOf(self)).FirstOrDefault();

        public async static Task<IOrderedEnumerable<NwServer>> GetAllFirstSeen(this Client client)
        {
            var response = await client.GetServers();
            return response.OrderBy(x => x.FirstSeen).ThenBy(x => x.ModuleName);
        }

        public async static Task<IOrderedEnumerable<NwServer>> GetAllLastAdvertisement(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.LastAdvertisement).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllBuild(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.Build).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllBuildByType(this Client client, string buildNumber) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.Build == buildNumber).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllConnectHint(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.ConnectHint).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllCurrentPlayersByModuleName(this Client client) =>
            (await client.GetServers()).OrderByDescending(x => x.CurrentPlayers).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllElc(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.ELC).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllElcByType(this Client client, bool setting) =>
            (IOrderedEnumerable<NwServer>)(await client.GetAllElc()).Where(x => x.ELC == setting).OrderBy(x => x.ModuleName);

        public async static Task<int> GetTotalPlayerCount(this Client client) =>
            (await client.GetServers()).Sum(x => x.CurrentPlayers);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllGameType(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.GameType).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllGameTypeByType(this Client client, int gameType) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.GameType == gameType).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetIRLAll(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.ILR).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllIrlByType(this Client client, bool irl) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.ILR == irl).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetIpsAll(this Client client) => 
			(await client.GetServers()).OrderBy(x => Version.Parse(x.IP)).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllServersByIp(this Client client, string ip) =>
            (await client.GetServers()).OrderBy(x => x.IP == ip).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllKxPk(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.KxPk).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllServersByKxPk(this Client client, string kxPkip) =>
            (await client.GetServers()).Where(x => x.KxPk == kxPkip).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllLanguage(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.Language).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllLanguageByType(this Client client, int languageType) =>
            (await client.GetServers()).Where(x => x.Language == languageType).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllLatency(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.Latency).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetLatencyGreaterThan(this Client client, int latencyRate) =>
            (await client.GetServers()).Where(x => x.Latency > latencyRate).OrderBy(x => x.Latency).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetLatencyLesserThan(this Client client, int latencyRate) =>
            (await client.GetServers()).Where(x => x.Latency < latencyRate).OrderBy(x => x.Latency).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetLatencyRange(this Client client, int low = 0, int high = int.MaxValue) =>
            (await client.GetServers()).Where(x => x.Latency >= low && x.Latency <= high).OrderBy(x => x.Latency).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetMaxLevelGreaterThan(this Client client, int levelMax) =>
            (await client.GetServers()).Where(x => x.MaxLevel > levelMax).OrderBy(x => x.MaxLevel).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetMaxLevelLesserThan(this Client client, int levelMax) =>
            (await client.GetServers()).Where(x => x.MaxLevel < levelMax).OrderBy(x => x.MaxLevel).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetMaxLevelRange(this Client client, int low = 1, int high = int.MaxValue) =>
            (await client.GetServers()).Where(x => x.MaxLevel >= low && x.MaxLevel <= high).OrderBy(x => x.MaxLevel).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetMinLevelGreaterThan(this Client client, int levelMin) =>
            (await client.GetServers()).Where(x => x.MinLevel > levelMin).OrderBy(x => x.MinLevel).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetMinLevelLesserThan(this Client client, int levelMin) =>
            (await client.GetServers()).Where(x => x.MinLevel < levelMin).OrderBy(x => x.MinLevel).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetMinLevelRange(this Client client, int low = 1, int high = int.MaxValue) =>
            (await client.GetServers()).Where(x => x.MinLevel >= low && x.MinLevel <= high).OrderBy(x => x.MinLevel).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllModuleDescription(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.ModuleDescription).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllByModuleName(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.ModuleName);

        // TODO #18
        /*public async static Task<IOrderedEnumerable<NwServer>> GetAllNwSync(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.NwSync);
        */

        public async static Task<IOrderedEnumerable<NwServer>> GetAllOneParty(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.OneParty).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetOnePartyByType(this Client client, bool oneParty) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.OneParty == oneParty).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllOS(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.OS).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllOSByType(this Client client, int osType) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.OS == osType).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllPassworded(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.Passworded).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetPasswordedByType(this Client client, bool password) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.Passworded == password).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllPlayerPause(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.PlayerPause).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetPlayerPauseByType(this Client client, bool pause) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.PlayerPause == pause).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetPortGreaterThan(this Client client, int portNumber) =>
            (await client.GetServers()).Where(x => x.Port > portNumber).OrderBy(x => x.Port).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetPortLesserThan(this Client client, int portNumber) =>
            (await client.GetServers()).Where(x => x.Port < portNumber).OrderBy(x => x.Port).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetPortRange(this Client client, int low = 0, int high = 65535) =>
            (await client.GetServers()).Where(x => x.Port >= low && x.Port <= high).OrderBy(x => x.Port).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllByPortNumber(this Client client, int portNumber) =>
            (await client.GetServers()).Where(x => x.Port == portNumber).OrderBy(x => x.ModuleName);

        // TODO #16
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
