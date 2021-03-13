using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Entities
{
    public class GoodCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Good> Goods { get; set; }
    }
}
