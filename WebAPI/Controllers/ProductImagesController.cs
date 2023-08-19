using System.Linq.Expressions;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        IProductImageService _productImageService;
        public ProductImagesController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet("get")]
        public IActionResult Get(Expression<Func<ProductImage, bool>> filter)
        {
            Thread.Sleep(1000);
            var result = _productImageService.Get(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getasync")]
        public IActionResult GetAsync(Expression<Func<ProductImage, bool>> filter)
        {
            Thread.Sleep(1000);
            var result = _productImageService.GetAsync(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll(Expression<Func<ProductImage, bool>> filter = null)
        {
            Thread.Sleep(1000);
            var result = _productImageService.GetAll(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallasync")]
        public IActionResult GetAllAsync(Expression<Func<ProductImage, bool>> filter = null)
        {
            Thread.Sleep(1000);
            var result = _productImageService.GetAllAsync(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById([FromForm(Name = ("Id"))] int id)
        {
            Thread.Sleep(1000);
            var result = _productImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyidasync")]
        public IActionResult GetByIdAsync([FromForm(Name = ("Id"))] int id)
        {
            Thread.Sleep(1000);
            var result = _productImageService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbyproductid")]
        public IActionResult GetAllByProductId(int productId)
        {
            Thread.Sleep(1000);
            var result = _productImageService.GetAllByProductId(productId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbyproductidasync")]
        public IActionResult GetAllByProductIdAsync(int productId)
        {
            Thread.Sleep(1000);
            var result = _productImageService.GetAllByProductIdAsync(productId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] ProductImage productImages)
        {
            var result = _productImageService.Add(file, productImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addasync")]
        public IActionResult AddAsync([FromForm(Name = ("Image"))] IFormFile file, [FromForm] ProductImage productImages)
        {
            var result = _productImageService.AddAsync(file, productImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int id)
        {
            var productImages = _productImageService.Get(p => p.ProductId == id).Data;
            var result = _productImageService.Update(file, productImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updateasync")]
        public IActionResult UpdateAsync([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int id)
        {
            var productImages = _productImageService.Get(p => p.ProductId == id).Data;
            var result = _productImageService.UpdateAsync(file, productImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int id)
        {

            var productImage = _productImageService.Get(p => p.ProductId == id).Data;
            var result = _productImageService.Delete(productImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteasync")]
        public IActionResult DeleteAsync([FromForm(Name = ("Id"))] int id)
        {

            var productImage = _productImageService.Get(p => p.ProductId == id).Data;
            var result = _productImageService.DeleteAsync(productImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("transactionaloperation")]
        public IActionResult TransactionalOperation([FromForm(Name = ("Image"))] IFormFile file, [FromForm] ProductImage productImages)
        {
            var result = _productImageService.TransactionalOperation(file, productImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
