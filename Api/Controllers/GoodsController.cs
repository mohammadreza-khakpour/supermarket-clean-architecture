using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket.Services;
using Supermarket.Services.DTOs;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/Goods")]
    public class GoodsController : Controller
    {
        private readonly IGoodService _service;
        public GoodsController(IGoodService service)
        {
            _service = service;
        }

        [HttpPost]
        public void Add([Required][FromBody] AddGoodDto dto)
        {

            _service.Add(dto);
        }

        [HttpGet("{id}")]
        public FindGoodByIdDto FindOne(int id)
        {
            return _service.FindById(id);

        }

    }
}