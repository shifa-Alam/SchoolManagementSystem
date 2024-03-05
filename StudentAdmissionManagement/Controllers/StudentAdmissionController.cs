using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        [Route("GetStudentAdmissionDetail")]
        public IEnumerable<StudentAdmissionDetailsModel> GetStudentAdmissionDetail()
        {

            var stdn1 = new StudentAdmissionDetailsModel
            {
                StudentID = 1,
                StudentName = "Raju",
                StudentClass = "X",
                DateofJoining = DateTime.Now,
            };
            var stdn2 = new StudentAdmissionDetailsModel
            {
                StudentID = 2,
                StudentName = "shahin",
                StudentClass = "IX",
                DateofJoining = DateTime.Now,
            };
            return new List<StudentAdmissionDetailsModel> { stdn1, stdn2 };
        }

        // GET api/<StudentAdmissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAdmissionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAdmissionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAdmissionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
