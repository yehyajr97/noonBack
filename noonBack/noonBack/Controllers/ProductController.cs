using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SL.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noonBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var result = _productService.GetProduct(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var result = _productService.GetAllProducts();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet]
        [Route("name/{name}")]
        public IActionResult GetProductsByName(string name)
        {
            var result = _productService.GetAllProducts().Where(c=>c.Name==name).ToList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet]
        [Route("Category/{CategoryName}")]
        public IActionResult GetProductsByCategory(string CategoryName)
        {
            var result = _productService.GetAllProducts().Where(c => c.Category.Name == CategoryName).ToList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        [HttpGet]
        [Route("subCategory/{Category}/{brand}")]
        public IActionResult GetProductsByBrand(string Category, string brand)
        {
            var listByCategory = _productService.GetAllProducts().Where(c => c.Category.Name == Category).ToList();
            var result = listByCategory.Where(c =>c.Category.Brands.FirstOrDefault().Name==brand).ToList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        [HttpGet]
        [Route("subCategory/{Category}/{subCategory}")]
        public IActionResult GetProductsBySubCategory(string Category, string subCategory)
        {
            var listByCategory = _productService.GetAllProducts().Where(c => c.Category.Name == Category).ToList();
            var result = listByCategory.Where(c => c.Category.SubCategories.FirstOrDefault().SubcatName == subCategory).ToList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        [HttpPost]
        public IActionResult InsertProduct(Product product)
        {
            _productService.InsertProduct(product);
            return Ok("Data inserted");

        }
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.UpdateProduct(product);
            return Ok("Updation done");

        }
        [HttpDelete]
        public IActionResult DeleteProduct(int Id)
        {
            _productService.DeleteProduct(Id);
            return Ok("Data Deleted");

        }
    }
}
