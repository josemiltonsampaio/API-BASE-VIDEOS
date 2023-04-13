using Microsoft.EntityFrameworkCore;

namespace VideoAPI.Models;

public class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        for (var i = 1; i <= 1000; i++)
        {
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                Id = i,
                Idade = i,
                Nome = $"Cliente {i}",
                Saldo = (decimal)Math.Truncate(new Random().NextDouble() * 100_000) / 100
            });
        }
    }
}
