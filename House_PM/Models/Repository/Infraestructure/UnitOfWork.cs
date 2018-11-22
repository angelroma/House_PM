using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace House_PM.Models.Repository.Infrastucture
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext context;

        public UnitOfWork()
        {
            context = ContextFactory.GetContext();
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void RollBack() => throw new NotImplementedException();
    }
}