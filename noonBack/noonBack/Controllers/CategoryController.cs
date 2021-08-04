using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SL.CategoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noonBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var result = _categoryService.GetCategory(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet]
        public IActionResult GetAllCategorys()
        {
            var result = _categoryService.GetAllCategory();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpPost]
        public IActionResult InsertCategory(Category category)
        {
            _categoryService.InsertCategory(category);
            return Ok("Data inserted");

        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.UpdateCategory(category);
            return Ok("Updation done");

        }
        [HttpDelete]
        public IActionResult DeleteCategory(int Id)
        {
            _categoryService.DeleteCategory(Id);
            return Ok("Data Deleted");

        }
    }
}
