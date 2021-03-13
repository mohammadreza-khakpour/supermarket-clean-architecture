using Supermarket.Infrastructure;
using Supermarket.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Services
{
    public interface IGoodService : IService
    {
        void Add(AddGoodDto dto);
        FindGoodByIdDto? FindById(int id);
    }
}
