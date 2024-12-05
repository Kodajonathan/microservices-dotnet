using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttendenceService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendenceServiceController : ControllerBase
    {
        // GET: api/<AttendenceServiceController>
        [HttpGet]
        public IEnumerable<AttendenceServiceModel> Get()
        {
            AttendenceServiceModel attendenceServiceModel = new AttendenceServiceModel();
            AttendenceServiceModel attendenceServiceModel2 = new AttendenceServiceModel();
            AttendenceServiceModel attendenceServiceModel3 = new AttendenceServiceModel();

            attendenceServiceModel.Id = 1;
            attendenceServiceModel.FirstName = "John";
            
            attendenceServiceModel2.Id = 2;
            attendenceServiceModel2.FirstName = "Jack";
            
            attendenceServiceModel3.Id = 3;
            attendenceServiceModel3.FirstName = "Jackson";
            
            List<AttendenceServiceModel> listobj = new List<AttendenceServiceModel>
            {
                attendenceServiceModel, attendenceServiceModel2, attendenceServiceModel3
            };
            return listobj;
            
        }

        // GET api/<AttendenceServiceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST api/<AttendenceServiceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        
        // PUT api/<AttendenceServiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        
        // DELETE api/<AttendenceServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
