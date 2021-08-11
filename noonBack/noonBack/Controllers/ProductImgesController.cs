using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SL.ProductImagesService;
using System;
using System.Web;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace noonBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImagesService _productImagesService;
        private readonly IHostingEnvironment _hostingEnvironment;


        public ProductImagesController(IProductImagesService productImagesService, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _productImagesService = productImagesService;
        }

        [HttpGet("{id}")]
        public IActionResult GetProductImages(int id)
        {
            var result = _productImagesService.GetProductImages(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet]
        public IActionResult GetAllProductImages()
        {
            var result = _productImagesService.GetAllProductImages();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpPost]
        public async Task <IActionResult> InsertProductImages([FromForm]ProductImages productImages)
        {
            var a = _hostingEnvironment.WebRootPath;
            var fileName = Path.GetFileName(productImages.Image.FileName);
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images", fileName);
            using (var fileSteam = new FileStream(filePath, FileMode.Create))
            {
                await productImages.Image.CopyToAsync(fileSteam);
            }
            productImages.ImagePath = filePath;
            return Ok("Data inserted");

        }
        [HttpPut]
        public IActionResult UpdateProductImages(ProductImages productImages)
        {
            _productImagesService.UpdateProductImages(productImages);
            return Ok("Updation done");

        }
        [HttpDelete]
        public IActionResult DeleteProductImages(int Id)
        {
            _productImagesService.DeleteProductImages(Id);
            return Ok("Data Deleted");

        }
    }
}
