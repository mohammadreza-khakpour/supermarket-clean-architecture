using Supermarket.Entities;
using Supermarket.Infrastructure;
using Supermarket.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Services
{
    public class GoodAppService : IGoodService
    {
        private IGoodRepository _goodRepository;
        private IUnitOfWork _unitOfWork;
        public GoodAppService(IGoodRepository goodRepository, IUnitOfWork unitOfWork)
        {
            _goodRepository = goodRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(AddGoodDto dto)
        {
            var good = new Good
            {
                Title = dto.Title,
                CategoryId = dto.CategoryId
            };

            _goodRepository.Add(good);

            _unitOfWork.Complete();
        }

        public FindGoodByIdDto FindById(int id)
        {
            return _goodRepository.FindById(id);
        }
    }
}
