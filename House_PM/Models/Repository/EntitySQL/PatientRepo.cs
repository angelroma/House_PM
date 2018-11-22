using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using House_PM.Models.Domain;
using House_PM.Models.Repository.Infrastucture;

namespace House_PM.Models.Repository.EntitySQL
{
    public class PatientRepo : IPatient
    {
        public ApplicationDbContext context;
        public PatientRepo() => context = ContextFactory.GetContext();

        public void Create(Patient entity)
        {
            context.Patients.Add(entity);
        }

        public void Delete(int id)
        {
            //Find entity to be able to delete it.
            Patient entity = GetById(id);
            //Implement Remove() method to delete in cascade.
            context.Patients.Remove(entity);
        }

        public IQueryable<Patient> GetAll()
        {
            return context.Patients.Select(c => c);
        }

        public Patient GetById(int id)
        {
            return context.Patients.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Patient entity)
        {
            Patient local = GetById(entity.Id);
            if (local != null)
            {
                context.Entry(local).State = EntityState.Detached;
            }
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}