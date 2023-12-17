using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EcommerceWeb.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }
    }
}
