using AllergyHistory.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AlleryHistory.API.Controllers
{
    public class AllergenController : ApiController
    {
        private readonly IAllergenInputService allergenInputService;

        public AllergenController(IAllergenInputService allergenInputService)
        {
            this.allergenInputService = allergenInputService;
        }

        [Route("api/allergen/reactions")]
        [HttpGet]
        public HttpResponseMessage Reactions()
        {
            var data = allergenInputService.GetAllAllergenReactionXml();
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            if (data != null)
            {
                resp.Content = new StringContent(data, System.Text.Encoding.UTF8, "text/plain");
            }

            return resp;
        }

        [Route("api/allergen/severities")]
        [HttpGet]
        public HttpResponseMessage Severities()
        {
            var data = allergenInputService.GetAllAllergenSeverityXml();
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            if (data != null)
            {
                resp.Content = new StringContent(data, System.Text.Encoding.UTF8, "text/plain");
            }

            return resp;
        }

        [Route("api/allergen/medications")]
        [HttpGet]
        public HttpResponseMessage Medications()
        {
            var data = allergenInputService.GetAllMedicationXml();
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            if (data != null)
            {
                resp.Content = new StringContent(data, System.Text.Encoding.UTF8, "text/plain");
            }

            return resp;
        }


        
        [Route("api/allergen/types")]
        [HttpGet]
        public HttpResponseMessage Types()
        {
            var data = allergenInputService.GetAllAllergenTypeXml();

            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            if (data != null)
            {
                resp.Content = new StringContent(data, System.Text.Encoding.UTF8, "text/plain");
            }

            return resp;
            
        }

        [Route("api/allergen/allergens")]
        [HttpGet]
        public HttpResponseMessage Allergens()
        {
            var data = allergenInputService.GetAllAllergenXml();
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            if (data != null)
            {
                resp.Content = new StringContent(data, System.Text.Encoding.UTF8, "text/plain");
            }

            return resp;
        }
    }
}
