using Supermarket.Infrastructure;
using Supermarket.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Services
{
    public interface IGoodCategoryService : IService
    {
        void Add(AddGoodCategoryDto dto);
        FindGoodCategoryByIdDto? FindById(int id);
    }
}
