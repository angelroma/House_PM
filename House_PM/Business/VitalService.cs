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
    public class VitalService
    {
        IVital repo;
        IUnitOfWork unitOfWork;

        public VitalService() : this(new VitalRepo(), new UnitOfWork())
        {

        }

        public VitalService(IVital vitalRepo, UnitOfWork unitOfWork)
        {
            this.repo = vitalRepo;
            this.unitOfWork = unitOfWork;
        }


        public bool Create(Vital entity)
        {
            try
            {
                repo.Create(entity);
                unitOfWork.Commit();
                return true;
            }
            catch (Exception)
            {
                unitOfWork.RollBack();
                return false;
            }
        }

        public bool Update(Vital entity)
        {
            try
            {
                repo.Update(entity);
                unitOfWork.Commit();
                return true;
            }
            catch (Exception)
            {
                unitOfWork.RollBack();
                return false;
            }
        }

        public bool Delete(Vital entity)
        {
            try
            {
                repo.Delete(entity);
                unitOfWork.Commit();
                return true;
            }
            catch
            {
                unitOfWork.RollBack();
                return false;
            }
        }

        public Vital GetById(int id)
        {
            try
            {
               return repo.GetById(id);
            }
            catch
            {
                return null;
            }
        }

        public List<Vital> GetAll(int id)
        {
            try
            {
                return repo.GetAll(id).Where(c => c.Id_Patient == id).ToList();
                //return repo.GetAll().ToList();
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
                return repo.GetAllList().ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}