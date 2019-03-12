using System;

namespace AllergyHistory.Contract.DTOs
{
    /// <summary>
    /// This is Demo a DTO when we have some gap between terminology between domain etities
    /// For example the ClientName might be the PatientName in other domain.
    /// </summary>
    public class AllergenHistoryDTO
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
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

