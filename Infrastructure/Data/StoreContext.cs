using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Infrastructure.Config;

namespace Infrastructure.Data;

public class StoreContext(DbContextOptions<StoreContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
    }
}
