using Supermarket.Entities;
using Supermarket.Infrastructure;
using Supermarket.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Services
{
    public interface IGoodCategoryRepository : IRepository
    {
        void Add(GoodCategory goodCategory);
        FindGoodCategoryByIdDto? FindById(int id);
    }
}
