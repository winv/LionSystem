using LionServer.Domain.Interfaces;
using LionServer.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace LionServer.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LionContext _context;

        public UnitOfWork(LionContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
