// Models/Disc.cs
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class Discount
    {

        public int Id { get; set; }

        [Required]
        public decimal BeforeDiscountPrice { get; set; }

        [Required]
        public int DiscountPercentage { get; set; }

        public decimal AfterDiscountPrice => BeforeDiscountPrice - BeforeDiscountPrice * DiscountPercentage / 100;

        public DateTime Date { get; set; } = DateTime.Now;

    }
}

