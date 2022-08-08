namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa a categoria de um produto do MetaMarket
/// </summary>
public class ProductCategory : BaseEntity
{
    /// <summary>
    /// Uma lista de produtos
    /// </summary>
    public ICollection<Product> Products { get; set; }

    /// <summary>
    /// Construtor da categoria que recebe o nome de uma categoria
    /// </summary>
    /// <param name="name"></param>
    public ProductCategory(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Construtor da categoria que recebe o id e nome de uma categoria
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    public ProductCategory(int id, string name)
    {
        Id = id;
        Name = name;
    }
}