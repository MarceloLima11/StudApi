using Microsoft.AspNetCore.Mvc;
using StudApi.Models;

namespace StudApi.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class UsuarioController : ControllerBase
{
    public static List<Usuario> Usuarios()
    {
        return new List<Usuario>
        {
            new Usuario{Id = 1, Nome = "Marco", DataNascimento = new DateTime(2002, 12, 19)}
        };
    }

    [HttpGet]
    public IActionResult Get()
    {

        return Ok(Usuarios());
    }


    [HttpPost]
    public IActionResult Post(Usuario usuario)
    {
        var usuarios = Usuarios();
        usuarios.Add(usuario);
        return Ok(usuarios);
    }
}