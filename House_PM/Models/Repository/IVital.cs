using House_PM.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_PM.Models.Repository
{
    public interface IVital
    {
        void Create(Vital recipe);
        void Update(Vital recipe);
        void Delete(Vital recipe);
        Vital GetById(int? id);
        IQueryable<Vital> GetAll(int id);
        IQueryable<Patient> GetAllList();
    }
}
