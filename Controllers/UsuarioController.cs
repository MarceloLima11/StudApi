using Microsoft.AspNetCore.Mvc;

namespace StudApi.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class UsuarioController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Ok!";
    }
}