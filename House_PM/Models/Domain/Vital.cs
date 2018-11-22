using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace House_PM.Models.Domain
{
    public class Vital
    {
        private int id;
        private string age;
        private string gender;
        private string height;
        private string weight;
        private string bp;
        private string hr;
        private string br;
        private int id_patient;

        [Key]
        public int Id { get => id; set => id = value; }
        public string Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Height { get => height; set => height = value; }
        public string Weight { get => weight; set => weight = value; }
        public string Bp { get => bp; set => bp = value; }
        public string Hr { get => hr; set => hr = value; }
        public string Br { get => br; set => br = value; }

        [ForeignKey("Patient")]
        public int Id_patient { get => id_patient; set => id_patient = value; }
        public Patient Patient { get; set; }
    }
}