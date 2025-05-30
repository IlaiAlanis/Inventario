using Microsoft.EntityFrameworkCore;
using Inventario_ProgWeb.Models;

namespace Inventario_ProgWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
