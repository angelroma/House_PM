using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void Create(Vital entity)
        {
            context.Vitals.Add(entity);
        }

        public void Delete(Vital entity)
        {
            Vital local = GetById(entity.Id);
            context.Entry<Vital>(local).State = EntityState.Deleted;
        }

        public IQueryable<Vital> GetAll(int id)
        {
            //I've included vitals to show name in view list
            return context.Vitals.Select(c => c).Include(r => r.Patient);
        }

        //This method is requiring patiens
        public IQueryable<Patient> GetAllList()
        {
            //return context.Patients.Select(c => c).Include(r => r.Patient);
            return context.Patients.Select(c => c);
        }

        public Vital GetById(int? id)
        {
            return context.Vitals.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Vital entity)
        {
            Vital local = GetById(entity.Id);
            if (local != null)
            {
                context.Entry(local).State = EntityState.Detached;
            }
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}