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
        private readonly IRevokeApiService revokeApiService;

        public HomeController(IAllergyHistoryDataService allergyHistoryDataService, IRevokeApiService revokeApiService)
        {
            this.allergyHistoryDataService = allergyHistoryDataService;
            this.revokeApiService = revokeApiService;
        }
        public async Task<ActionResult> Index()
        {
            var model = new AllergyPageViewModel();
            model.AllergenTypeSelectList = await revokeApiService.BuildAllergenTypeSelectList();
            model.AllergenReactionSelectList = await revokeApiService.BuildAllergenReactionSelectList();
            model.AllergenSeveritySelectList = await revokeApiService.BuildAllergenSeveritySelectList();
            model.AllergenSelectList = await revokeApiService.BuildAllergenSelectList();
            model.MedicationSelectList = await revokeApiService.BuildMedicationSelectList();

            return View(model);
        }

       

        public async Task<ActionResult> LoadDataXml()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"];
                var start = Request.Form["start"];
                var pageLength = Request.Form["length"];
                var searchPatientValue = Request.Form["search[value]"];
                var stateSearch = Request.Form["statesearch"];
                var timeSearch = Request.Form["timesearch"];

                //Paging Size(10,20,50,100, all = -1)  
                
                int pageSize = pageLength != string.Empty ? Convert.ToInt32(pageLength) : 0;
                int skip = start != string.Empty ? Convert.ToInt32(start) : 0;

                bool deleted = stateSearch == "0" ? true : false;
                DateTime startTimeFilter = GetStartTimeFilter(timeSearch);

                int recordsTotal = 0;

                var allergyHistoryList = await revokeApiService.GetXmlDataListViaAPI<AllergenHistoryList>($"{AppSettings.ApiEndPoint}/allergen-histories");

                var allergyHistoryData = allergyHistoryList.AllergenHistories
                    .Where(o => o.Deleted == deleted && o.UpdateDateWithTime >= startTimeFilter)
                    .Select(x => new AllergenHistoryDataTableViewModel
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

                if (!string.IsNullOrEmpty(searchPatientValue))
                {
                    allergyHistoryData = allergyHistoryData.Where(m => m.Patient.Contains(searchPatientValue));
                }

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
        

        public ActionResult UpdateAllergen()
        {
            try
            {
                return Json( new { success = true });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DateTime GetStartTimeFilter(string timeFilterOption)
        {
            DateTime startTime = DateTime.Now;

            switch (timeFilterOption)
            {

                case "all":
                    startTime = DateTime.MinValue;
                    break;
                case "lastyear":
                    startTime = DateTime.Today.AddYears(-1);
                    break;
                case "lastsixmonth":
                    startTime = DateTime.Today.AddMonths(-6);
                    break;
                case "lastday":
                    startTime = DateTime.Today.AddDays(-1);
                    break;
                    
            }

            return startTime;

        }
    }
}
