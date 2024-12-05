using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using StudentRecordService.Models;

namespace StudentRecordService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRecordServiceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public StudentRecordServiceController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentRecordServiceModel>>> GetStudentRecords()
        {
            return await _context.studentRecord.ToListAsync();
        }
        
        
        // // GET: api/<StudentRecordServiceController>
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }
        //
        // // GET api/<StudentRecordServiceController>/5
        // [HttpGet("{id}")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST api/<StudentRecordServiceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentRecordServiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentRecordServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
