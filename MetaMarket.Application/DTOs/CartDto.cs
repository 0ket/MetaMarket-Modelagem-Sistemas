using MetaMarket.Domain.Validation.Entities;

namespace MetaMarket.Application.DTOs;

/// <summary>
/// Entidade que representa o carrinho de compras do MetaMarket
/// </summary>
public class CartDto
{
    /// <summary>
    /// Lista de compras do carrinho
    /// </summary>
    public ICollection<ProductDto> ShoppingList { get; init; }
}
