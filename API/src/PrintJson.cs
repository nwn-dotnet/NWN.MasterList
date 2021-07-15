using System.Threading.Tasks;
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using NWN.MasterList.Data;

namespace NWN.MasterList
{
    public static class PrintJson
    {
        private const string path = @"";

        private static string PrettyJson(string unPrettyJson)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);

            return JsonSerializer.Serialize(jsonElement, options);
        }
    }
}