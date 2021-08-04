using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SL.BrandService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noonBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("{id}")]
        public IActionResult GetBrand(int id)
        {
            var result = _brandService.GetBrand(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet]
        public IActionResult GetAllBrands()
        {
            var result = _brandService.GetAllBrands();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpPost]
        public IActionResult InsertBrand(Brand brand)
        {
            _brandService.InsertBrand(brand);
            return Ok("Data inserted");

        }
        [HttpPut]
        public IActionResult UpdateBrand(Brand brand)
        {
            _brandService.UpdateBrand(brand);
            return Ok("Updation done");

        }
        [HttpDelete]
        public IActionResult DeleteBrand(int Id)
        {
            _brandService.DeleteBrand(Id);
            return Ok("Data Deleted");

        }
    }
}
