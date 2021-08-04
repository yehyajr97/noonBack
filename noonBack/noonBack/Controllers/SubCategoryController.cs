using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SL.SubCategoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noonBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        [HttpGet("{id}")]
        public IActionResult GetSubCategory(int id)
        {
            var result = _subCategoryService.GetSubCategory(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet]
        public IActionResult GetAllSubCategorys()
        {
            var result = _subCategoryService.GetAllSubCategory();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpPost]
        public IActionResult InsertSubCategory(SubCategory subCategory)
        {
            _subCategoryService.InsertSubCategory(subCategory);
            return Ok("Data inserted");

        }
        [HttpPut]
        public IActionResult UpdateSubCategory(SubCategory subCategory)
        {
            _subCategoryService.UpdateSubCategory(subCategory);
            return Ok("Updation done");

        }
        [HttpDelete]
        public IActionResult DeleteSubCategory(int Id)
        {
            _subCategoryService.DeleteSubCategory(Id);
            return Ok("Data Deleted");

        }
    }
}
