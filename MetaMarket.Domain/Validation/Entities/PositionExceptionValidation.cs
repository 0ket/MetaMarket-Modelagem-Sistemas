namespace MetaMarket.Domain.Validation.Entities;

/// <summary>
/// Responsável pelo lançamento de exceções da classe <see cref="Position"/> 
/// </summary>
public class PositionExceptionValidation : Exception
{
    public PositionExceptionValidation(string error) : base(error)
    { }

    public static void When(bool hasError, string error)
    {
        if (hasError)
            throw new PositionExceptionValidation(error);
    }
}
