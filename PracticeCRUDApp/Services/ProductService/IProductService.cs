using PracticeCRUDApp.Models.DTO;

namespace PracticeCRUDApp.Services.ProductService
{
    public interface IProductService
    {
        Task<bool>CreateProduct(PRoductDto product);
    }
}
