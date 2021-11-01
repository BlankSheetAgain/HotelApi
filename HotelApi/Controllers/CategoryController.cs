using HotelApi.Interfaces;
using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelApi.Controllers
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

        [HttpGet]
        [Route("api/category/getall")]
        public async Task<ActionResult<List<Category>>> GetAll()
        {
            try
            {
                return await _categoryService.GetAll();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }

        [HttpGet("{Id:guid}")]
        public async Task<Category> Get(Guid Id)
        {
            var category = await _categoryService.Get(Id);
            return category;
        }

        [HttpPost]
        [Route("api/category/create")]
        public async Task<ActionResult> Create(Category category)
        {
            try
            {
                await _categoryService.Create(category);
                return StatusCode(201);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("api/category/update")]
        public async Task<ActionResult> Update(Category category)
        {
            try
            {
                await _categoryService.Update(category);
                return StatusCode(201);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("api/category/delete")]
        public async Task<ActionResult> Delete(Guid Id)
        {
            try
            {
                await _categoryService.Delete(Id);
                return StatusCode(201);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }


    }
}
