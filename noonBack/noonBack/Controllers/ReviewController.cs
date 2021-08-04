using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SL.ReviewService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noonBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet("{id}")]
        public IActionResult GetReview(int id)
        {
            var result = _reviewService.GetReview(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet]
        public IActionResult GetAllReviews()
        {
            var result = _reviewService.GetAllReviews();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpPost]
        public IActionResult InsertReview(Review review)
        {
            _reviewService.InsertReview(review);
            return Ok("Data inserted");

        }
        [HttpPut]
        public IActionResult UpdateReview(Review review)
        {
            _reviewService.UpdateReview(review);
            return Ok("Updation done");

        }
        [HttpDelete]
        public IActionResult DeleteReview(int Id)
        {
            _reviewService.DeleteReview(Id);
            return Ok("Data Deleted");

        }
    }
}
