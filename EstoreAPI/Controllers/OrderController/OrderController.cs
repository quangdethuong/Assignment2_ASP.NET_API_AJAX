using AutoMapper;
using BusinessObject;
using DataAccess.Repository.OrderRepository;
using EstoreAPI.DTO.OrdersDTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace EstoreAPI.Controllers.OrderController
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderController(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetOrder()
        {
            var p = _orderRepository.GetOrders();
            var pDTO = _mapper.Map<IEnumerable<OrderDTO>>(p);
            return Ok(pDTO);
        }

        //[HttpGet("GetOrdersByMemberId/{id}")]
        //public ActionResult FindOrderById(string id)
        //{
        //    var p = _orderRepository.GetOrderByMemberId(id);
        //    var pDTO = _mapper.Map<OrderDTO>(p);
        //    return Ok(pDTO);
        //}

        [HttpGet("GetOrdersByMemberId/{id}")]
        public ActionResult<IEnumerable<Order>> GetOrdersByMemberId(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var result = _orderRepository.GetOrderByMemberId(id);
            return result;
        }


        [HttpPost]
        public ActionResult SaveOrder(OrderDTO o)
        {
            var order = _mapper.Map<Order>(o);
            _orderRepository.AddOrder(order);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateOrder(OrderDTO o)
        {
            var order = _mapper.Map<Order>(o);
            _orderRepository.UpdateOrder(order);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var order = _orderRepository.GetOrder(id);
            if (order == null)
                return NotFound();
            _orderRepository.DeleteOrder(id);
            return NoContent();
        }

        [HttpGet("GetOrdersStatistic")]
        public ActionResult<List<Order>> GetOrdersStatistic(DateTime startDate, DateTime endDate)
        {
            if (!checkStatisticDate(startDate, endDate)) return BadRequest("Date Time input invalid!");

            var orders = _orderRepository.GetStatisticalByDate(startDate, endDate);
            return Ok(orders);
        }

        private bool checkStatisticDate(DateTime startDate, DateTime endDate)
        {
            var result = DateTime.Compare(startDate, endDate);
            if (result == -1)
            {
                return true;
            }
            else if (result == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
