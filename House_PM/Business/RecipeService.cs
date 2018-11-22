using House_PM.Models.Domain;
using House_PM.Models.Repository;
using House_PM.Models.Repository.EntitySQL;
using House_PM.Models.Repository.Infrastucture;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace House_MD.Business
{
    public class RecipeService
    {
        IRecipe Repo;
        IUnitOfWork unitOfWork;

        public RecipeService() : this(new RecipeRepo(), new UnitOfWork())
        {

        }

        public RecipeService(IRecipe repo, UnitOfWork unitOfWork)
        {
            this.Repo = repo;
            this.unitOfWork = unitOfWork;
        }

        public bool Create(Recipe entity)
        {
            try
            {
                //Add current date to column CreatedOn
                entity.CreatedOn = DateTime.Now;
                Repo.Create(entity);
                unitOfWork.Commit();
                return true;
            }
            catch
            {
                unitOfWork.RollBack();
                return false;
            }
        }

        public bool Update(Recipe entity)
        {
            try
            {
                Repo.Update(entity);
                unitOfWork.Commit();
                return true;
            }
            catch
            {
                unitOfWork.RollBack();
                return false;
            }
        }

        public bool Delete(Recipe entity)
        {
            try
            {
                Repo.Delete(entity);
                unitOfWork.Commit();
                return true;
            }
            catch
            {
                unitOfWork.RollBack();
                return false;
            }
        }

        public Recipe GetById(int? id)
        {
            try
            {
                return Repo.GetById(id);
            }
            catch
            {
                return null;
            }
        }

        public List<Recipe> GetAll(int id)
        {
            try
            {
                //return context.Recipe.Select(c => c).Where(c => c.Id_Patient == id);
                return Repo.GetAll(id).Where(c => c.Id_Patient == id).ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<Patient> GetAllList()
        {
            try
            {
                return Repo.GetAllList().ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}