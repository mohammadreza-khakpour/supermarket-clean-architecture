using Supermarket.Entities;
using Supermarket.Services;
using Supermarket.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supermarket.Persistence.EF
{
    public class EFGoodRepository : IGoodRepository
    {
        private EFDataContext _dBCOntext;
        public EFGoodRepository(EFDataContext dBCOntext)
        {
            _dBCOntext = dBCOntext;
        }
        public void Add(Good good)
        {
            _dBCOntext.Goods.Add(good);
        }

        public FindGoodByIdDto? FindById(int id)
        {
            return _dBCOntext.Goods.Where(_ => _.Id == id).Select(_ => new FindGoodByIdDto
            {
                Id = _.Id,
                Title = _.Title,
                CategoryId = _.CategoryId

            }).FirstOrDefault();
        }
    }
}
