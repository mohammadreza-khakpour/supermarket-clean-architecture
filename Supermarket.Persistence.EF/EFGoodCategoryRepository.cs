using Supermarket.Entities;
using Supermarket.Services;
using Supermarket.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supermarket.Persistence.EF
{
    public class EFGoodCategoryRepository : IGoodCategoryRepository
    {
        private EFDataContext _dBCOntext;
        public EFGoodCategoryRepository(EFDataContext dBCOntext)
        {
            _dBCOntext = dBCOntext;
        }

        public void Add(GoodCategory goodCategory)
        {
            _dBCOntext.GoodCategories.Add(goodCategory);
        }

        public FindGoodCategoryByIdDto? FindById(int id)
        {
            return _dBCOntext.GoodCategories.Where(_ => _.Id == id).Select(_ => new FindGoodCategoryByIdDto
            {
                Id = _.Id,
                Title = _.Title,

            }).FirstOrDefault();
        }
    }
}
