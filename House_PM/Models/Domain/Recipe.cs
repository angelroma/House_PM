using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace House_PM.Models.Domain
{
    public class Recipe
    {
        private int id;
        private DateTime createdOn;
        private string treatment;
        private string medicament;
        private int id_Patient;

        [Key]
        public int Id { get => id; set => id = value; }
        public DateTime CreatedOn { get => createdOn; set => createdOn = value; }
        public string Treatment { get => treatment; set => treatment = value; }
        public string Medicament { get => medicament; set => medicament = value; }

        [ForeignKey("Patient")]
        public int Id_Patient { get => id_Patient; set => id_Patient = value; }
        public Patient Patient { get; set; }
    }
}