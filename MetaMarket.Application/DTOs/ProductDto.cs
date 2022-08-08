using MetaMarket.Domain.Validation.Entities;
using System.ComponentModel.DataAnnotations;

namespace MetaMarket.Application.DTOs;

/// <summary>
/// Entidade que representa os produtos do MetaMarket
/// </summary>
public class ProductDto : BaseEntityDto
{
    /// <summary>
    /// Estoque armazenado do produto
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um estoque para o produto!")]
    [MaxLength(100000)]
    [MinLength(1)]
    public int Stock { get; init; }

    /// <summary>
    /// Quantidade/Peso de um produto
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um quantidade/peso!")]
    [MaxLength(1000)]
    [MinLength(1)]
    public float AmountWeight { get; init; }

    // <summary>
    /// Preço de um produto
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um preço!")]
    [MaxLength(10)]
    [MinLength(1)]
    public float Price { get; init; }

    /// <summary>
    /// Foreign Key de uma categoria de produto
    /// </summary>
    public int ProductCategoryId { get; init; }

    /// <summary>
    /// Representa a categoria de um produto
    /// </summary>
    public ProductCategoryDto ProductCategory { get; init; }
}