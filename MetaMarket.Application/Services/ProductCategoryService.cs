using AutoMapper;
using MetaMarket.Application.DTOs;
using MetaMarket.Application.Interfaces;
using MetaMarket.Domain.Entities;
using MetaMarket.Domain.Interfaces;

namespace MetaMarket.Application.Services;

/// <summary>
/// 
/// </summary>
public class ProductCategoryService : IProductCategoryService
{
    private IProductCategoryRepository _productCategoryRepository;
    private readonly IMapper _mapper;

    public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IMapper mapper)
    {
        _productCategoryRepository = productCategoryRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<ProductCategoryDto>> GetCategories()
    {
        var productCategoriesEntity = await _productCategoryRepository.GetCategoriesAsync();
        return _mapper.Map<IEnumerable<ProductCategoryDto>>(productCategoriesEntity);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<ProductCategoryDto> GetById(int? id)
    {
        var productCategoryEntity = await _productCategoryRepository.GetCategoriesByIdAsync(id);
        return _mapper.Map<ProductCategoryDto>(productCategoryEntity);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productCategoryDto"></param>
    /// <returns></returns>
    public async Task Add(ProductCategoryDto productCategoryDto)
    {
        var productCategoryEntity = _mapper.Map<ProductCategory>(productCategoryDto);
        await _productCategoryRepository.CreateCategoryAsync(productCategoryEntity);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productCategoryDto"></param>
    /// <returns></returns>
    public async Task Update(ProductCategoryDto productCategoryDto)
    {
        var productCategoryEntity = _mapper.Map<ProductCategory>(productCategoryDto);
        await _productCategoryRepository.UpdateCategoryAsync(productCategoryEntity);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task Remove(int? id)
    {
        var productCategoryEntity = _productCategoryRepository.GetCategoriesByIdAsync(id).Result;
        await _productCategoryRepository.RemoveCategoryAsync(productCategoryEntity);
    }
}
