using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket.Entities;
using Supermarket.Services;
using Supermarket.Services.DTOs;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/GoodCategories")]
    public class GoodCategoriesController : Controller
    {

        private readonly IGoodCategoryService _service;
        public GoodCategoriesController(IGoodCategoryService service)
        {
            _service = service;
        }

        [HttpPost]
        public void Add([Required][FromBody] AddGoodCategoryDto dto)
        {

            _service.Add(dto);
        }

        [HttpGet("{id}")]
        public FindGoodCategoryByIdDto FindOne(int id)
        {
            return _service.FindById(id);

        }

    }
}