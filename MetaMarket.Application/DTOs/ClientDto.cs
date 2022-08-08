using MetaMarket.Domain.Validation.Entities;
using System.ComponentModel.DataAnnotations;

namespace MetaMarket.Application.DTOs;

/// <summary>
/// Entidade que representa o cliente do MetaMarket
/// </summary>
public class ClientDto : UserDto
{
    /// <summary>
    /// Id do usuario (primary Key)
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Email do Cliente
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um email!")]
    [MaxLength(100)]
    [MinLength(10)]
    public string Email { get; init; }

    /// <summary>
    /// Representa uma lista de compras
    /// </summary>
    public ICollection<SalePurchaseDto> SalesOrPurchases { get; init; }
}
