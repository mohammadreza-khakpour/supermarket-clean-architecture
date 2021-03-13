using Supermarket.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.Persistence.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private EFDataContext _dBContext;
        public EFUnitOfWork(EFDataContext dBContext)
        {
            _dBContext = dBContext;
        }
        public void Complete()
        {
            _dBContext.SaveChanges();
        }
    }
}
