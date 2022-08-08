using MetaMarket.Application.DTOs;

namespace MetaMarket.Application.Interfaces;

/// <summary>
/// 
/// </summary>
public interface IProductCategoryService
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<ProductCategoryDto>> GetCategories();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task <ProductCategoryDto> GetById(int? id);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productCategoryDto"></param>
    /// <returns></returns>
    Task Add(ProductCategoryDto productCategoryDto);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productCategoryDto"></param>
    /// <returns></returns>
    Task Update(ProductCategoryDto productCategoryDto);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task Remove(int? id);
}
