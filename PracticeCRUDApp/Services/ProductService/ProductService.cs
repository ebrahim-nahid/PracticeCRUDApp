using PracticeCRUDApp.Models;
using PracticeCRUDApp.Models.DTO;
using PracticeCRUDApp.Repository.ProductRepository;

namespace PracticeCRUDApp.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<bool> CreateProduct(PRoductDto product)
        {
            var products = new Product
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ProductType = product.ProductType,
                CreatedOn = DateTime.Now,
                CretedBy = "Admin",
                UpdatedBy="null",
                UpdatedOn=DateTime.UtcNow

            };
            var result = await _productRepository.CreateProduct(products);
            return result;
        }
    }
}
