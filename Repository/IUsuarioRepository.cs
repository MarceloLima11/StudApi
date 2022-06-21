using StudApi.Models;

namespace StudApi.Repository
{
    public interface IUsuarioRepository
    {

        Task<Usuario> Get(int id);
        Task<IEnumerable<Usuario>> GetUsuarios();
        void Update(int idUsuarioAntigo, Usuario newUsuario);
        void Add(Usuario usuario);
        void delete(int id);

        Task<bool> SaveChangesAsync();
    }
}