using System.Linq.Expressions;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        ISupplierService _supplierService;
        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet("get")]
        public IActionResult Get(Expression<Func<Supplier, bool>> filter)
        {
            Thread.Sleep(1000);
            var result = _supplierService.Get(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getasync")]
        public IActionResult GetAsync(Expression<Func<Supplier, bool>> filter)
        {
            Thread.Sleep(1000);
            var result = _supplierService.GetAsync(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll(Expression<Func<Supplier, bool>> filter = null)
        {
            Thread.Sleep(1000);
            var result = _supplierService.GetAll(filter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallasync")]
        public IActionResult GetAllAsync(Expression<Func<Supplier, bool>> filter = null)
        {
            Thread.Sleep(1000);
            var result = _supplierService.GetAllAsync(filter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _supplierService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyidasync")]
        public IActionResult GetByIdAsync(int id)
        {
            var result = _supplierService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Supplier supplier)
        {
            var result = _supplierService.Add(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addasync")]
        public IActionResult AddAsync(Supplier supplier)
        {
            var result = _supplierService.AddAsync(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Supplier supplier)
        {
            var result = _supplierService.Delete(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteasync")]
        public IActionResult DeleteAsync(Supplier supplier)
        {
            var result = _supplierService.DeleteAsync(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Supplier supplier)
        {
            var result = _supplierService.Update(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updateasync")]
        public IActionResult UpdateAsync(Supplier supplier)
        {
            var result = _supplierService.UpdateAsync(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("transactionaloperation")]
        public IActionResult TransactionalOperation(Supplier supplier)
        {
            var result = _supplierService.TransactionalOperation(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
