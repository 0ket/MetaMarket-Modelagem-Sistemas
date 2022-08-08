using MetaMarket.Domain.Entities;
using MetaMarket.Domain.Interfaces;
using MetaMarket.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace MetaMarket.Infra.Data.Repositories;

/// <summary>
/// 
/// </summary>
public class ProductCategoryRepository : IProductCategoryRepository
{
    ApplicationDbContext _productCategoryContext;
    ProductCategoryRepository(ApplicationDbContext context)
    {
        context = _productCategoryContext;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productCategory"></param>
    /// <returns></returns>
    public async Task<ProductCategory> CreateCategoryAsync(ProductCategory productCategory)
    {
        _productCategoryContext.Add(productCategory);
        await _productCategoryContext.SaveChangesAsync();
        return productCategory;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<ProductCategory>> GetCategoriesAsync()
    {
        return await _productCategoryContext.ProductCategories.ToListAsync();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<ProductCategory> GetCategoriesByIdAsync(int? id)
    {
        return await _productCategoryContext.ProductCategories.FindAsync(id);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productCategory"></param>
    /// <returns></returns>
    public async Task<ProductCategory> RemoveCategoryAsync(ProductCategory productCategory)
    {
        _productCategoryContext.Remove(productCategory);
        await _productCategoryContext.SaveChangesAsync();
        return productCategory;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productCategory"></param>
    /// <returns></returns>
    public async Task<ProductCategory> UpdateCategoryAsync(ProductCategory productCategory)
    {
        _productCategoryContext.Update(productCategory);
        await _productCategoryContext.SaveChangesAsync();
        return productCategory;
    }
}
