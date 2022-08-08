using MetaMarket.Domain.Entities;

namespace MetaMarket.Domain.Interfaces;

/// <summary>
/// 
/// </summary>
public interface IProductRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Product>> GetProductsAsync();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<Product> GetProductsByIdAsync();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<Product> UpdateProductsAsync();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<Product> RemoveProductsAsync();
}
