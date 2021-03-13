using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Infrastructure
{
    public interface IUnitOfWork
    {
        void Complete();
    }
}
