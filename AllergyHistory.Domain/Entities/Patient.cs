using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergyHistory.Domain.Entities
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int CISId { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Provider { get; set; }
        public string Population { get; set; }
        public string AxisI { get; set; }
        public string ClientAllergyId { get; set; }
        public string Allergen { get; set; }
        public bool deleted { get; set; }
    }
}
