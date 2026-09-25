using System.ComponentModel.DataAnnotations;

namespace PracticeCRUDApp.Models
{
    public class BaseEntity <T>
    {
        [Required]
        public T Id { get; set; }
        public string? CretedBy { get; set; }
        public string? UpdatedBy { get; set; } = "test";
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
