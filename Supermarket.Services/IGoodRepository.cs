using Supermarket.Entities;
using Supermarket.Infrastructure;
using Supermarket.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Services
{
    public interface IGoodRepository : IRepository
    {
        void Add(Good good);
        FindGoodByIdDto? FindById(int id);
    }
}
