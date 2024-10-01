using System.Net.Http;
using System.Threading.Tasks;

public class MyHttpClient
{
    private readonly HttpClient _client;

    public MyHttpClient(HttpClient client)
    {
        _client = client;
    }

    public async Task<string> GetDataAsync(string url)
    {
        HttpResponseMessage response = await _client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}

