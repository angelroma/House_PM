using House_PM.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace House_PM_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPatientServiceWCF" in both code and config file together.
    [ServiceContract]
    public interface IPatientServiceWCF
    {
        [OperationContract]
        PatientWCF GetById(int id);
        [OperationContract]
        List<PatientWCF> GetAll();
        [OperationContract]
        string Create(PatientWCF entity);
        [OperationContract]
        string Update(PatientWCF entity);
        [OperationContract]
        string Delete(int id);
       
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class PatientWCF 
    {
        private int id;
        private string name;
        private string phone;
        private string email;
        private DateTime createdOn;
        [DataMember]
        public  int Id { get => id; set => id = value; }
        [DataMember]
        public  string Name { get => name; set => name = value; }
        [DataMember]
        public  string Phone { get => phone; set => phone = value; }
        [DataMember]
        public  string Email { get => email; set => email = value; }
        [DataMember]
        public  DateTime CreatedOn { get => createdOn; set => createdOn = value; }
    }
}
