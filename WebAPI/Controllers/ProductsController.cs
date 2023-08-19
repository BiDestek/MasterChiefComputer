using System.Linq.Expressions;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("get")]
        public IActionResult Get(Expression<Func<Product, bool>> filter)
        {
            Thread.Sleep(1000);
            var result = _productService.Get(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getasync")]
        public IActionResult GetAsync(Expression<Func<Product, bool>> filter)
        {
            Thread.Sleep(1000);
            var result = _productService.GetAsync(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll(Expression<Func<Product, bool>> filter = null)
        {
            Thread.Sleep(1000);
            var result = _productService.GetAll(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallasync")]
        public IActionResult GetAllAsync(Expression<Func<Product, bool>> filter = null)
        {
            Thread.Sleep(1000);
            var result = _productService.GetAllAsync(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            Thread.Sleep(1000);
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyidasync")]
        public IActionResult GetByIdAsync(int id)
        {
            Thread.Sleep(1000);
            var result = _productService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbycategoryid")]
        public IActionResult GetAllByCategoryId(int categoryId)
        {
            Thread.Sleep(1000);
            var result = _productService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbycategoryidasync")]
        public IActionResult GetAllByCategoryIdAsync(int categoryId)
        {
            Thread.Sleep(1000);
            var result = _productService.GetAllByCategoryIdAsync(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyunitprice")]
        public IActionResult GetByUnitPrice(decimal min, decimal max)
        {
            Thread.Sleep(1000);
            var result = _productService.GetByUnitPrice(min,max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyunitpriceasync")]
        public IActionResult GetByUnitPriceAsync(decimal min, decimal max)
        {
            Thread.Sleep(1000);
            var result = _productService.GetByUnitPriceAsync(min, max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getproductdetails")]
        public IActionResult GetProductDetails()
        {
            Thread.Sleep(1000);
            var result = _productService.GetProductDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getproductdetailsasync")]
        public IActionResult GetProductDetailsAsync()
        {
            Thread.Sleep(1000);
            var result = _productService.GetProductDetailsAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("addasync")]
        public IActionResult AddAsync(Product product)
        {
            var result = _productService.AddAsync(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteasync")]
        public IActionResult DeleteAsync(Product product)
        {
            var result = _productService.DeleteAsync(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updateasync")]
        public IActionResult UpdateAsync(Product product)
        {
            var result = _productService.UpdateAsync(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("transactionaloperation")]
        public IActionResult TransactionalOperation(Product product)
        {
            var result = _productService.TransactionalOperation(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
