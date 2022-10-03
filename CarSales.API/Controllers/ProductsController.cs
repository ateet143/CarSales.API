using CarSales.API.Controllers.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO.Pipes;
using Microsoft.EntityFrameworkCore;
using CarSales.API.Model;
using System.Runtime.InteropServices;

namespace CarSales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProducts([FromQuery] ProductQueryParameters queryParameters)
        {
           IQueryable<Product> products = _context.Products;
           if(queryParameters.MinSalePrice != null)
            {
                products = products.Where(p => p.SalePrice >= queryParameters.MinSalePrice.Value);
            }

            if (queryParameters.MaxSalePrice != null)
            {
                products = products.Where(p => p.SalePrice <= queryParameters.MaxSalePrice.Value);
            }

            if (queryParameters.MinEngineSize != null)
            {
                products = products.Where(p => p.engineSize >= queryParameters.MinEngineSize.Value);
            }

            if (queryParameters.MaxEngineSize != null)
            {
                products = products.Where(p => p.engineSize <= queryParameters.MaxEngineSize.Value);
            }

            if (queryParameters.MinYear != null)
            {
                products = products.Where(p => p.Year >= queryParameters.MinYear.Value);
            }

            if (queryParameters.MaxYear != null)
            {
                products = products.Where(p => p.Year <= queryParameters.MaxYear.Value);
            }

            if (!string.IsNullOrEmpty(queryParameters.BrandName))
            {
                products = products.Where(
                    p => p.Brand.ToLower().Contains(
                        queryParameters.BrandName.ToLower()));
            }

            if (!string.IsNullOrEmpty(queryParameters.ModelName))
            {
                products = products.Where(
                    p => p.Model.ToLower().Contains(
                        queryParameters.ModelName.ToLower()));
            }

           
            if (queryParameters.OnSale)
            {
                products = products.Where(p => p.onSale);
            }

            if (!queryParameters.OnSale)
            {
                products = products.Where(p => !p.onSale);
            }


            if (!string.IsNullOrEmpty(queryParameters.SearchTerm))
            {
                products = products.Where( p => p.Brand.ToLower().Contains(queryParameters.SearchTerm.ToLower())  || 
                p.Model.ToLower().Contains(queryParameters.SearchTerm.ToLower()));
            }

            return Ok(await products.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
           
            if(product == null)
            {
                return NotFound();
            }
            
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetProduct",new { id = product.Id}, product);
        }

        [HttpPut("id")]
        public async Task<ActionResult<Product>> PutProduct(int id , Product product)
        {
            if(id != product.Id)
            {
                return BadRequest();
            }
            _context.Entry(product).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // just like limit in sql 
                if (!_context.Products.Any(p => p.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            // to show the product in the postman or swagger after the product is updated.
            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
             {
                //this will be 404 response
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }

        [HttpPost("Delete")] 
        public async Task<ActionResult> DeleteMultiple([FromQuery(Name ="CAR ID")] int[] ids)
        {
            var products = new List<Product>();
            foreach (var id in ids)
            {
                var product = await _context.Products.FindAsync(id);
                if(product == null)
                {
                    return NotFound();
                }
                products.Add(product);
            }
            _context.Products.RemoveRange(products);
            await _context.SaveChangesAsync();
            return Ok(products);
        }
    }
}
