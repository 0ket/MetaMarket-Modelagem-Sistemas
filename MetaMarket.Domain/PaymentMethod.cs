namespace MetaMarket.Domain;

/// <summary>
/// Representa o tipo do metodo de pagamento
/// </summary>
public enum PaymentMethod
{
    Cash,
    DebitCard,
    CreditCard,
    Check,
    Pix,
    MobileWallet,
}
