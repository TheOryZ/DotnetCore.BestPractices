using AutoMapper;
using DotnetCore.BestPractices.Core.Entites.Concrete;
using DotnetCore.BestPractices.Core.Interfaces.Services;
using DotnetCore.BestPractices.DTO.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CategoryListDto>>(categories));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if(category != null)
                return Ok(_mapper.Map<IEnumerable<CategoryListDto>>(category));
            return NotFound("This category number does not exist");

        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            var category = await _categoryService.AddAsync(_mapper.Map<Category>(categoryAddDto));
            if (category != null)
                return Created("",_mapper.Map<CategoryAddDto>(category));
            return BadRequest("This category could not be added");
        }

        [HttpPut]
        public IActionResult Update(CategoryUpdateDto categoryUpdateDto)
        {
            var category = _categoryService.Update(_mapper.Map<Category>(categoryUpdateDto));
            if(category != null)
                return NoContent();
            return BadRequest("This category could not be updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var category = _categoryService.GetByIdAsync(id).Result;
            _categoryService.Remove(category);
            return NoContent();
        }
    }
}
