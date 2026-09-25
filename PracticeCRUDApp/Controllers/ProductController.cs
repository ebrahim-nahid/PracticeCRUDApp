using Microsoft.AspNetCore.Mvc;
using PracticeCRUDApp.Models.DTO;
using PracticeCRUDApp.Services.ProductService;

namespace PracticeCRUDApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreteProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreteProduct(PRoductDto pRoductDto) 
        {
            var result = await _productService.CreateProduct(pRoductDto);
            return View();
        }
    }
}
