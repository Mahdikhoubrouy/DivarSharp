using Divar.Core.Exceptions;
using Divar.Core.Models;
using Newtonsoft.Json;
using System.Net;

namespace Divar.Corel;

public class Divar
{
    public async Task<SearchModel.SearchRoot> SearchWithUrlAsync(string url,string city)
    {
        var handler = new HttpClientHandler();
        handler.AutomaticDecompression = ~DecompressionMethods.None;

        using (var httpClient = new HttpClient(handler))
        {
            using (var request = new HttpRequestMessage(new HttpMethod("GET"), url))
            {
                request.Headers.TryAddWithoutValidation("authority", "api.divar.ir");
                request.Headers.TryAddWithoutValidation("accept", "application/json, text/plain, */*");
                request.Headers.TryAddWithoutValidation("accept-language", "en-US,en;q=0.9,fa;q=0.8,zh-CN;q=0.7,zh;q=0.6");
                request.Headers.TryAddWithoutValidation("cookie", $"did={Guid.NewGuid()}; multi-city={city}%7C; city={city}; token=; chat_opened=; sessionid=");
                request.Headers.TryAddWithoutValidation("origin", "https://divar.ir");
                request.Headers.TryAddWithoutValidation("referer", "https://divar.ir/");
                request.Headers.TryAddWithoutValidation("sec-ch-ua", "\"Google Chrome\";v=\"113\", \"Chromium\";v=\"113\", \"Not-A.Brand\";v=\"24\"");
                request.Headers.TryAddWithoutValidation("sec-ch-ua-mobile", "?0");
                request.Headers.TryAddWithoutValidation("sec-ch-ua-platform", "\"Windows\"");
                request.Headers.TryAddWithoutValidation("sec-fetch-dest", "empty");
                request.Headers.TryAddWithoutValidation("sec-fetch-mode", "cors");
                request.Headers.TryAddWithoutValidation("sec-fetch-site", "same-site");
                request.Headers.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/113.0.0.0 Safari/537.36");

                var response = await httpClient.SendAsync(request);

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new StatusCodeException(response.StatusCode.ToString());

                var content = await response.Content.ReadAsStringAsync();

                var serialize = JsonConvert.DeserializeObject<SearchModel.SearchRoot>(content);

                return serialize!;
            }
        }
    }
}
