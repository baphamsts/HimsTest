using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AllergyHistory.Services
{
    public interface IRevokeApiService
    {
        Task<List<SelectListItem>> BuildAllergenTypeSelectList();
        Task<List<SelectListItem>> BuildAllergenReactionSelectList();
        Task<List<SelectListItem>> BuildAllergenSeveritySelectList();
        Task<List<SelectListItem>> BuildAllergenSelectList();
        Task<List<SelectListItem>> BuildMedicationSelectList();
        Task<T> GetXmlDataListViaAPI<T>(string apiUrl) where T : class;
    }
}