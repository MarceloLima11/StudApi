using System.Collections;
using StudApi.Models;

namespace StudApi.Repository
{
    public interface IUsuarioRepository
    {

        Task<Usuario> GetById(int id);
        Task<IEnumerable<Usuario>> GetUsuarios();
        void Update(Usuario newUsuario);
        void Add(Usuario usuario);
        void Delete(Usuario usuario);

        Task<bool> SaveChangesAsync();
    }
}