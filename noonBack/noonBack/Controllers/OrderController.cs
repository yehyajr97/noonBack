using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace noonBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var result = _orderService.GetOrder(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var result = _orderService.GetAllOrders();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");

        }
        [HttpPost]
        public IActionResult InsertOrder(Order order)
        {
            _orderService.InsertOrder(order);
            return Ok("Data inserted");

        }
        [HttpPut]
        public IActionResult UpdateOrder(Order order)
        {
            _orderService.UpdateOrder(order);
            return Ok("Updation done");

        }
        [HttpDelete]
        public IActionResult DeleteOrder(int Id)
        {
            _orderService.DeleteOrder(Id);
            return Ok("Data Deleted");

        }
    }
}
