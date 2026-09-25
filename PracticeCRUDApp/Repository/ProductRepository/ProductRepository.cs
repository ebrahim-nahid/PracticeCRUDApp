using PracticeCRUDApp.Models;

namespace PracticeCRUDApp.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateProduct(Product product)
        {
             await _context.Products.AddAsync(product);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
