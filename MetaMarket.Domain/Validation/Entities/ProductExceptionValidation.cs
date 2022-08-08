namespace MetaMarket.Domain.Validation.Entities;

/// <summary>
/// Responsável pelo lançamento de exceções da classe <see cref="Product"/> 
/// </summary>
public class ProductExceptionValidation : Exception
{
    public ProductExceptionValidation(string error) : base(error)
    { }

    public static void When(bool hasError, string error)
    {
        if (hasError)
            throw new ProductExceptionValidation(error);
    }
}
