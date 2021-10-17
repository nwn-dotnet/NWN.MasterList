using System;
using System.Collections.Generic;
using System.Linq;
using NWN.MasterList.Data;

namespace NWN.MasterList
{
    public static class Helper
    {
        public static int MasterListPositionFromSessionName(this IEnumerable<NwServer> servers, List<NwServer> nwServer, string sessionName) =>
            servers.Where(s => s.SessionName == sessionName).Select(self => nwServer.IndexOf(self)).FirstOrDefault();

        public static IOrderedEnumerable<NwServer> GetAllBuild(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.Build).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllBuildByType(this IEnumerable<NwServer> servers, string buildNumber) =>
            servers.Where(x => x.Build == buildNumber).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllConnectHint(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.ConnectHint).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllCurrentPlayersByModuleName(this IEnumerable<NwServer> servers) =>
            servers.OrderByDescending(x => x.CurrentPlayers).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllElc(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.ELC).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllElcByType(this IEnumerable<NwServer> servers, bool setting) =>
            servers.Where(x => x.ELC == setting).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllFirstSeen(this IEnumerable<NwServer> servers)
        {
            return servers.OrderBy(x => x.FirstSeen).ThenBy(x => x.ModuleName);
        }

        public static IOrderedEnumerable<NwServer> GetAllGameType(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.GameType).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllGameTypeByType(this IEnumerable<NwServer> servers, int gameType) =>
            servers.Where(x => x.GameType == gameType).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetILRAll(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.ILR).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllIlrByType(this IEnumerable<NwServer> servers, bool ilr) =>
            servers.Where(x => x.ILR == ilr).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetIpsAll(this IEnumerable<NwServer> servers) =>
        servers.OrderBy(x => Version.Parse(x.IP)).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllServersByIp(this IEnumerable<NwServer> servers, string ip) =>
            servers.OrderBy(x => x.IP == ip).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllKxPk(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.KxPk).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllServersByKxPk(this IEnumerable<NwServer> servers, string kxPkip) =>
            servers.Where(x => x.KxPk == kxPkip).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllLanguage(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.Language).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllLanguageByType(this IEnumerable<NwServer> servers, int languageType) =>
            servers.Where(x => x.Language == languageType).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllLastAdvertisement(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.LastAdvertisement).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllLatency(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.Latency).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetLatencyGreaterThan(this IEnumerable<NwServer> servers, int latencyRate) =>
            servers.Where(x => x.Latency > latencyRate).OrderBy(x => x.Latency).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetLatencyLesserThan(this IEnumerable<NwServer> servers, int latencyRate) =>
            servers.Where(x => x.Latency < latencyRate).OrderBy(x => x.Latency).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetLatencyRange(this IEnumerable<NwServer> servers, int low = 0, int high = int.MaxValue) =>
            servers.Where(x => x.Latency >= low && x.Latency <= high).OrderBy(x => x.Latency).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetMaxLevelGreaterThan(this IEnumerable<NwServer> servers, int levelMax) =>
            servers.Where(x => x.MaxLevel > levelMax).OrderBy(x => x.MaxLevel).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetMaxLevelLesserThan(this IEnumerable<NwServer> servers, int levelMax) =>
            servers.Where(x => x.MaxLevel < levelMax).OrderBy(x => x.MaxLevel).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetMaxLevelRange(this IEnumerable<NwServer> servers, int low = 1, int high = int.MaxValue) =>
            servers.Where(x => x.MaxLevel >= low && x.MaxLevel <= high).OrderBy(x => x.MaxLevel).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetMinLevelGreaterThan(this IEnumerable<NwServer> servers, int levelMin) =>
            servers.Where(x => x.MinLevel > levelMin).OrderBy(x => x.MinLevel).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetMinLevelLesserThan(this IEnumerable<NwServer> servers, int levelMin) =>
            servers.Where(x => x.MinLevel < levelMin).OrderBy(x => x.MinLevel).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetMinLevelRange(this IEnumerable<NwServer> servers, int low = 1, int high = int.MaxValue) =>
            servers.Where(x => x.MinLevel >= low && x.MinLevel <= high).OrderBy(x => x.MinLevel).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllModuleDescription(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.ModuleDescription).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllByModuleName(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllNwSyncUrls(this IEnumerable<NwServer> servers)
        {
            return servers.Where(x => !String.IsNullOrWhiteSpace(x.NwSync.URL)).OrderBy(x => x.NwSync.URL);
        }

        // TODO #18
        /*public static IOrderedEnumerable<NwServer> GetAllNwSyncManifestHash(this IEnumerable<NwServer> servers)
        {
            return (servers.Select(x => x.NwSync.Manifests.Where(y => y.Hash != string.Empty))).OrderBy(x => x.ModuleName);
        }*/

        public static IOrderedEnumerable<NwServer> GetAllOneParty(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.OneParty).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetOnePartyByType(this IEnumerable<NwServer> servers, bool oneParty) =>
            servers.Where(x => x.OneParty == oneParty).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllOS(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.OS).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllOSByType(this IEnumerable<NwServer> servers, int osType) =>
            servers.Where(x => x.OS == osType).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllOsByTypePlayerDescending(this IEnumerable<NwServer> servers, int osType) =>
            servers.Where(x => x.OS == osType).OrderByDescending(x => x.CurrentPlayers).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllPassworded(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.Passworded).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetPasswordedByType(this IEnumerable<NwServer> servers, bool password) =>
            servers.Where(x => x.Passworded == password).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllPlayerPause(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.PlayerPause).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetPlayerPauseByType(this IEnumerable<NwServer> servers, bool pause) =>
            servers.Where(x => x.PlayerPause == pause).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetPortGreaterThan(this IEnumerable<NwServer> servers, int portNumber) =>
            servers.Where(x => x.Port > portNumber).OrderBy(x => x.Port).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetPortLesserThan(this IEnumerable<NwServer> servers, int portNumber) =>
            servers.Where(x => x.Port < portNumber).OrderBy(x => x.Port).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetPortRange(this IEnumerable<NwServer> servers, int low = 0, int high = 65535) =>
            servers.Where(x => x.Port >= low && x.Port <= high).OrderBy(x => x.Port).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllByPortNumber(this IEnumerable<NwServer> servers, int portNumber) =>
            servers.Where(x => x.Port == portNumber).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllPvp(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.PVP).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllPvPByType(this IEnumerable<NwServer> servers, int pvptype) =>
            servers.Where(x => x.PVP == pvptype).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllRevision(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.Revision).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllRevisionByType(this IEnumerable<NwServer> servers, int revisionType) =>
            servers.Where(x => x.Revision == revisionType).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllServerVault(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.ServerVault).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllServerVaultByType(this IEnumerable<NwServer> servers, bool vaultType) =>
            servers.Where(x => x.ServerVault == vaultType).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllSessionName(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.SessionName).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllSessionNameByType(this IEnumerable<NwServer> servers, string sessionName) =>
            servers.Where(x => x.SessionName == sessionName).OrderBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllSignPk(this IEnumerable<NwServer> servers) =>
            servers.OrderBy(x => x.SignPk).ThenBy(x => x.ModuleName);

        public static IOrderedEnumerable<NwServer> GetAllSignPkByType(this IEnumerable<NwServer> servers, string pk) =>
            servers.Where(x => x.SignPk == pk).OrderBy(x => x.ModuleName);

        public static int GetBuildCountByType(this IEnumerable<NwServer> servers, string buildType) =>
            servers.Count(x => x.Build == buildType);

        public static int GetElcCountByType(this IEnumerable<NwServer> servers, bool elc) =>
            servers.Count(x => x.ELC == elc);

        public static int GetTotalMaxPlayers(this IEnumerable<NwServer> servers) =>
            servers.Sum(x => x.MaxPlayers);

        public static int GetGameTypeCountByType(this IEnumerable<NwServer> servers, int gameType) =>
            servers.Count(x => x.GameType == gameType);

        public static int GetILRCountByType(this IEnumerable<NwServer> servers, bool ilr) =>
            servers.Count(x => x.ILR == ilr);

        public static int GetIPCountByType(this IEnumerable<NwServer> servers, string ip) =>
            servers.Count(x => x.IP == ip);

        public static int GetKxPkCountByType(this IEnumerable<NwServer> servers, string kxPkip) =>
            servers.Count(x => x.KxPk == kxPkip);

        public static int GetLanguageCountByType(this IEnumerable<NwServer> servers, int languageType) =>
            servers.Count(x => x.Language == languageType);

        public static int GetMaxLevelCountByType(this IEnumerable<NwServer> servers, int levelMax) =>
            servers.Count(x => x.MaxLevel == levelMax);

        public static int GetMinLevelCountByType(this IEnumerable<NwServer> servers, int levelMin) =>
            servers.Count(x => x.MinLevel == levelMin);

        public static int GetOnePartyCountByType(this IEnumerable<NwServer> servers, bool oneParty) =>
            servers.Count(x => x.OneParty == oneParty);

        public static int GetOsCountByType(this IEnumerable<NwServer> servers, int osType) =>
            servers.Count(x => x.OS == osType);

        public static int GetPasswordedCountByTyp(this IEnumerable<NwServer> servers, bool password) =>
            servers.Count(x => x.Passworded == password);

        public static int GetPlayerPauseCountByTye(this IEnumerable<NwServer> servers, bool pause) =>
            servers.Count(x => x.PlayerPause == pause);

        public static int GetPortCountByType(this IEnumerable<NwServer> servers, int port) =>
            servers.Count(x => x.Port == port);

        public static int GetPVPCountByType(this IEnumerable<NwServer> servers, int pvptype) =>
            servers.Count(x => x.PVP == pvptype);

        public static int GetRevisionCountByType(this IEnumerable<NwServer> servers, int revisionType) =>
            servers.Count(x => x.Revision == revisionType);

        public static int GetServerVaultCountByType(this IEnumerable<NwServer> servers, bool vaultType) =>
            servers.Count(x => x.ServerVault == vaultType);

        public static int GetSessionNameCountByTye(this IEnumerable<NwServer> servers, string sessionName) =>
            servers.Count(x => x.SessionName == sessionName);

        public static int GetSignPkCountByType(this IEnumerable<NwServer> servers, string pk) =>
            servers.Count(x => x.SignPk == pk);

        public static int GetTotalPlayerCount(this IEnumerable<NwServer> servers) =>
            servers.Sum(x => x.CurrentPlayers);

        public static int GetAveragePlayerCountPeServer(this IEnumerable<NwServer> servers) =>
            (int)(servers.Average(x => x.CurrentPlayers));

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

        public static int GetAverageCurrentPlayer(this IEnumerable<NwServer> servers) =>
            (int)(servers.Average(x => x.CurrentPlayers));

        public static int GetAverageLatency(this IEnumerable<NwServer> servers) =>
            (int)(servers.Average(x => x.Latency));

        public static int GetAverageMaxLevel(this IEnumerable<NwServer> servers) =>
            (int)(servers.Average(x => x.MaxLevel));
        public static int GetAverageMaxPlayers(this IEnumerable<NwServer> servers) =>
            (int)(servers.Average(x => x.MaxPlayers));

        public static int GetAverageMinLevel(this IEnumerable<NwServer> servers) =>
            (int)(servers.Average(x => x.MinLevel));
        
        public static List<string> GetUniqueVersion(this IEnumerable<NwServer> servers)
        {
            IOrderedEnumerable<NwServer> collection = servers.OrderByDescending(x => x.Build).ThenByDescending(x => x.Revision);
            List<string> data = new List<string>();

            foreach (NwServer server in collection)
            {
                string temp = $"{server.Build}:{server.Revision}";

                if (!data.Contains(temp))
                {
                    data.Add(temp);
                }
            }
            return data;
        }

        public static Dictionary<string, int> GetUniqueVersionCount(this IEnumerable<NwServer> servers)
        {
            IOrderedEnumerable<NwServer> collection = servers.OrderByDescending(x => x.Build).ThenByDescending(x => x.Revision);
            Dictionary<string, int> data = new Dictionary<string, int>();

            foreach (NwServer server in collection)
            {
                string temp = $"{server.Build}:{server.Revision}";

                if (data.ContainsKey(temp))
                {
                    data[temp]++;
                }
                else
                {
                    data.Add(temp, 1);
                }
            }
            return data;
        }
    }
}
