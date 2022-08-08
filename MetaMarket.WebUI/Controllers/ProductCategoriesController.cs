using MetaMarket.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MetaMarket.WebUI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductCategoriesController : Controller
    {
        private IProductCategoryService _productCategoryService;

        public ProductCategoriesController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var productCategories = await _productCategoryService.GetCategories();
            return View(productCategories);
        }
    }
}
