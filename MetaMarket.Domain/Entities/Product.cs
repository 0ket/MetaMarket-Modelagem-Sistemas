using MetaMarket.Domain.Validation.Entities;

namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa os produtos do MetaMarket
/// </summary>
public class Product : BaseEntity
{
    /// <summary>
    /// Estoque armazenado do produto
    /// </summary>
    public int Stock { get; set; }

    /// <summary>
    /// Quantidade/Peso de um produto
    /// </summary>
    public float AmountWeight { get; set; }

    // <summary>
    /// Preço de um produto
    /// </summary>
    public float Price { get; set; }

    /// <summary>
    /// Foreign Key de uma categoria de produto
    /// </summary>
    public int ProductCategoryId { get; set; }

    /// <summary>
    /// Representa a categoria de um produto
    /// </summary>
    public ProductCategory ProductCategory { get; set; }

    /// <summary>
    /// Construtor sem Id
    /// </summary>
    /// <param name="name"></param>
    /// <param name="stock"></param>
    /// <param name="amountWeight"></param>
    /// <param name="price"></param>
    Product(string name, int stock, float amountWeight, float price)
    {
        ValidateProduct(name, stock, amountWeight, price);
    }

    /// <summary>
    /// Construtor sem Id
    /// </summary>
    /// <param name="name"></param>
    /// <param name="stock"></param>
    /// <param name="amountWeight"></param>
    /// <param name="price"></param>
    Product(int id, string name, int stock, float amountWeight, float price)
    {
        ProductExceptionValidation.When(id < 0, "O Codigo do produto é invalido!");
        Id = id;
        ValidateProduct(name, stock, amountWeight, price);
    }

    public void Update(string name, int stock, float amountWeight, float price, int productCategoryId)
    {
        ValidateProduct(name, stock, amountWeight, price);
        ProductCategoryId = productCategoryId;
    }

    private void ValidateProduct(string name, int stock, float amountWeight, float price)
    {
        ProductExceptionValidation.When(string.IsNullOrEmpty(name), "O nome do produto é invalido!");
        ProductExceptionValidation.When(stock < 0, "O estoque do produto é invalido!");
        ProductExceptionValidation.When(amountWeight < 0, "A quantidade/peso do produto é invalida!");
        ProductExceptionValidation.When(price < 0, "O preço do produto é inválido!");

        Name = name;
        Stock = stock;
        AmountWeight = amountWeight;
        Price = price;
    }
}