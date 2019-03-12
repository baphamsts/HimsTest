using System.Collections.Generic;
using System.Xml.Serialization;

namespace AllergyHistory.Contract.ViewModels
{

    [XmlRoot("AllergenSeverityList")]
    public class AllergenSeverityList
    {
        [XmlElement("row")]
        public List<AllergenSeverityViewModel> AllergenSeverities { get; set; }
    }
    public class AllergenSeverityViewModel
    {
        [XmlAttribute("CodeId")]
        public int CodeId { get; set; }
        [XmlAttribute("CodeDesc")]
        public string CodeDesc { get; set; }
        [XmlAttribute("CodeValue")]
        public int CodeValue { get; set; }
        [XmlAttribute("TypeId")]
        public int TypeId { get; set; }
    }


}
