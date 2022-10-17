using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CarSales.API.Controllers.Model
{
    public class Product
    {
        private static int idGenerator = 0;
        [Required]
        public int Id { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string Brand { get; set; } = string.Empty;

        [Required]
        public string Model { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [Required]
        public int SalePrice { get; set; }

        [Required]
        public bool onSale { get; set; }

        [Required]
        public int engineSize { get; set; }

       


        [JsonIgnore]
        public virtual Category? Category { get; set; }

       


    }
}
