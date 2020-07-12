using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NWN.MasterList {
  public class Helper {
    static async Task<int> MasterListPositionFromSessionName(string sessionName) {
      var servers = await Servers.Get();
      var test = servers.OrderByDescending(o => o.current_players).ToList();
      foreach (var s in test.Where(s => s.session_name == sessionName))
        return test.IndexOf(s);
    }
  }
}