using MetaMarket.Domain.Validation.Entities;

namespace MetaMarket.Domain.Entities;

/// <summary>
/// Entidade que representa o carrinho de compras do MetaMarket
/// </summary>
public class Cart
{
    /// <summary>
    /// Lista de compras do carrinho
    /// </summary>
    public ICollection<Product> ShoppingList { get; set; }

    /// <summary>
    /// Construtor
    /// </summary>
    /// <param name="shoppingList"></param>
    Cart(ICollection<Product> shoppingList)
    {
        ValidateCart(shoppingList);
    }

    /// <summary>
    /// Lança uma exception, se Cart apresentar algum comportamento inválido
    /// </summary>
    /// <param name="shoppingList"></param>
    private void ValidateCart(ICollection<Product> shoppingList)
    {
        CartExceptionValidation.When(shoppingList.Count < 0, "A Lista de Compras está vazia!");

        ShoppingList = shoppingList;
    }
}
