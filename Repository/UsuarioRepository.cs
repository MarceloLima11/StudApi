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

        public Task<Usuario> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public void Add(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(int idUsuarioAntigo, Usuario newUsuario)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}