using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using House_PM.Models.Domain;
using House_PM.Models.Repository.Infrastucture;

namespace House_PM.Models.Repository.EntitySQL
{
    public class RecipeRepo : IRecipe
    {
        public ApplicationDbContext context;
        public RecipeRepo() => context = ContextFactory.GetContext();

        public void Create(Recipe entity)
        {
            context.Recipes.Add(entity);
        }

        public void Delete(Recipe entity)
        {
            Recipe local = GetById(entity.Id);
            context.Entry<Recipe>(local).State = EntityState.Deleted;
        }

        public IQueryable<Recipe> GetAll(int id)
        {
            //I've included patients to show name in view list
            return context.Recipes.Select(c => c).Include(r => r.Patient);
        }

        public IQueryable<Patient> GetAllList()
        {
            //return context.Patients.Select(c => c).Include(r => r.Patient);
            return context.Patients.Select(c => c);
        }

        public Recipe GetById(int? id)
        {
            return context.Recipes.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Recipe entity)
        {
            Recipe local = GetById(entity.Id);
            if (local != null)
            {
                context.Entry(local).State = EntityState.Detached;
            }
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}