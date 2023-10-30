using DataAccess.Repository.OrderRepository;
using DataAccess.Repository.StatisticRepository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EstoreAPI.Controllers.StatisticalController
{
    [Route("api/[controller]")]
    [ApiController]

    public class StatisticalController : Controller
    {
        private IStatisticRepository repository = new StatisticRepository();
        private  IOrderRepository orepository = new OrderRepository();


        [HttpGet]
        public IActionResult Statistical([FromQuery] DateTime startDate, DateTime endDate)
        {
            if (ModelState.IsValid)
            {
             
                var statistical = repository.GetStatisticalByDate(startDate, endDate);
                if (statistical != null)
                {
                    return Ok(statistical);
                }
                else
                {
                    return BadRequest();
                }
            }
            return NoContent();
        }

    }
}
