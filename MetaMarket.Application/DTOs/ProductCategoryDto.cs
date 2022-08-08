namespace MetaMarket.Application.DTOs;
/// <summary>
/// Entidade que representa a categoria de um produto do MetaMarket
/// </summary>
public class ProductCategoryDto : BaseEntityDto
{
    /// <summary>
    /// Uma lista de produtos
    /// </summary>
    public ICollection<ProductDto> Products { get; init; }
}