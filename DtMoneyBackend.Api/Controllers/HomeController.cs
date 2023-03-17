using Microsoft.AspNetCore.Mvc;

namespace DtMoneyBackend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Deu boa mesmo!";
    }
}
