using DtMoneyBackend.Entities;
using Microsoft.EntityFrameworkCore;
namespace DtMoneyBackend.Data;

public class DtMoneyBackendContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(connectionString: "Host=localhost;Port=5432;Pooling=true;Database=DtMoney;User Id=postgres;Password=123456;");
    }
    public DbSet<Transaction>? Transaction { get; set; }
    public DbSet<Category>? Category { get; set; }
}