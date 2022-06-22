using Microsoft.EntityFrameworkCore;
using StudApi.Data;
using StudApi.Models;

namespace StudApi.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly StudApiContext _context;

        public UsuarioRepository(StudApiContext context)
        {
            _context = context;
        }

        public async Task<Usuario> GetById(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public void Add(Usuario usuario)
        {
            _context.Add(usuario);
        }

        public void Update(Usuario attUsuario)
        {
            //var oldUsuario = _context.Usuarios.Where(x => x.Id == newUsuario.Id);
            _context.Usuarios.Update(attUsuario);
        }

        public void Delete(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}