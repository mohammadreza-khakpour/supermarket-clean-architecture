using Supermarket.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Services.DTOs
{
    public class FindGoodCategoryByIdDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Good> Goods { get; set; }
    }
}
