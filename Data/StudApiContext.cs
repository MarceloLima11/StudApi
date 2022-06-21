using Microsoft.EntityFrameworkCore;
using StudApi.Models;

namespace StudApi.Data
{
    public class StudApiContext : DbContext
    {
        public StudApiContext(DbContextOptions<StudApiContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}