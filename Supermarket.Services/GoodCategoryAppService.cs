using Supermarket.Entities;
using Supermarket.Infrastructure;
using Supermarket.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Services
{
    public class GoodCategoryAppService : IGoodCategoryService
    {
        private IGoodCategoryRepository _goodCategoryRepository;
        private IUnitOfWork _unitOfWork;
        public GoodCategoryAppService(IGoodCategoryRepository goodCategoryRepository, IUnitOfWork unitOfWork)
        {
            _goodCategoryRepository = goodCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(AddGoodCategoryDto dto)
        {
            var goodCategory = new GoodCategory
            {
                Title = dto.Title,
            };

            _goodCategoryRepository.Add(goodCategory);

            _unitOfWork.Complete();
        }

        public FindGoodCategoryByIdDto FindById(int id)
        {
            return _goodCategoryRepository.FindById(id);
        }
    }
}
