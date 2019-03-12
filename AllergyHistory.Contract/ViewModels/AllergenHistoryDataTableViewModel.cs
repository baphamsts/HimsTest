using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AllergyHistory.Contract.ViewModels
{

    [XmlRoot("AllergenHistoryList")]
    public class AllergenHistoryList
    {
        [XmlElement("row")]
        public List<AllergenHistoryViewModel> AllergenHistories { get; set; }
    }

    public class AllergenHistoryViewModel
    {
        [XmlAttribute("CodeId")]
        public int ClientId { get; set; }
        [XmlAttribute("ClientName")]
        public string ClientName { get; set; }
        [XmlAttribute("CISId")]
        public string CISId { get; set; }
        [XmlAttribute("DOB")]
        public string DOB { get; set; }
        [XmlAttribute("Gender")]
        public string Gender { get; set; }
        [XmlAttribute("Provider")]
        public string Provider { get; set; }
        [XmlAttribute("Population")]
        public string Population { get; set; }
        [XmlAttribute("AxisI")]
        public string AxisI { get; set; }
        [XmlAttribute("AxisIDesc")]
        public string AxisIDesc { get; set; }
        [XmlAttribute("ClientAllergyId")]
        public int ClientAllergyId { get; set; }
        [XmlAttribute("Allergen")]
        public string Allergen { get; set; }
        [XmlAttribute("Notes")]
        public string Notes { get; set; }
        [XmlAttribute("CreateUser")]
        public string CreateUser { get; set; }
        [XmlAttribute("CreateDate")]
        public string CreateDate { get; set; }
        [XmlAttribute("UpdateUser")]
        public string UpdateUser { get; set; }
        [XmlAttribute("UpdateDate")]
        public string UpdateDate { get; set; }
        [XmlAttribute("Deleted")]
        public bool Deleted { get; set; }
        [XmlAttribute("AllergenId")]
        public int AllergenId { get; set; }
        [XmlAttribute("AllergenType")]
        public int AllergenType { get; set; }
        [XmlAttribute("ReactionId")]
        public int ReactionId { get; set; }
        [XmlAttribute("SeverityId")]
        public int SeverityId { get; set; }
        [XmlAttribute("ReactionDesc")]
        public string ReactionDesc { get; set; }
        [XmlAttribute("SeverityDesc")]
        public string SeverityDesc { get; set; }
        [XmlAttribute("Type")]
        public string Type { get; set; }
        [XmlAttribute("DrugName")]
        public string DrugName { get; set; }
        [XmlAttribute("CreateDateWithTime")]
        public DateTime CreateDateWithTime { get; set; }
        [XmlAttribute("UpdateDateWithTime")]
        public DateTime UpdateDateWithTime { get; set; }
    }

        public class AllergenHistoryDataTableViewModel
    {
        public int Id { get; set; }
        public int AllergenId { get; set; }
        public int AllergenType { get; set; }
        public int ReactionId { get; set; }
        public int SeverityId { get; set; }
        public string Patient { get; set; }
        public string Type { get; set; }
        public string Allergen { get; set; }
        public string Reaction{ get; set; }
        public string Serverty { get; set; }
        public string Notes { get; set; }
        public string CreateInfo { get; set; }
        public string UpdateInfo { get; set; }
    }
}

