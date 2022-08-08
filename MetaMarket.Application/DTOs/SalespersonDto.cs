using System.ComponentModel.DataAnnotations;

namespace MetaMarket.Application.DTOs;

/// <summary>
/// Entidade que representa um funcionário/vendedor do MetaMarket
/// </summary>
public class SalespersonDto : UserDto
{
    /// <summary>
    /// Codigo que representa o vendedor (primary key)
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Caixa de operação do vendedor
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um caixa de operação!")]
    [MaxLength(50)]
    [MinLength(1)]
    public string OperationTeller { get; init; }

    /// <summary>
    /// Representa a promoção feita/enviada pelo vendedor
    /// </summary>
    [MaxLength(100)]
    [MinLength(5)]
    public ICollection<SaleDto> Sales { get; init; }

    /// <summary>
    /// Representa a Foreign Key do cargo
    /// </summary>
    public int PositionId { get; init; }

    /// <summary>
    /// Representa o cargo do vendedor
    /// </summary>
    public PositionDto Position {get; init; }

    /// <summary>
    /// Representa uma venda que o vendedor realizou
    /// </summary>
    public ICollection<SalePurchaseDto> SalesPurchases { get; init; }
}
