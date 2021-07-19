﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NWN.MasterList.Data;

namespace NWN.MasterList
{
    public static class Helper
    {
        public static int MasterListPositionFromSessionName(this Client client, List<NwServer> servers, string sessionName) =>
            servers.Where(s => s.SessionName == sessionName).Select(self => servers.IndexOf(self)).FirstOrDefault();

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

        public async static Task<IOrderedEnumerable<NwServer>> GetAllFirstSeen(this Client client)
        {
            var response = await client.GetServers();
            return response.OrderBy(x => x.FirstSeen).ThenBy(x => x.ModuleName);
        }

        public async static Task<IOrderedEnumerable<NwServer>> GetAllGameType(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.GameType).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllGameTypeByType(this Client client, int gameType) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.GameType == gameType).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetILRAll(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.ILR).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllIlrByType(this Client client, bool ilr) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.ILR == ilr).OrderBy(x => x.ModuleName);

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

        public async static Task<IOrderedEnumerable<NwServer>> GetAllLastAdvertisement(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.LastAdvertisement).ThenBy(x => x.ModuleName);

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
        public async static Task<IOrderedEnumerable<NwServer>> GetAllNwSyncUrls(this Client client)
        {
            return (IOrderedEnumerable<NwServer>)(await client.GetServers()).OrderBy(x => x.NwSync.URL);
        }

        public async static Task<IOrderedEnumerable<NwServer>> GetAllOneParty(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.OneParty).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetOnePartyByType(this Client client, bool oneParty) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.OneParty == oneParty).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllOS(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.OS).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllOSByType(this Client client, int osType) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.OS == osType).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllOsByTypePlayerDescending(this Client client, int osType) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.OS == osType).OrderByDescending(x => x.CurrentPlayers).ThenBy(x => x.ModuleName);

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

        public async static Task<IOrderedEnumerable<NwServer>> GetAllPvp(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.PVP).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllPvPByType(this Client client, int pvptype) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.PVP == pvptype).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllRevision(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.Revision).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllRevisionByType(this Client client, int revisionType) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.Revision == revisionType).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllServerVault(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.ServerVault).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllServerVaultByType(this Client client, bool vaultType) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.ServerVault == vaultType).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllSessionName(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.SessionName).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllSessionNameByType(this Client client, string sessionName) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.SessionName == sessionName).OrderBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllSignPk(this Client client) =>
            (await client.GetServers()).OrderBy(x => x.SignPk).ThenBy(x => x.ModuleName);

        public async static Task<IOrderedEnumerable<NwServer>> GetAllSignPkByType(this Client client, string pk) =>
            (IOrderedEnumerable<NwServer>)(await client.GetServers()).Where(x => x.SignPk == pk).OrderBy(x => x.ModuleName);

        public async static Task<int> GetBuildCountByType(this Client client, string buildType) =>
            (await client.GetServers()).Count(x => x.Build == buildType);

        public async static Task<int> GetElcCountByType(this Client client, bool elc) =>
            (await client.GetServers()).Count(x => x.ELC == elc);

        public async static Task<int> GetTotalMaxPlayers(this Client client) =>
            (await client.GetServers()).Sum(x => x.MaxPlayers);

        public async static Task<int> GetGameTypeCountByType(this Client client, int gameType) =>
            (await client.GetServers()).Count(x => x.GameType == gameType);

        public async static Task<int> GetILRCountByType(this Client client, bool ilr) =>
            (await client.GetServers()).Count(x => x.ILR == ilr);

        public async static Task<int> GetIPCountByType(this Client client, string ip) =>
            (await client.GetServers()).Count(x => x.IP == ip);

        public async static Task<int> GetKxPkCountByType(this Client client, string kxPkip) =>
            (await client.GetServers()).Count(x => x.KxPk == kxPkip);

        public async static Task<int> GetLanguageCountByType(this Client client, int languageType) =>
            (await client.GetServers()).Count(x => x.Language == languageType);

        public async static Task<int> GetMaxLevelCountByType(this Client client, int levelMax) =>
            (await client.GetServers()).Count(x => x.MaxLevel == levelMax);

        public async static Task<int> GetMinLevelCountByType(this Client client, int levelMin) =>
            (await client.GetServers()).Count(x => x.MinLevel == levelMin);

        public async static Task<int> GetOnePartyCountByType(this Client client, bool oneParty) =>
            (await client.GetServers()).Count(x => x.OneParty == oneParty);

        public async static Task<int> GetOsCountByType(this Client client, int osType) =>
            (await client.GetServers()).Count(x => x.OS == osType);

        public async static Task<int> GetPasswordedCountByType(this Client client, bool password) =>
            (await client.GetServers()).Count(x => x.Passworded == password);

        public async static Task<int> GetPlayerPauseCountByType(this Client client, bool pause) =>
            (await client.GetServers()).Count(x => x.PlayerPause == pause);

        public async static Task<int> GetPortCountByType(this Client client, int port) =>
            (await client.GetServers()).Count(x => x.Port == port);

        public async static Task<int> GetPVPCountByType(this Client client, int pvptype) =>
            (await client.GetServers()).Count(x => x.PVP == pvptype);

        public async static Task<int> GetRevisionCountByType(this Client client, int revisionType) =>
            (await client.GetServers()).Count(x => x.Revision == revisionType);

        public async static Task<int> GetServerVaultCountByType(this Client client, bool servers) =>
            (await client.GetServers()).Count(x => x.ServerVault == servers);

        public async static Task<int> GetSessionNameCountByType(this Client client, string sessionName) =>
            (await client.GetServers()).Count(x => x.SessionName == sessionName);

        public async static Task<int> GetSignPkCountByType(this Client client, string pk) =>
            (await client.GetServers()).Count(x => x.SignPk == pk);

        public async static Task<int> GetTotalPlayerCount(this Client client) =>
            (await client.GetServers()).Sum(x => x.CurrentPlayers);

        public async static Task<int> GetAveragePlayerCountPerServer(this Client client) =>
            (int)((await client.GetServers()).Average(x => x.CurrentPlayers));

        public static bool IsAllSameBuild(this IOrderedEnumerable<NwServer> servers, string buildNumber) =>
            servers.All(x => x.Build.Equals(buildNumber));

        public static bool IsAllSameElc(this IOrderedEnumerable<NwServer> servers, bool elc) =>
            servers.All(x => x.ELC.Equals(elc));

        public static bool IsAllSameGameType(this IOrderedEnumerable<NwServer> servers, int gameType) =>
            servers.All(x => x.GameType.Equals(gameType));

        public static bool IsAllSameILR(this IOrderedEnumerable<NwServer> servers, bool ilr) =>
            servers.All(x => x.ILR.Equals(ilr));

        public static bool IsAllSameIp(this IOrderedEnumerable<NwServer> servers, string ip) =>
            servers.All(x => x.IP.Equals(ip));

        public static bool IsAllSameKxPk(this IOrderedEnumerable<NwServer> servers, string kxPkip) =>
            servers.All(x => x.KxPk.Equals(kxPkip));

        public static bool IsAllSameLanguage(this IOrderedEnumerable<NwServer> servers, int languageType) =>
            servers.All(x => x.Language.Equals(languageType));

        public static bool IsAllSameMaxLevel(this IOrderedEnumerable<NwServer> servers, int levelMax) =>
            servers.All(x => x.MaxLevel.Equals(levelMax));

        public static bool IsAllSameMaxPlayers(this IOrderedEnumerable<NwServer> servers, int players) =>
            servers.All(x => x.MaxPlayers.Equals(players));

        public static bool IsAllSameMinLevel(this IOrderedEnumerable<NwServer> servers, int players) =>
            servers.All(x => x.MinLevel.Equals(players));

        public static bool IsAllSameModuleName(this IOrderedEnumerable<NwServer> servers, string name) =>
            servers.All(x => x.ModuleName.Equals(name));

        public static bool IsAllSameOneParty(this IOrderedEnumerable<NwServer> servers, bool oneParty) =>
            servers.All(x => x.OneParty.Equals(oneParty));

        public static bool IsAllSameOS(this IOrderedEnumerable<NwServer> servers, int osType) =>
            servers.All(x => x.OS.Equals(osType));

        public static bool IsAllSamePassworded(this IOrderedEnumerable<NwServer> servers, bool password) =>
            servers.All(x => x.Passworded.Equals(password));

        public static bool IsAllSamePlayerPause(this IOrderedEnumerable<NwServer> servers, bool pause) =>
            servers.All(x => x.PlayerPause.Equals(pause));

        public static bool IsAllSamePort(this IOrderedEnumerable<NwServer> servers, int port) =>
            servers.All(x => x.Port.Equals(port));

        public static bool IsAllSamePVP(this IOrderedEnumerable<NwServer> servers, int pvptype) =>
            servers.All(x => x.PVP.Equals(pvptype));

        public static bool IsAllSameRevision(this IOrderedEnumerable<NwServer> servers, int revisionType) =>
            servers.All(x => x.Revision.Equals(revisionType));

        public static bool IsAllSameServerVault(this IOrderedEnumerable<NwServer> servers, bool vaultType) =>
            servers.All(x => x.ServerVault.Equals(vaultType));

        public static bool IsAllSameSessionName(this IOrderedEnumerable<NwServer> servers, string sessionName) =>
            servers.All(x => x.SessionName.Equals(sessionName));

        public static bool IsAllSameSignPk(this IOrderedEnumerable<NwServer> servers, string sign) =>
            servers.All(x => x.SignPk.Equals(sign));

        public static bool IsAnySameBuild(this IOrderedEnumerable<NwServer> servers, string buildNumber) =>
            servers.Any(x => x.Build.Equals(buildNumber));

        public static bool IsAnySameElc(this IOrderedEnumerable<NwServer> servers, bool elc) =>
            servers.Any(x => x.ELC.Equals(elc));

        public static bool IsAnySameGameType(this IOrderedEnumerable<NwServer> servers, int gameType) =>
            servers.Any(x => x.GameType.Equals(gameType));

        public static bool IsAnySameILR(this IOrderedEnumerable<NwServer> servers, bool ilr) =>
            servers.Any(x => x.ILR.Equals(ilr));

        public static bool IsAnySameIp(this IOrderedEnumerable<NwServer> servers, string ip) =>
            servers.Any(x => x.IP.Equals(ip));

        public static bool IsAnySameKxPk(this IOrderedEnumerable<NwServer> servers, string kxPkip) =>
            servers.Any(x => x.KxPk.Equals(kxPkip));

        public static bool IsAnySameLanguage(this IOrderedEnumerable<NwServer> servers, int languageType) =>
            servers.Any(x => x.Language.Equals(languageType));

        public static bool IsAnySameMaxLevel(this IOrderedEnumerable<NwServer> servers, int levelMax) =>
            servers.Any(x => x.MaxLevel.Equals(levelMax));

        public static bool IsAnySameMaxPlayers(this IOrderedEnumerable<NwServer> servers, int players) =>
            servers.Any(x => x.MaxPlayers.Equals(players));

        public static bool IsAnySameMinLevel(this IOrderedEnumerable<NwServer> servers, int players) =>
            servers.Any(x => x.MinLevel.Equals(players));

        public static bool IsAnySameModuleName(this IOrderedEnumerable<NwServer> servers, string name) =>
            servers.Any(x => x.ModuleName.Equals(name));

        public static bool IsAnySameOneParty(this IOrderedEnumerable<NwServer> servers, bool oneParty) =>
            servers.Any(x => x.OneParty.Equals(oneParty));

        public static bool IsAnySameOS(this IOrderedEnumerable<NwServer> servers, int osType) =>
            servers.Any(x => x.OS.Equals(osType));

        public static bool IsAnySamePassworded(this IOrderedEnumerable<NwServer> servers, bool password) =>
            servers.Any(x => x.Passworded.Equals(password));

        public static bool IsAnySamePlayerPause(this IOrderedEnumerable<NwServer> servers, bool pause) =>
            servers.Any(x => x.PlayerPause.Equals(pause));

        public static bool IsAnySamePort(this IOrderedEnumerable<NwServer> servers, int port) =>
            servers.Any(x => x.Port.Equals(port));

        public static bool IsAnySamePVP(this IOrderedEnumerable<NwServer> servers, int pvptype) =>
            servers.Any(x => x.PVP.Equals(pvptype));

        public static bool IsAnySameRevision(this IOrderedEnumerable<NwServer> servers, int revisionType) =>
            servers.Any(x => x.Revision.Equals(revisionType));

        public static bool IsAnySameServerVault(this IOrderedEnumerable<NwServer> servers, bool vaultType) =>
            servers.Any(x => x.ServerVault.Equals(vaultType));

        public static bool IsAnySameSessionName(this IOrderedEnumerable<NwServer> servers, string sessionName) =>
            servers.Any(x => x.SessionName.Equals(sessionName));

        public static bool IsAnySameSignPk(this IOrderedEnumerable<NwServer> servers, string sign) =>
            servers.Any(x => x.SignPk.Equals(sign));

        public async static Task<int> GetAverageCurrentPlayers(this Client client) =>
            (int)((await client.GetServers()).Average(x => x.CurrentPlayers));

        public async static Task<int> GetAverageLatency(this Client client) =>
            (int)((await client.GetServers()).Average(x => x.Latency));

        public async static Task<int> GetAverageMaxLevel(this Client client) =>
            (int)((await client.GetServers()).Average(x => x.MaxLevel));
        public async static Task<int> GetAverageMaxPlayers(this Client client) =>
            (int)((await client.GetServers()).Average(x => x.MaxPlayers));

        public async static Task<int> GetAverageMinLevel(this Client client) =>
            (int)((await client.GetServers()).Average(x => x.MinLevel));
    }
}
