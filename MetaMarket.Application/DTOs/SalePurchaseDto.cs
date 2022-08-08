using System.ComponentModel.DataAnnotations;

namespace MetaMarket.Application.DTOs;

/// <summary>
/// Entidade que representa uma Compra/Venda no MetaMarket
/// </summary>
public class SalePurchaseDto
{
    /// <summary>
    /// Valor da Compra/Venda
    /// </summary>
    public float Amount { get; init; }

    /// <summary>
    /// Data e hora da compra/venda
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um data!")]
    [MaxLength(8)]
    [MinLength(6)]
    public DateTime Date { get; init; }

    /// <summary>
    /// Endereço do supermercado MetaMarket
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe o endereço!")]
    [MaxLength(500)]
    [MinLength(5)]
    public float Address { get; init; }

    /// <summary>
    /// CNPJ do supermercado MetaMarket
    /// </summary>
    [Required(ErrorMessage = "Por favor, informe um cnpj!")]
    [MaxLength(14)]
    [MinLength(14)]
    public string Cnpj { get; init; }

    /// <summary>
    /// Representa a Foreign Key do Cliente
    /// </summary>
    public int ClientId { get; init; }
    /// <summary>
    /// Representa o cliente que realiza a compra
    /// </summary>
    public ClientDto Client { get; init; }

    /// <summary>
    /// Representa a Foreign Key do vendedor
    /// </summary>
    public int SalePersonId { get; init; }

    /// <summary>
    /// Representa o vendedor da venda realizada
    /// </summary>
    public SalespersonDto Salesperson { get; init; }
}
