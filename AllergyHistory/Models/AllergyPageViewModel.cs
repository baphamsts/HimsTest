using System.Collections.Generic;
using System.Web.Mvc;

namespace AllergyHistory.Models
{
    public class AllergyPageViewModel
    { 
        public List<SelectListItem> AllergenSelectList { get; set; }
        public List<SelectListItem> AllergenTypeSelectList { get; set; }
        public List<SelectListItem> AllergenReactionSelectList { get; set; }
        public List<SelectListItem> AllergenSeveritySelectList { get; set; }
        public List<SelectListItem> MedicationSelectList { get; set; }
    }
}
