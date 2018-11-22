using House_PM.Business;
using House_PM.Models;
using House_PM.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace House_PM_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PatientServiceWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PatientServiceWCF.svc or PatientServiceWCF.svc.cs at the Solution Explorer and start debugging.
    public class PatientServiceWCF : IPatientServiceWCF
    {

        readonly PatientService service;

        //Dependency injection
        public PatientServiceWCF() : this(new PatientService()) { }
        public PatientServiceWCF(PatientService service) => this.service = service;

        //Methods
        public PatientWCF GetById(int id)
        {
            //Patient entity = db.Patients.Find(id);
            Patient entity = service.GetById(id);

            PatientWCF patientWCF = new PatientWCF()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                CreatedOn = entity.CreatedOn,
                Phone = entity.Phone
            };
            return patientWCF;
        }

        public List<PatientWCF> GetAll()
        {
            List<Patient> listPatients = service.GetAll();
            List<PatientWCF> patientWCFList = new List<PatientWCF>();
            foreach (var item in listPatients)
            {
                PatientWCF entity = new PatientWCF
                {
                    Id = item.Id,
                    CreatedOn = item.CreatedOn,
                    Email = item.Email,
                    Name = item.Name
                };

                patientWCFList.Add(entity);
            }
            return patientWCFList;
        }

        public string Create(PatientWCF entity)
        {
            Patient local = new Patient
            {
                Name = entity.Name,
                Phone = entity.Phone,
                Email = entity.Email,
                CreatedOn = DateTime.Now
            };

            service.Create(local);

            return "Object created";
        }

        public string Delete(int id)
        {
            Patient entity = service.GetById(id);
            service.Delete(entity.Id);
            return "Deleted :)";
        }

        public string Update(PatientWCF entity)
        {
            //Probably this code won't work
            Patient local = new Patient()
            {
                Id = entity.Id,
                Name = entity.Name,
                Phone = entity.Phone,
                Email = entity.Email,
                CreatedOn = entity.CreatedOn
            };
            service.Update(local);
            return "Updated";
        }
    }
}
