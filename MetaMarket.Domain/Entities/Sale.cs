namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa uam promoção no MetaMarket
/// </summary>
public class Sale
{
    /// <summary>
    /// Nome do promoção
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Emails que receberão a promoção
    /// </summary>
    public ICollection<string> Emails { get; set; }

    /// <summary>
    /// Representa Foreign Key do funcionario
    /// </summary>
    public int SalespersonId { get; set; }

    /// <summary>
    /// Representa o vendedor que realiza o envio da promoção
    /// </summary>
    public Salesperson Salesperson { get; set; }
}
