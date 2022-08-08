namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa um funcionário/vendedor do MetaMarket
/// </summary>
public class Salesperson : User
{
    /// <summary>
    /// Codigo que representa o vendedor (primary key)
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Caixa de operação do vendedor
    /// </summary>
    public string OperationTeller { get; set; }

    /// <summary>
    /// Representa a promoção feita/enviada pelo vendedor
    /// </summary>
    public ICollection<Sale> Sales { get; set; }

    /// <summary>
    /// Representa a Foreign Key do cargo
    /// </summary>
    public int PositionId { get; set; }

    /// <summary>
    /// Representa o cargo do vendedor
    /// </summary>
    public Position Position {get; set; }

    /// <summary>
    /// Representa uma venda que o vendedor realizou
    /// </summary>
    public ICollection<SalePurchase> SalesPurchases { get; set; }
}
