using MetaMarket.Domain.Entities;

namespace MetaMarket.Domain.Interfaces;

/// <summary>
/// 
/// </summary>
public interface IProductCategoryRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<ProductCategory>> GetCategoriesAsync();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<ProductCategory> GetCategoriesByIdAsync(int? id);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productCategory"></param>
    /// <returns></returns>
    Task<ProductCategory> CreateCategoryAsync(ProductCategory productCategory);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productCategory"></param>
    /// <returns></returns>
    Task<ProductCategory> UpdateCategoryAsync(ProductCategory productCategory);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productCategory"></param>
    /// <returns></returns>
    Task<ProductCategory> RemoveCategoryAsync(ProductCategory productCategory);
}
