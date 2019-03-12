using System.Collections.Generic;
using System.Xml.Serialization;

namespace AllergyHistory.Contract.ViewModels
{

    [XmlRoot("AllergenReactionList")]
    public class AllergenReactionList
    {
        [XmlElement("row")]
        public List<AllergenSeverityViewModel> AllergenReactions { get; set; }
    }
    public class AllergenReactionViewModel
    {
        [XmlAttribute("CodeId")]
        public int CodeId { get; set; }
        [XmlAttribute("CodeDesc")]
        public string CodeDesc { get; set; }
        [XmlAttribute("CodeValue")]
        public string CodeValue { get; set; }
        [XmlAttribute("TypeId")]
        public int TypeId { get; set; }
    }
}
