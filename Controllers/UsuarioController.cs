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

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var usuario = await _usuarioRepository.Get(id);
        return usuario != null
                ? Ok(usuario)
                : NotFound($"Usuário com id={1} não encontrado." + id);
    }

    [HttpGet("GetUsuarios")]
    public async Task<IActionResult> GetUsuarios()
    {
        var usuarios = await _usuarioRepository.GetUsuarios();
        return usuarios.Any()
                ? Ok(usuarios)
                : NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> Post(Usuario usuario)
    {
        _usuarioRepository.Add(usuario);
        return await _usuarioRepository.SaveChangesAsync()
                ? Ok("Usuario adicionado com sucesso!")
                : BadRequest("Erro ao adicionar usuario!");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Usuario newUsuario)
    {
        var oldUsuario = await _usuarioRepository.Get(id);

        if (oldUsuario == null)
            return NotFound("Usuario não encontrado");

        oldUsuario.Nome = newUsuario.Nome ?? oldUsuario.Nome;
        oldUsuario.DataNascimento = newUsuario.DataNascimento != new DateTime()
        ? oldUsuario.DataNascimento : newUsuario.DataNascimento;

        _usuarioRepository.Update(oldUsuario);

        return await _usuarioRepository.SaveChangesAsync()
                ? Ok("Sucesso ao atualizar!")
                : BadRequest("Erro ao atualizar usuário!");
    }

    [HttpDelete("{id")]
    public async Task<IActionResult> Delete(int id)
    {
        var usuario = await _usuarioRepository.Get(id);

        if (usuario == null)
            return NotFound("Usuario não encontrado");

        _usuarioRepository.Delete(usuario);

        return await _usuarioRepository.SaveChangesAsync()
            ? Ok("Sucesso ao atualizar!")
            : BadRequest("Erro ao atualizar usuário!");
    }
}