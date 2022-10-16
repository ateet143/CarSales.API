using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace CarSales.API.Model
{
    public class ProductQueryParameters : QueryParameters
    {
        // ? is to when the user leave the field empty it will null value, used for filtering method GetAllProduct
        public decimal? MinSalePrice { get; set; }
        public decimal? MaxSalePrice { get; set; }

        public decimal? MaxYear { get; set; }
        public decimal? MinYear { get; set; }
      
        public decimal? MaxEngineSize { get; set; }
        public decimal? MinEngineSize { get; set; }

        public string BrandName { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;

        [FromQuery(Name = "Filter any word")]
        public string SearchTerm { get; set; } = string.Empty;

    }
}
