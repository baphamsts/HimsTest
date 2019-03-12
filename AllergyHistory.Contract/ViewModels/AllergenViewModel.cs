using System.Collections.Generic;
using System.Xml.Serialization;

namespace AllergyHistory.Contract.ViewModels
{

    [XmlRoot("AllergenList")]
    public class AllergenList
    {
        [XmlElement("row")]
        public List<AllergenViewModel> Allergens { get; set; }
    }
    public class AllergenViewModel
    {
        [XmlAttribute("CodeId")]
        public int CodeId { get; set; }
        [XmlAttribute("CodeDesc")]
        public string CodeDesc { get; set; }
        [XmlAttribute("CodeText")]
        public string CodeText { get; set; }
        [XmlAttribute("TypeId")]
        public int TypeId { get; set; }
    }
}
