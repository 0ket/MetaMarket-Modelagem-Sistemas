using MetaMarket.Domain.Validation.Entities;

namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa o cargo de um funcionario do MetaMarket
/// </summary>
public class Position
{
    /// <summary>
    /// Código que representa o cargo (primary key)
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Nome do cargo
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Representa uma lista de vendedores
    /// </summary>
    public ICollection<Salesperson> Salespeople { get; set; }

    /// <summary>
    /// Construtor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="salespeople"></param>
    Position(string name, ICollection<Salesperson> salespeople)
    {
        ValidatePosition(name, salespeople);
    }

    /// <summary>
    /// Lança uma exception, se Position apresentar algum comportamento inválido
    /// </summary>
    /// <param name="name"></param>
    /// <param name="salespeople"></param>
    private void ValidatePosition(string name, ICollection<Salesperson> salespeople)
    {
        PositionExceptionValidation.When(string.IsNullOrEmpty(name), "O nome do cargo precisa estar preenchido!");
        PositionExceptionValidation.When(salespeople.Count < 0, "A Lista de Compras está vazia!");

        Name = name;
        Salespeople = salespeople;
    }
}