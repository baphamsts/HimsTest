using AllergyHistory.Contract.ViewModels;
using AllergyHistory.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AllergyHistory.Services
{
    public class RevokeApiService : IRevokeApiService
    {
        public async Task<List<SelectListItem>> BuildAllergenTypeSelectList()
        {
            var allergenTypeSelectItems = new List<SelectListItem>();
            allergenTypeSelectItems.Add(new SelectListItem { Value = "-1", Text = "Please select an option" });

            string apiUrl = $"{AppSettings.ApiEndPoint}/allergen/types";

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

        public async Task<List<SelectListItem>> BuildAllergenReactionSelectList()
        {
            var allergenReactionSelectItems = new List<SelectListItem>();
            allergenReactionSelectItems.Add(new SelectListItem { Value = "-1", Text = "Please select an option" });

            string apiUrl = $"{AppSettings.ApiEndPoint}/allergen/reactions";

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

        public async Task<List<SelectListItem>> BuildAllergenSeveritySelectList()
        {
            var allergenSeveritySelectItems = new List<SelectListItem>();
            allergenSeveritySelectItems.Add(new SelectListItem { Value = "-1", Text = "Please select an option" });

            string apiUrl = $"{AppSettings.ApiEndPoint}/allergen/severities";

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


        public async Task<List<SelectListItem>> BuildAllergenSelectList()
        {
            var allergenSelectItems = new List<SelectListItem>();
            allergenSelectItems.Add(new SelectListItem { Value = "-1", Text = "Please select an option" });

            string apiUrl = $"{AppSettings.ApiEndPoint}/allergen/allergens";

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

        public async Task<List<SelectListItem>> BuildMedicationSelectList()
        {
            var medicationSelectItems = new List<SelectListItem>();
            medicationSelectItems.Add(new SelectListItem { Value = "-1", Text = "Please select an option" });

            string apiUrl = $"{AppSettings.ApiEndPoint}/allergen/medications";

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



        public async Task<T> GetXmlDataListViaAPI<T>(string apiUrl) where T : class
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

    }
}