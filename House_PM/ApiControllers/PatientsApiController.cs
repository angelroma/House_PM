using House_PM.Business;
using House_PM.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace House_PM.ApiControllers
{
    [RoutePrefix("api")]
    public class PatientsApiController : ApiController
    {
        PatientService service;

        //Dependency injection
        public PatientsApiController() : this(new PatientService()) { }
        public PatientsApiController(PatientService service) => this.service = service;

        // GET api/<controller>
        [Route("GetAll")]
        public List<Patient> GetAll()
        {
            List<Patient> list = service.GetAll();
            List<Patient> entity = new List<Patient>();

            foreach(var item in list)
            {
                entity.Add(new Patient() { Id = item.Id, Name= item.Name,Email= item.Email,CreatedOn= item.CreatedOn });
            }
            return entity;

        }

        // POST api/<controller>
        [Route("Create")]
        public void Create([FromBody]Patient value)
        {
            Patient entity = new Patient();
            entity.Email = value.Email;
            entity.Name = value.Name;
            entity.Phone = value.Phone;

            service.Create(entity);
        }

        [Route("Update")]
        public void Update([FromBody]Patient value)
        {
            Patient entity = service.GetById(value.Id);
            entity.Email = value.Email;
            entity.Name = value.Name;
            entity.Phone = value.Phone;

            service.Update(entity);
        }

        // DELETE api/<controller>/5
        [Route("Delete")]
        public void Delete(Patient value)
        {
            Patient entity = service.GetById(value.Id); 
            service.Delete(entity.Id);
        }

        [Route("GetById")]
        public Patient GetById(Patient value)
        {
            Patient entity = service.GetById(value.Id);
            return entity;
        }

    }
}