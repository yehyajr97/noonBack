using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using SL.FileService;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using SL.ProductService;

namespace noonBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        #region Property  
        private readonly IProductImagesService _fileService;
        private readonly IProductService _productService;

        #endregion

        #region Constructor  
        public ProductImagesController(IProductImagesService fileService, IProductService productService )
        {
            _fileService = fileService;
            _productService = productService;
        }
        #endregion

        #region Upload  
        [HttpPost]
       
        
        public async Task<IActionResult> Upload()
        {
            try
            {
                var formCollection = await Request.ReadFormAsync();
                var file = formCollection.Files.First();
                //file = Request.Form.Files[0];
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                Product  Product=  _productService.GetAllProducts().OrderByDescending(x => x.Id).FirstOrDefault();
                    ProductImages images = new ProductImages();
                    images.ImagePath = dbPath;
                    images.ProductId = Product.Id;
                    InsertProductImage(images);
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
        #endregion

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var image = System.IO.File.OpenRead("Resources/Images/01.jpg");
        //    return File(image, "image/jpeg");
        //}

        [HttpPost]
        [Route("image")]
        public IActionResult InsertProductImage(ProductImages productImages )
        {
           _fileService.InsertProductImage(productImages);
            return Ok("data insarted");
        }

        [HttpGet]
        [Route("getById /{id}")]
        public IActionResult GetByProductId(int  id)
        {
            return Ok( _fileService.GetAll().Where(c => c.ProductId == id).Take(3));

            //var image = System.IO.File.OpenRead("Resources/Images/01.jpg");
            //return File(image, "image/jpeg");
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(_fileService.GetAll());
        }




        //#region Download File  
        //[HttpGet(nameof(Download))]
        //public IActionResult Download([Required] string subDirectory)
        //{

        //    try
        //    {
        //        var (fileType, archiveData, archiveName) = _fileService.DownloadFiles(subDirectory);

        //        return File(archiveData, fileType, archiveName);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }

        //}
        //#endregion
    }
}
