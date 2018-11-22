using House_PM.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_PM.Models.Repository
{
    public interface IRecipe
    {
        void Create(Recipe recipe);
        void Update(Recipe recipe);
        void Delete(Recipe recipe);
        Recipe GetById(int? id);
        IQueryable<Recipe> GetAll(int id);
        IQueryable<Patient> GetAllList();

    }
}
