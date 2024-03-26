using Microsoft.EntityFrameworkCore;
using TiposRelacionamentos.Models;

namespace TiposRelacionamentos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<CasaModel> Casas { get; set; }

        public DbSet<EnderecoModel> Enderecos { get; set; }

        public DbSet<MoradorModel> Moradores { get; set; }
    }
}
