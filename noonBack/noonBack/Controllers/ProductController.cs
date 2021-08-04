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
