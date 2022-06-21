using Microsoft.AspNetCore.Mvc;
using StudApi.Models;
using StudApi.Repository;

namespace StudApi.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioRepository _usuarioRepository;
    public UsuarioController(IUsuarioRepository UsuarioRepository)
    {
        _usuarioRepository = UsuarioRepository;
    }

    [HttpGet]
    public IActionResult Get()
    {

        return Ok();
    }


    [HttpPost]
    public async Task<IActionResult> Post(Usuario usuario)
    {
        _usuarioRepository.Add(usuario);
        return await _usuarioRepository.SaveChangesAsync() ? Ok("Usuario adicionado com sucesso!") : BadRequest("Erro ao adicionar usuario");
    }
}