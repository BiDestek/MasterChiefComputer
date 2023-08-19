using System.Linq.Expressions;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        IOrderDetailService _orderDetailService;
        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet("get")]
        public IActionResult Get(Expression<Func<OrderDetail, bool>> filter)
        {
            Thread.Sleep(1000);
            var result = _orderDetailService.Get(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getasync")]
        public IActionResult GetAsync(Expression<Func<OrderDetail, bool>> filter)
        {
            Thread.Sleep(1000);
            var result = _orderDetailService.GetAsync(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll(Expression<Func<OrderDetail, bool>> filter = null)
        {
            Thread.Sleep(1000);
            var result = _orderDetailService.GetAll(filter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallasync")]
        public IActionResult GetAllAsync(Expression<Func<OrderDetail, bool>> filter = null)
        {
            Thread.Sleep(1000);
            var result = _orderDetailService.GetAllAsync(filter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyorderdetailid")]
        public IActionResult GetByOrderDetailId(int id)
        {
            var result = _orderDetailService.GetByOrderDetailId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyorderdetailidasync")]
        public IActionResult GetByOrderDetailIdAsync(int id)
        {
            var result = _orderDetailService.GetByOrderDetailIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyorderid")]
        public IActionResult GetByOrderId(int id)
        {
            var result = _orderDetailService.GetByOrderId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyorderidasync")]
        public IActionResult GetByOrderIdAsync(int id)
        {
            var result = _orderDetailService.GetByOrderIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getbyproductid")]
        public IActionResult GetByProductId(int id)
        {
            var result = _orderDetailService.GetByProductId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyproductidasync")]
        public IActionResult GetByProductIdAsync(int id)
        {
            var result = _orderDetailService.GetByProductIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyunitprice")]
        public IActionResult GetByUnitPrice(decimal min, decimal max)
        {
            var result = _orderDetailService.GetByUnitPrice(min,max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyunitpriceasync")]
        public IActionResult GetByUnitPriceAsync(decimal min, decimal max)
        {
            var result = _orderDetailService.GetByUnitPriceAsync(min, max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(OrderDetail orderDetail)
        {
            var result = _orderDetailService.Add(orderDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addasync")]
        public IActionResult AddAsync(OrderDetail orderDetail)
        {
            var result = _orderDetailService.AddAsync(orderDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(OrderDetail orderDetail)
        {
            var result = _orderDetailService.Delete(orderDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteasync")]
        public IActionResult DeleteAsync(OrderDetail orderDetail)
        {
            var result = _orderDetailService.DeleteAsync(orderDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(OrderDetail orderDetail)
        {
            var result = _orderDetailService.Update(orderDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updateasync")]
        public IActionResult UpdateAsync(OrderDetail orderDetail)
        {
            var result = _orderDetailService.UpdateAsync(orderDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("transactionaloperation")]
        public IActionResult TransactionalOperation(OrderDetail orderDetail)
        {
            var result = _orderDetailService.TransactionalOperation(orderDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
