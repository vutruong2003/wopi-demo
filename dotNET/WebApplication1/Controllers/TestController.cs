using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public TestController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var response = await _httpClient.GetAsync("http://web_app:8080/wopi/files/1");
        response.EnsureSuccessStatusCode();
        var data = await response.Content.ReadAsStringAsync();

        return Ok(data);
    }
}
