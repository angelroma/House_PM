using House_PM.Models.Domain;
using House_PM.Models.Repository;
using House_PM.Models.Repository.EntitySQL;
using House_PM.Models.Repository.Infrastucture;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace House_PM.Business
{
    public class PatientService
    {
        IPatient Repo;
        IUnitOfWork unitOfWork;

        public PatientService() : this(new PatientRepo(), new UnitOfWork())
        {

        }

        public PatientService(IPatient repo, UnitOfWork unitOfWork)
        {
            this.Repo = repo;
            this.unitOfWork = unitOfWork;
        }


        public bool Create(Patient entity)
        {
            try
            {
                //Add date to entity column CreatedOn
                entity.CreatedOn = DateTime.Now;
                Repo.Create(entity);
                unitOfWork.Commit();
                return true;
            }
            catch (Exception)
            {
                unitOfWork.RollBack();
                return false;
            }
        }

        public bool Update(Patient entity)
        {
            try
            {
                Repo.Update(entity);
                unitOfWork.Commit();
                return true;
            }
            catch (Exception)
            {
                unitOfWork.RollBack();
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                Repo.Delete(id);
                unitOfWork.Commit();
                return true;
            }
            catch
            {
                unitOfWork.RollBack();
                return false;
            }
        }

        public Patient GetById(int id)
        {
            try
            {
                Patient entity = Repo.GetById(id);
                return Repo.GetById(id);
            }
            catch
            {
                return null;
            }
        }

        public List<Patient> GetAll()
        {
            try
            {
                
                return Repo.GetAll().ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}