using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using House_PM.Models.Domain;
using House_PM.Models.Repository.Infrastucture;

namespace House_PM.Models.Repository.EntitySQL
{
    public class VitalRepo : IVital
    {
        public ApplicationDbContext context;
        public VitalRepo() => context = ContextFactory.GetContext();

        public void Create(Vital vital)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Vital> GetAll()
        {
            throw new NotImplementedException();
        }

        public Vital GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Vital vital)
        {
            throw new NotImplementedException();
        }
    }
}