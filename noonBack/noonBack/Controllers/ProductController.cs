using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SL.CategoryService;
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
        [Route("Category/{CategoryId}")]
        public IActionResult GetProductsByCategory(int CategoryId)
        {
            var result = _productService.GetAllProducts().Where(c => c.CategoryId == CategoryId).ToList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }
        [HttpGet]
        [Route("brand/{BrandId}")]
        public IActionResult GetProductByBrandId(int brandId)
        {
            var result = _productService.GetAllProducts().Where(c => c.BrandId == brandId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("no records found");

        }
        [HttpGet]
        [Route("SubCategory/{SubCategoryId}")]
        public IActionResult GetProductBySubCategoryId(int SubCategoryId)
        {
            var result = _productService.GetAllProducts().Where(c => c.BrandId == SubCategoryId);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("no records found");

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
