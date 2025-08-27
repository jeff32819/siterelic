using System.Diagnostics;

using Flurl;
using Flurl.Http;

using Newtonsoft.Json;

namespace SiterelicDll
{
    public partial class Api
    {
        public static T ParseJson<T>(string json)
        {
            var data = JsonConvert.DeserializeObject<T>(json);
            return data ?? throw new Exception("data cannot be parsed");
        }
        /// <summary>
        ///     Path base
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static IFlurlRequest GetSiteRelicUrl(string path)
        {
            return new Url("https://api.siterelic.com")
                .WithHeader("x-api-key", "92d4ac75-90b0-41df-b33f-8a09a70a37cf")
                .AppendPathSegment(path);
        }
        private static async Task<T> CallProcess<T>(string endPoint, object request)
        {
            try
            {
                var post = await GetSiteRelicUrl(endPoint).PostJsonAsync(request);
                var result = post.GetStringAsync();

                // ReSharper disable once InvertIf
                if (Debugger.IsAttached)
                {
                    Debug.Print("*************************************************************");
                    Debug.Print("");
                    Debug.Print(result.Result);
                    Debug.Print("");
                    Debug.Print("*************************************************************");
                    var obj = JsonConvert.DeserializeObject(result.Result);
                    var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    const string folder = @"t:\___tmp_siteRelic";
                    Directory.CreateDirectory(folder);
                    await File.WriteAllTextAsync(Path.Combine(folder, $"{endPoint}.txt"), json);
                }

                return ParseJson<T>(result.Result) ?? throw new Exception("data cannot be parsed");
            }
            catch (FlurlHttpException ex)
            {
                var responseString = await ex.GetResponseStringAsync();
                Debug.Print(responseString);
                throw;
            }
        }
    }
}
