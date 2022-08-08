namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa um usuário no Sistema MetaMarket, seja ele cliente ou funcionário
/// </summary>
public class User
{
    /// <summary>
    /// Nome do usuario
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// CPF do usuário
    /// </summary>
    public string Cpf { get; set; }

    /// <summary>
    /// Número de telefone do usuário
    /// </summary>
    public string PhoneNumber { get; set; }    
}
