using MetaMarket.Domain.Validation.Entities;

namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa o cliente do MetaMarket
/// </summary>
public class Client : User
{
    /// <summary>
    /// Id do usuario (primary Key)
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Email do Cliente
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Representa uma lista de compras
    /// </summary>
    public ICollection<SalePurchase> SalesOrPurchases { get; set; }

    /// <summary>
    /// Construtor
    /// </summary>
    /// <param name="email"></param>
    Client(string email)
    {   
        if(ClientExceptionValidation.IsValidEmail(email))
            Email = email;
    }
}
