using Microsoft.EntityFrameworkCore;

namespace AppVeiculosWeb2023.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }

    }
}
