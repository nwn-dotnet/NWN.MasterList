using System.Collections.Generic;
using System.Linq;
using NWN.MasterList.Data;

namespace NWN.MasterList {
  public static class Helper {
    public static int MasterListPositionFromSessionName(List<NwServer> servers, string sessionName) =>
      servers.Where(s => s.SessionName == sessionName).Select(self => servers.IndexOf(self)).FirstOrDefault();

    public static IOrderedEnumerable<NwServer> GetAllFirstSeen(List<NwServer> servers) =>
      servers.OrderByDescending(x => x.FirstSeen);
  }
}