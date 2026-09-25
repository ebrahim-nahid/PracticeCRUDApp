using PracticeCRUDApp.Models;

namespace PracticeCRUDApp.Repository.ProductRepository
{
    public interface IProductRepository
    {
        Task<bool>CreateProduct(Product product);
    }
}
