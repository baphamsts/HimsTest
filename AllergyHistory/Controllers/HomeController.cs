using AllergyHistory.Contract.ViewModels;
using AllergyHistory.Helpers;
using AllergyHistory.Models;
using AllergyHistory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AllergyHistory.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllergyHistoryDataService allergyHistoryDataService;

        public HomeController(IAllergyHistoryDataService allergyHistoryDataService)
        {
            this.allergyHistoryDataService = allergyHistoryDataService;
        }
        public async Task<ActionResult> Index()
        {
            var model = new AllergyPageViewModel();
            model.AllergenTypeSelectList = await BuildAllergenTypeSelectList();
            model.AllergenReactionSelectList = await BuildAllergenReactionSelectList();
            model.AllergenSeveritySelectList = await BuildAllergenSeveritySelectList();
            model.AllergenSelectList = await BuildAllergenSelectList();
            model.MedicationSelectList = await BuildMedicationSelectList();

            return View(model);
        }

        private async Task<List<SelectListItem>> BuildAllergenTypeSelectList()
        {
            var allergenTypeSelectItems = new List<SelectListItem>();
            allergenTypeSelectItems.Add(new SelectListItem { Value = "-1", Text = "Please select an option" });

            string apiUrl = "http://localhost:62038/api/allergen/types";

            var allergenTypeList = await GetXmlDataListViaAPI<AllergenTypeList>(apiUrl);

            allergenTypeList.AllergenTypes.ForEach(x =>
            {
                allergenTypeSelectItems.Add(new SelectListItem
                {
                    Value = x.CodeId.ToString(),
                    Text = x.CodeText
                });
            });

            return allergenTypeSelectItems;
        }

        private async Task<List<SelectListItem>> BuildAllergenReactionSelectList()
        {
            var allergenReactionSelectItems = new List<SelectListItem>();
            allergenReactionSelectItems.Add(new SelectListItem { Value = "-1", Text = "Please select an option" });

            string apiUrl = "http://localhost:62038/api/allergen/reactions";

            var allergenReactionList = await GetXmlDataListViaAPI<AllergenReactionList>(apiUrl);

            allergenReactionList.AllergenReactions.ForEach(x =>
            {
                allergenReactionSelectItems.Add(new SelectListItem
                {
                    Value = x.CodeId.ToString(),
                    Text = x.CodeDesc
                });
            });

            return allergenReactionSelectItems;
        }

        private async Task<List<SelectListItem>> BuildAllergenSeveritySelectList()
        {
            var allergenSeveritySelectItems = new List<SelectListItem>();
            allergenSeveritySelectItems.Add(new SelectListItem { Value = "-1", Text = "Please select an option" });

            string apiUrl = "http://localhost:62038/api/allergen/severities";

            var allergenSeverityList = await GetXmlDataListViaAPI<AllergenSeverityList>(apiUrl);

            allergenSeverityList.AllergenSeverities.ForEach(x =>
            {
                allergenSeveritySelectItems.Add(new SelectListItem
                {
                    Value = x.CodeId.ToString(),
                    Text = x.CodeDesc
                });
            });

            return allergenSeveritySelectItems;
        }


        private async Task<List<SelectListItem>> BuildAllergenSelectList()
        {
            var allergenSelectItems = new List<SelectListItem>();
            allergenSelectItems.Add(new SelectListItem { Value = "-1", Text = "Please select an option" });

            string apiUrl = "http://localhost:62038/api/allergen/allergens";

            var allergenList = await GetXmlDataListViaAPI<AllergenList>(apiUrl);

            allergenList.Allergens.ForEach(x =>
            {
                allergenSelectItems.Add(new SelectListItem
                {
                    Value = x.CodeId.ToString(),
                    Text = x.CodeText
                });
            });

            return allergenSelectItems;
        }

        private async Task<List<SelectListItem>> BuildMedicationSelectList()
        {
            var medicationSelectItems = new List<SelectListItem>();
            medicationSelectItems.Add(new SelectListItem { Value = "-1", Text = "Please select an option" });

            string apiUrl = "http://localhost:62038/api/allergen/medications";

            var medicationList = await GetXmlDataListViaAPI<MedicationList>(apiUrl);

            medicationList.Medications.ForEach(x =>
            {
                medicationSelectItems.Add(new SelectListItem
                {
                    Value = x.DrugId.ToString(),
                    Text = x.DrugName
                });
            });

            return medicationSelectItems;
        }



        private async Task<T> GetXmlDataListViaAPI<T>(string apiUrl) where T : class
        {
            T returnListObject = default(T);

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var xmlContent = await response.Content.ReadAsStringAsync();
                    var wellFormatXml = $"<{typeof(T).Name}>{xmlContent}</{typeof(T).Name}> ";

                    returnListObject = XmlHelper.DeserializeXMLStringToObject<T>(wellFormatXml);
                }

            }

            return returnListObject;
        }


        public async Task<ActionResult> LoadDataXml()
        {
            try
            {
                //var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                //var start = Request.Form["start"].FirstOrDefault();
                //var pageLength = Request.Form["length"].FirstOrDefault();
                //var searchPatientValue = Request.Form["search[value]"].FirstOrDefault().ToString();

                //Paging Size (10,20,50,100, all = -1)  
                //int pageSize = pageLength != null ? Convert.ToInt32(pageLength) : 0;
                //int skip = start != null ? Convert.ToInt32(start) : 0;
                var draw = 1;
                var pageSize = 10;
                var skip = 0;
                int recordsTotal = 0;

                var allergyHistoryList = await GetXmlDataListViaAPI<AllergenHistoryList>("http://localhost:62038/api/allergen-histories");

                var allergyHistoryData = allergyHistoryList.AllergenHistories.Select(x => new AllergenHistoryDataTableViewModel
                {
                    Id = x.ClientId,
                    AllergenId = x.AllergenId,
                    AllergenType = x.AllergenType,
                    ReactionId = x.ReactionId,
                    SeverityId = x.SeverityId,
                    Patient = x.ClientName,
                    Type = x.Type,
                    Allergen = x.Allergen,
                    Reaction = x.ReactionDesc,
                    Serverty = x.SeverityDesc,
                    Notes = x.Notes,
                    CreateInfo = $"{x.CreateDate} by {x.CreateUser}",
                    UpdateInfo = $"{x.UpdateDate} by {x.UpdateUser}"
                });

                //if (!string.IsNullOrEmpty(searchPatientValue))
                //{
                //    allergyHistoryData = allergyHistoryData.Where(m => m.Patient.Contains(searchPatientValue));
                //}

                recordsTotal = allergyHistoryData.Count();

                var data = pageSize == -1 ? allergyHistoryData : allergyHistoryData.Skip(skip).Take(pageSize);

                return Json(new {
                    draw = draw,
                    recordsFiltered = recordsTotal,
                    recordsTotal = recordsTotal,
                    data = data });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
    }
}
