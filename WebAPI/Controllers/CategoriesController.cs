using System.Linq.Expressions;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("get")]
        public IActionResult Get(Expression<Func<Category, bool>> filter)
        {
            Thread.Sleep(1000);
            var result = _categoryService.Get(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getasync")]
        public IActionResult GetAsync(Expression<Func<Category, bool>> filter)
        {
            Thread.Sleep(1000);
            var result = _categoryService.GetAsync(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll(Expression<Func<Category, bool>> filter = null)
        {
            Thread.Sleep(1000);
            var result = _categoryService.GetAll(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallasync")]
        public IActionResult GetAllAsync(Expression<Func<Category, bool>> filter = null)
        {
            Thread.Sleep(1000);
            var result = _categoryService.GetAllAsync(filter);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyidasync")]
        public IActionResult GetByIdAsync(int id)
        {
            var result = _categoryService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addasync")]
        public IActionResult AddAsync(Category category)
        {
            var result = _categoryService.AddAsync(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Category category)
        {
            var result = _categoryService.Delete(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteasync")]
        public IActionResult DeleteAsync(Category category)
        {
            var result = _categoryService.DeleteAsync(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updateasync")]
        public IActionResult UpdateAsync(Category category)
        {
            var result = _categoryService.UpdateAsync(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("transactionaloperation")]
        public IActionResult TransactionalOperation(Category category)
        {
            var result = _categoryService.TransactionalOperation(category);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
