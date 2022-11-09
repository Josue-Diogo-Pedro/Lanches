
using Lanches.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        DbSet<Categoria> Categorias { get; set; }
        DbSet<Lanche> Lanches { get; set; }
    }
}
