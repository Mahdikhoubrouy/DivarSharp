using Divar.Core.Exceptions;
using Divar.Core.Models;
using System;
using System.Net;
using System.Text.Json;

namespace Divar.Core;

public class DivarHandler
{
    private DivarHandlerMakeHttpClient MakeClient(Dictionary<string, string> headers, HttpRequestMessage request)
    {
        var handler = new HttpClientHandler();
        handler.AutomaticDecompression = ~DecompressionMethods.None;
        var client = new HttpClient(handler);

        foreach (var header in headers)
        {
            request.Headers.TryAddWithoutValidation(header.Key, header.Value);
        }

        return new DivarHandlerMakeHttpClient { HttpClient = client, HttpRequestMessage = request };
    }

    public async Task<SearchModel.SearchRoot> SearchWithUrlAsync(string url, string city)
    {
        var headers = new Dictionary<string, string>()
        {
            {"authority", "api.divar.ir" },
            {"accept", "application/json, text/plain, */*" },
            {"accept-language", "en-US,en;q=0.9,fa;q=0.8,zh-CN;q=0.7,zh;q=0.6" },
            {"cookie", $"did={Guid.NewGuid()}; multi-city={city}%7C; city={city}; token=; chat_opened=; sessionid=" }
        };

        var httpClientProvider = MakeClient(headers, new HttpRequestMessage(new HttpMethod("GET"), url));


        var response = await httpClientProvider.HttpClient.SendAsync(httpClientProvider.HttpRequestMessage);

        if (response.StatusCode != HttpStatusCode.OK)
            throw new StatusCodeException(response.StatusCode.ToString());

        var content = await response.Content.ReadAsStringAsync();

        var serialize = JsonSerializer.Deserialize<SearchModel.SearchRoot>(content);

        return serialize!;
    }

    public async Task<PostInfoModel.PostInfoRoot> GetPostInfoAsync(string token)
    {

        var headers = new Dictionary<string, string>()
        {
            {"authority", "api.divar.ir" },
            {"accept", "image/avif,image/webp,image/apng,image/svg+xml,image/*,*/*;q=0.8"},
            {"accept-language", "en-US,en;q=0.9,fa;q=0.8,zh-CN;q=0.7,zh;q=0.6" },
            {"referer", $"https://api.divar.ir/v8/posts/{token}" }
        };

        var httpClientProvider = MakeClient(headers, new HttpRequestMessage(new HttpMethod("GET"), $"https://api.divar.ir/v8/posts/{token}"));


        var response = await httpClientProvider.HttpClient.SendAsync(httpClientProvider.HttpRequestMessage);

        if (response.StatusCode != HttpStatusCode.OK)
            throw new StatusCodeException(response.StatusCode.ToString());

        var content = await response.Content.ReadAsStringAsync();

        var serialize = JsonSerializer.Deserialize<PostInfoModel.PostInfoRoot>(content);

        return serialize;
    }
}
