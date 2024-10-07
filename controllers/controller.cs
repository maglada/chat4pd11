using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]")]
public class MyController : ControllerBase
{
    private readonly MyHttpClient _httpClient;

    public MyController(MyHttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    [HttpGet("get-data")]
    public async Task<IActionResult> GetDataFromApi(string url)
    {
        var data = await _httpClient.GetDataAsync(url);
        return Ok(data);
    }
}

