using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergyHistory.Domain.Entities
{
    public class AllergenHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string CISId { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Provider { get; set; }
        public string Population { get; set; }
        public string AxisI { get; set; }
        public string AxisIDesc { get; set; }
        public int ClientAllergyId { get; set; }
        public string Allergen { get; set; }
        public string Notes { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; }
        public int AllergenId { get; set; }
        public int AllergenType { get; set; }
        public int ReactionId { get; set; }
        public int SeverityId { get; set; }
        public string ReactionDesc { get; set; }
        public string SeverityDesc { get; set; }
        public string Type { get; set; }
        public string DrugName { get; set; }
        public DateTime CreateDateWithTime { get; set; }
        public DateTime UpdateDateWithTime { get; set; }
    }
}
