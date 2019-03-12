using System.Collections.Generic;
using System.Xml.Serialization;

namespace AllergyHistory.Contract.ViewModels
{

    [XmlRoot("MedicationList")]
    public class MedicationList
    {
        [XmlElement("Medication")]
        public List<MedicationViewModel> Medications { get; set; }
    }

    public class MedicationViewModel
    {
        [XmlAttribute("DrugId")]
        public int DrugId { get; set; }
        [XmlAttribute("DrugName")]
        public string DrugName { get; set; }
        [XmlAttribute("LexiDrugId")]
        public string LexiDrugId { get; set; }
    }
}
