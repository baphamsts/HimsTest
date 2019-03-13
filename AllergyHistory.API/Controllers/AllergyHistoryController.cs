using AllergyHistory.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AlleryHistory.API.Controllers
{
    public class AllergyHistoryController : ApiController
    {
        private readonly IAllergyHistoryDataService allergyHistoryDataService;

        public AllergyHistoryController(IAllergyHistoryDataService allergyHistoryDataService)
        {
            this.allergyHistoryDataService = allergyHistoryDataService;
        }

        [Route("api/allergen-histories")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var fakeDataFolderPath = AppSettings.FakeDataFolderPath;
            var data = allergyHistoryDataService.GetAllAllergenHistoryXml(fakeDataFolderPath);

            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            if (data != null)
            {
                resp.Content = new StringContent(data, System.Text.Encoding.UTF8, "text/plain");
            }

            return resp;
        }
    }
}
