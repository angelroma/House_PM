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
        void Create(Vital vital);
        void Update(Vital vital);
        void Delete(int id);
        Vital GetById(int id);
        IQueryable<Vital> GetAll();
    }
}
