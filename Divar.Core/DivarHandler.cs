using Divar.Core.Exceptions;
using Divar.Core.Models;
using System.Net;
using System.Text.Json;

namespace Divar.Core;

public class DivarHandler
{
    public async Task<SearchModel.SearchRoot> SearchWithUrlAsync(string url, string city)
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

                var serialize = JsonSerializer.Deserialize<SearchModel.SearchRoot>(content);

                return serialize!;
            }
        }
    }

    public async Task<PostInfoModel.PostInfoRoot> GetPostInfoAsync(string token)
    {
        var handler = new HttpClientHandler();

        handler.AutomaticDecompression = ~DecompressionMethods.None;
        using (var httpClient = new HttpClient(handler))
        {
            using (var request = new HttpRequestMessage(new HttpMethod("GET"), $"https://api.divar.ir/v8/posts/{token}"))
            {
                request.Headers.TryAddWithoutValidation("authority", "api.divar.ir");
                request.Headers.TryAddWithoutValidation("accept", "image/avif,image/webp,image/apng,image/svg+xml,image/*,*/*;q=0.8");
                request.Headers.TryAddWithoutValidation("accept-language", "en-US,en;q=0.9,fa;q=0.8,zh-CN;q=0.7,zh;q=0.6");
                request.Headers.TryAddWithoutValidation("cache-control", "max-age=0");
                request.Headers.TryAddWithoutValidation("sec-ch-ua", "\"Google Chrome\";v=\"113\", \"Chromium\";v=\"113\", \"Not-A.Brand\";v=\"24\"");
                request.Headers.TryAddWithoutValidation("sec-ch-ua-mobile", "?0");
                request.Headers.TryAddWithoutValidation("sec-ch-ua-platform", "\"Windows\"");
                request.Headers.TryAddWithoutValidation("sec-fetch-dest", "image");
                request.Headers.TryAddWithoutValidation("sec-fetch-mode", "no-cors");
                request.Headers.TryAddWithoutValidation("sec-fetch-site", "same-origin");
                request.Headers.TryAddWithoutValidation("sec-fetch-user", "?1");
                request.Headers.TryAddWithoutValidation("upgrade-insecure-requests", "1");
                request.Headers.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/113.0.0.0 Safari/537.36");
                request.Headers.TryAddWithoutValidation("referer", $"https://api.divar.ir/v8/posts/{token}");

                var response = await httpClient.SendAsync(request);

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new StatusCodeException(response.StatusCode.ToString());

                var content = await response.Content.ReadAsStringAsync();

                var serialize = JsonSerializer.Deserialize<PostInfoModel.PostInfoRoot>(content);

                return serialize;
            }
        }
    }
}
