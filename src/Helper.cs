using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NWN.MasterList {
  public class Helper {
    static async Task<int> MasterListPositionFromSessionName(string sessionName) {
      List<Server.Data> servers = await Servers.Get();
      return servers.Where(s => s.SessionName == sessionName).Select(self => servers.IndexOf(self)).FirstOrDefault();
    }
  }
}