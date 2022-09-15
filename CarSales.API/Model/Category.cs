using System.ComponentModel.DataAnnotations;

namespace CarSales.API.Controllers.Model
{
    public class Category
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; } = string.Empty;
        public virtual List<Product>? Products { get; set; }
       
    }
}
