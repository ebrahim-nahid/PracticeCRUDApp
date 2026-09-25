using PracticeCRUDApp.Models;
using System.ComponentModel.DataAnnotations;

namespace PracticeCRUDApp.Models.DTO
{
    public class PRoductDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int Price { get; set; }
        [Required]
        public ProductType ProductType { get; set; }

    }
}
