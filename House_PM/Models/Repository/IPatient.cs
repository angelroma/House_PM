using House_PM.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_PM.Models.Repository
{
    public interface IPatient
    {
        void Create(Patient patient);
        void Update(Patient patient);
        void Delete(int id);
        Patient GetById(int id);
        IQueryable<Patient> GetAll();
    }
}
