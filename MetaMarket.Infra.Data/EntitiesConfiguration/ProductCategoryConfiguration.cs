using MetaMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetaMarket.Infra.Data.EntitiesConfiguration;

/// <summary>
/// 
/// </summary>
public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
/// <summary>
/// 
/// </summary>
/// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {

        //Primary Key
        builder.HasKey(t => t.Id);

        // IsRequired() é o mesmo que nullable == false
        builder.Property(p => p.Name).HasMaxLength(100).IsRequired();

        //definir limites para demais props
    }
}
