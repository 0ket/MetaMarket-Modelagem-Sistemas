namespace MetaMarket.Domain.Validation.Entities;

/// <summary>
/// Responsável pelo lançamento de exceções da classe <see cref="Cart"/> 
/// </summary>
public class CartExceptionValidation : Exception
{
    public CartExceptionValidation(string error) : base(error)
    { }

    public static void When(bool hasError, string error)
    {
        if(hasError)
            throw new CartExceptionValidation(error);
    }
}
