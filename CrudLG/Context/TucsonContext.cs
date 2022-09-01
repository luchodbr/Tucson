using CrudLG.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudLG.Context
{
    public class TucsonContext : DbContext
    {
        public TucsonContext() 
        {
        }
        public TucsonContext(DbContextOptions<TucsonContext> options) : base(options)
        {
        }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Mesa> Mesa { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
