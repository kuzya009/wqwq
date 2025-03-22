using System.Net.Http;
using System.Threading.Tasks;

namespace Discord_rat
{
    class settings
    {
        // Injected by the builder — can be a raw value or a Pastebin raw URL
        public static string Bottoken = "";
        public static string Guildid = "";

        public static async Task Load()
        {
            using var client = new HttpClient();

            if (Bottoken.StartsWith("http"))
            {
                try { Bottoken = (await client.GetStringAsync(Bottoken)).Trim(); } catch { }
            }

            if (Guildid.StartsWith("http"))
            {
                try { Guildid = (await client.GetStringAsync(Guildid)).Trim(); } catch { }
            }
        }
    }
}
