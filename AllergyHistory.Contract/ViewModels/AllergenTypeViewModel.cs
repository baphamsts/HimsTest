using System.Collections.Generic;
using System.Xml.Serialization;

namespace AllergyHistory.Contract.ViewModels
{
    [XmlRoot("AllergenTypeList")]
    public class AllergenTypeList
    {
        [XmlElement("row")]
        public List<AllergenTypeViewModel> AllergenTypes { get; set; }
    }

    public class AllergenTypeViewModel
    {
        [XmlAttribute("CodeId")]
        public int CodeId { get; set; }
        [XmlAttribute("CodeDesc")]
        public string CodeDesc { get; set; }
        [XmlAttribute("CodeText")]
        public string CodeText { get; set; }
        [XmlAttribute("CodeValue")]
        public int CodeValue { get; set; }
        [XmlAttribute("TypeId")]
        public int TypeId { get; set; }
    }
}
