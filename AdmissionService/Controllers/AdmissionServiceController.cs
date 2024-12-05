using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdmissionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmissionServiceController : ControllerBase
    {
        // GET: api/<AdmissionServiceController>
        [HttpGet]
        public IEnumerable<AdmissionServiceModel> Get()
        {
            AdmissionServiceModel admissionServiceModel = new AdmissionServiceModel();
            AdmissionServiceModel admissionServiceModel2 = new AdmissionServiceModel();
            admissionServiceModel.Id = 1;
            admissionServiceModel.FirstName = "jonathan";
            admissionServiceModel.LastName = "lungu";
            admissionServiceModel.DateOfBirth = DateTime.Now;
            
            admissionServiceModel2.Id = 2;
            admissionServiceModel2.FirstName = "jackson";
            admissionServiceModel2.LastName = "zulu";
            admissionServiceModel.DateOfBirth = DateTime.Now;
            
            List<AdmissionServiceModel> listObj=new List<AdmissionServiceModel>{admissionServiceModel, admissionServiceModel2};
            return listObj;
        }

        // GET api/<AdmissionServiceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AdmissionServiceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AdmissionServiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AdmissionServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
