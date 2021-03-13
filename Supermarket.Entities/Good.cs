using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Entities
{
    public class Good
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; }

        public GoodCategory Category { get; set; }
    }
}
