using MetaMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetaMarket.Infra.Data.EntitiesConfiguration;

/// <summary>
/// 
/// </summary>
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        //Primary Key
        builder.HasKey(t => t.Id);

        builder.Property(p => p.Name).HasMaxLength(100).IsRequired();

        builder.Property(t => t.Price).HasPrecision(10, 2);

        //defino o relacionamento de um p muitos e defino a foreign Key
        builder.HasOne(t => t.ProductCategory).WithMany(t => t.Products).HasForeignKey(x => x.ProductCategoryId);

        //definir limites para demais props
    }
}
