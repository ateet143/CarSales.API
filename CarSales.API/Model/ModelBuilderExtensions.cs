﻿using Microsoft.EntityFrameworkCore;

namespace CarSales.API.Controllers.Model
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Brand = "Fast Car" },
                 new Category { Id = 2, Brand = "Speeding Car" },
                 new Category { Id = 3, Brand = "Wrackers" },
                 new Category { Id = 4, Brand = "Two seater" },
                 new Category { Id = 5, Brand = "Four Seater" },
                 new Category { Id = 6, Brand = "Automatic" });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Brand = "Toyota", Model = "Camry", Year = 2011, SalePrice = 27656, onSale = true, engineSize = 2000},
                new Product { Id = 2, CategoryId = 1, Brand = "Ford", Model = "Kuga", Year = 2011, SalePrice = 35000, onSale = true, engineSize = 2000 },
                new Product { Id = 3, CategoryId = 1, Brand = "Mercedes", Model = "E200", Year = 6123, SalePrice = 33000, onSale = true, engineSize = 2000 },
                new Product { Id = 4, CategoryId = 1, Brand = "Hyundai", Model = "Veloster", Year = 6145, SalePrice = 125000, onSale = true, engineSize = 2000 },
                new Product { Id = 5, CategoryId = 1, Brand = "BMW", Model = "340r", Year = 2012, SalePrice = 6000, onSale = true, engineSize = 1000 },
                new Product { Id = 6, CategoryId = 1, Brand = "Hyundai", Model = "Veloster", Year = 2012, SalePrice = 95000, onSale = true, engineSize = 2000 },
                new Product { Id = 7, CategoryId = 1, Brand = "Ford", Model = "Mondeo", Year = 2012, SalePrice = 65000, onSale = true, engineSize = 4000 },
                new Product { Id = 8, CategoryId = 1, Brand = "Toyota", Model = "Corolla", Year = 2013, SalePrice = 65000, onSale = true, engineSize = 3000 },
                new Product { Id = 9, CategoryId = 1, Brand = "Mercedes", Model = "E200", Year = 2014, SalePrice = 17000, onSale = true, engineSize = 2000 },
                new Product { Id = 10, CategoryId = 2, Brand = "BMW", Model = "330i", Year = 2015, SalePrice = 9900, onSale = true, engineSize = 1600 },
                new Product { Id = 11, CategoryId = 2, Brand = "Hyundai", Model = "Getz", Year = 2016, SalePrice = 10, onSale = false, engineSize = 1800 },
                new Product { Id = 12, CategoryId = 2, Brand = "Toyota", Model = "Land", Year = 2017, SalePrice = 6800, onSale = true, engineSize = 1200 },
                new Product { Id = 13, CategoryId = 2, Brand = "BMW", Model = "M series", Year = 2018, SalePrice = 125000, onSale = true, engineSize = 2400 },
                new Product { Id = 14, CategoryId = 2, Brand = "Mercedes", Model = "D150", Year = 2019, SalePrice = 550, onSale = true, engineSize = 2000 },
                new Product { Id = 15, CategoryId = 2, Brand = "Hyundai", Model = "Veloster", Year = 2022, SalePrice = 22000, onSale = false, engineSize = 1000 },
                new Product { Id = 16, CategoryId = 2, Brand = "BMW", Model = "7 series", Year = 2011, SalePrice = 95000, onSale = true, engineSize = 2000 },
                new Product { Id = 17, CategoryId = 2, Brand = "Tata", Model = "Gulli", Year = 2012, SalePrice = 1700, onSale = true, engineSize = 2000 },
                new Product { Id = 18, CategoryId = 3, Brand = "Hyundai", Model = "Leong", Year = 2013, SalePrice = 28000, onSale = true, engineSize = 2600 },
                new Product { Id = 19, CategoryId = 3, Brand = "Tata", Model = "125", Year = 2014, SalePrice = 28000, onSale = true, engineSize = 2000 },
                new Product { Id = 20, CategoryId = 3, Brand = "BMW", Model = "6 series", Year = 2015, SalePrice = 28000, onSale = false, engineSize = 1000 },
                new Product { Id = 21, CategoryId = 3, Brand = "Tata", Model = "Furs", Year = 2016, SalePrice = 28000, onSale = false, engineSize = 2000 },
                new Product { Id = 22, CategoryId = 3, Brand = "Mercedes", Model = "B series", Year = 2018, SalePrice = 28000, onSale = true, engineSize = 2700 },
                new Product { Id = 23, CategoryId = 3, Brand = "Toyota", Model = "Prad0", Year = 2019, SalePrice = 28000, onSale = true, engineSize = 2800 },
                new Product { Id = 24, CategoryId = 4, Brand = "BMW", Model = "330i", Year = 2020, SalePrice = 24000, onSale = true, engineSize = 2900 },
                new Product { Id = 25, CategoryId = 5, Brand = "Ford", Model = "selbi", Year = 2021, SalePrice = 35000, onSale = true, engineSize = 3000 },
                new Product { Id = 26, CategoryId = 5, Brand = "Ford", Model = "Falcon", Year = 1999, SalePrice = 12400, onSale = true, engineSize = 2000 },
                new Product { Id = 27, CategoryId = 5, Brand = "Tata", Model = "ES", Year = 2011, SalePrice = 13999, onSale = true, engineSize = 2000 },
                new Product { Id = 28, CategoryId = 5, Brand = "Hyundai", Model = "Veloster", Year = 2012, SalePrice = 12455, onSale = true, engineSize = 3000 },
                new Product { Id = 29, CategoryId = 5, Brand = "BMW", Model = "330", Year = 2013, SalePrice = 99999, onSale = true, engineSize = 3000 },
                new Product { Id = 30, CategoryId = 5, Brand = "Ford", Model = "Kuga", Year = 2014, SalePrice = 12555, onSale = true, engineSize = 2000 },
                new Product { Id = 31, CategoryId = 5, Brand = "Ford", Model = "Mondeo", Year = 2015, SalePrice = 12555, onSale = true, engineSize = 3000 },
                new Product { Id = 32, CategoryId = 5, Brand = "Ford", Model = "Mondeo", Year = 2016, SalePrice = 102222, onSale = true, engineSize = 2000 },
                new Product { Id = 33, CategoryId = 5, Brand = "Toyota", Model = "Camry", Year = 2018, SalePrice = 12555, onSale = true, engineSize = 2000 });
        }
    }
}
