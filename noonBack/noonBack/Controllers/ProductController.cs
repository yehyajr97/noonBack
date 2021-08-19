using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SL.BrandService;
using SL.CategoryService;
using SL.ProductService;
using SL.SubCategoryService;
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
        private readonly ISubCategoryService _subCategoryService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;

        public ProductController(IProductService productService, ISubCategoryService subCategoryService, ICategoryService categoryService,IBrandService brandService)
        {
            _productService = productService;
            _subCategoryService = subCategoryService;
            _brandService = brandService;
            _categoryService = categoryService;
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
            var result = _productService.GetAllProducts().Where(c=>c.Name.ToLower()==name.ToLower()).ToList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet]
        [Route("Seller/{id}")]
        public IActionResult GetProductsSellerId(string sellerId)
        {
            var result = _productService.GetAllProducts().Where(c => c.SellerId == sellerId).ToList();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found for this seller");

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
        [Route("SubCategoryName/{SubCategoryName}")]
        public IActionResult GetProductBySubCategoryName(string SubCategoryName)
        {
            var subCategoryId = _subCategoryService.GetAllSubCategory().FirstOrDefault(c => c.SubcatName.ToLower() == SubCategoryName);
            if (subCategoryId != null)
            {
                var result = _productService.GetAllProducts().Where(c => c.SubCategoryId == subCategoryId.Id).ToList();
                if (result is not null)
                {
                    return Ok(result);
                }
                return BadRequest("no records found");
            }
            return BadRequest("No Products");
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
        [Route("BrandName/{BrandName}")]
        public IActionResult GetProductByBrandName(string BrandName)
        {
            var BrandId = _brandService.GetAllBrands().FirstOrDefault(c => c.Name.ToLower() == BrandName.ToLower());
            if (BrandId != null)
            {
                var result = _productService.GetAllProducts().Where(c => c.SubCategoryId == BrandId.Id).ToList();
                if (result is not null)
                {
                    return Ok(result);
                }
                return BadRequest("no records found");
            }
            return BadRequest("No Products");
        }


        [HttpGet]
        [Route("CategoryName/{CategoryName}")]
        public IActionResult GetProductByCategoryName(string CategoryName)
        {
            var CategoryId = _categoryService.GetAllCategory().FirstOrDefault(c => c.Name.ToLower() == CategoryName.ToLower());
            if (CategoryId != null)
            {
                var result = _productService.GetAllProducts().Where(c => c.SubCategoryId == CategoryId.Id).ToList();
                if (result is not null)
                {
                    return Ok(result);
                }
                return BadRequest("no records found");
            }
            return BadRequest("No Products");
        }
        [HttpGet]
        [Route("SubCategory/{SubCategoryId}")]
        public IActionResult GetProductBySubCategoryId(int SubCategoryId)
        {
            var result = _productService.GetAllProducts().Where(c => c.SubCategoryId == SubCategoryId);
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
