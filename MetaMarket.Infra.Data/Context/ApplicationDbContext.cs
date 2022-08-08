using MetaMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MetaMarket.Infra.Data.Context;

/// <summary>
/// 
/// </summary>
public class ApplicationDbContext : DbContext
{
    ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    /// <summary>
    /// Representa a tabela de categoria de produtos no banco SQL Server
    /// </summary>
    public DbSet<ProductCategory> ProductCategories { get; set; }

    /// <summary>
    /// Representa a tabela de produtos no banco SQL Server
    /// </summary>
    public DbSet<Product> Products { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
