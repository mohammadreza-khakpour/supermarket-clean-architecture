using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Services.DTOs
{
    public class FindGoodByIdDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; }

    }
}
