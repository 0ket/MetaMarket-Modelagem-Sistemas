using System.ComponentModel.DataAnnotations;

namespace MetaMarket.Application.DTOs;

/// <summary>
/// Entidade que representa uam promoção no MetaMarket
/// </summary>
public class SaleDto
{
    /// <summary>
    /// Nome do promoção
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um nome!")]
    [MaxLength(100)]
    [MinLength(1)]
    public string Name { get; init; }

    /// <summary>
    /// Emails que receberão a promoção
    /// </summary>
    public ICollection<string> Emails { get; init; }

    /// <summary>
    /// Representa Foreign Key do funcionario
    /// </summary>
    public int SalespersonId { get; init; }

    /// <summary>
    /// Representa o vendedor que realiza o envio da promoção
    /// </summary>
    public SalespersonDto Salesperson { get; init; }
}
