using System.ComponentModel.DataAnnotations;

namespace PracticeCRUDApp.Models
{
    public class Product : BaseEntity<int>
    {
        [Required]
       public string Name { get; set; }

        public int Price { get; set; }
        [Required]
        public ProductType ProductType { get; set; }
    }
    public enum ProductType
    {
        Mobile = 0,
        Laptop = 1,
        Tablet = 2
    }
}
