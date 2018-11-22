using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace House_PM.Models.Domain
{
    public class Patient
    {
        private int id;
        private string name;
        private string phone;
        private string email;
        private DateTime createdOn;

        [Key]
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public DateTime CreatedOn { get => createdOn; set => createdOn = value; }
    }
}