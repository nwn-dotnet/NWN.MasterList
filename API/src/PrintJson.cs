using System.Text.Json;
namespace NWN.MasterList {
    public static class PrintJson {
        // TODO #15
        private const string Path = @"";

        //https://stackoverflow.com/a/63560258/11986604
        private static string PrettyJson(string unPrettyJson) {
            var options = new JsonSerializerOptions() {
                WriteIndented = true
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);

            return JsonSerializer.Serialize(jsonElement, options);
        }
    }
}