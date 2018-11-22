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
        IVital vitalRepo;
        IUnitOfWork unitOfWork;

        public VitalService() : this(new VitalRepo(), new UnitOfWork())
        {

        }

        public VitalService(IVital vitalRepo, UnitOfWork unitOfWork)
        {
            this.vitalRepo = vitalRepo;
            this.unitOfWork = unitOfWork;
        }


        public bool Create(Vital entity)
        {
            try
            {
                //var loggedUserId = HttpContext.Current.User.Identity.GetUserId();
                //entity.Id_Users = loggedUserId;

                vitalRepo.Create(entity);
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
                vitalRepo.Update(entity);
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
                vitalRepo.Delete(id);
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
               return vitalRepo.GetById(id);
            }
            catch
            {
                return null;
            }
        }

        public List<Vital> GetAll()
        {
            try
            {
                return vitalRepo.GetAll().ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}