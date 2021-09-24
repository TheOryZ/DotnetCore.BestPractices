using AutoMapper;
using DotnetCore.BestPractices.Core.Entites.Concrete;
using DotnetCore.BestPractices.Core.Interfaces.Services;
using DotnetCore.BestPractices.DTO.Dtos.ProductDtos;
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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductListDto>>(products));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product != null)
                return Ok(_mapper.Map<ProductListDto>(product));
            return NotFound("This product number does not exist");

        }

        [HttpGet("{id}/category")]
        public async Task<IActionResult> GetWithCategoryById(int id)
        {
            var product = await _productService.GetWithCategoryByIdAsync(id);
            return Ok(_mapper.Map<ProductWithCategoryDto>(product));
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductAddDto productAddDto)
        {
            var product = await _productService.AddAsync(_mapper.Map<Product>(productAddDto));
            if (product != null)
                return Created("", _mapper.Map<ProductAddDto>(product));
            return BadRequest("This product could not be added");
        }

        [HttpPut]
        public IActionResult Update(ProductUpdateDto productUpdateDto)
        {
            var product = _productService.Update(_mapper.Map<Product>(productUpdateDto));
            if (product != null)
                return NoContent();
            return BadRequest("This product could not be updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var product = _productService.GetByIdAsync(id).Result;
            _productService.Remove(product);
            return NoContent();
        }
    }
}
