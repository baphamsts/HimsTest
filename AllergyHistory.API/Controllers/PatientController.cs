//namespace AlleryHistory.API.Controllers
//{
//    /// <summary>
//    /// This used to test repository workign with database, but require to set a connection to a databse"
//    /// </summary>
//    /// 
///*
//    [Route("api/[controller]")]
//    [ApiController]
//    [EnableCors]
//    public class PatientController : ControllerBase
//    {
//        private readonly IRepository<Patient> patientRepository;

//        public PatientController(IRepository<Patient> patientRepository)
//        {
//            this.patientRepository = patientRepository;
//        }

//        // GET: api/Patient
//        [HttpGet]
//        public IActionResult Get()
//        {
//            IEnumerable<Patient> Patients = patientRepository.GetAll();
//            return Ok(Patients);
//        }

//        // GET: api/Patient/5
//        [HttpGet("{id}", Name = "Get")]
//        public IActionResult Get(long id)
//        {
//            Patient Patient = patientRepository.Get(id);

//            if (Patient == null)
//            {
//                return NotFound("The Patient record couldn't be found.");
//            }

//            return Ok(Patient);
//        }

//        // POST: api/Patient
//        [HttpPost]
//        public IActionResult Post([FromBody] Patient Patient)
//        {
//            if (Patient == null)
//            {
//                return BadRequest("Patient is null.");
//            }

//            patientRepository.Add(Patient);
//            return CreatedAtRoute(
//                  "Get",
//                  new { Id = Patient.PatientId },
//                  Patient);
//        }

//        // PUT: api/Patient/5
//        [HttpPut("{id}")]
//        public IActionResult Put(long id, [FromBody] Patient Patient)
//        {
//            if (Patient == null)
//            {
//                return BadRequest("Patient is null.");
//            }

//            Patient PatientToUpdate = patientRepository.Get(id);
//            if (PatientToUpdate == null)
//            {
//                return NotFound("The Patient record couldn't be found.");
//            }

//            patientRepository.Update(PatientToUpdate, Patient);
//            return NoContent();
//        }

//        // DELETE: api/Patient/5
//        [HttpDelete("{id}")]
//        public IActionResult Delete(long id)
//        {
//            Patient Patient = patientRepository.Get(id);
//            if (Patient == null)
//            {
//                return NotFound("The Patient record couldn't be found.");
//            }

//            patientRepository.Delete(Patient);
//            return NoContent();
//        }

//        [HttpPost("loadData")]
//        public IActionResult LoadData()
//        {

//        }
//    }

//  */
//}
