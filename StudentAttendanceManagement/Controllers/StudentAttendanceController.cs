using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        [Route("GetStudentAttendance")]
        public IEnumerable<StudentAttendanceDetailsModel> GetStudentAttendance()
        {
            var stdn1 = new StudentAttendanceDetailsModel
            {
                StudentID = 1,
                StudentName = "Raju",
                AttendencePercentage = 80,  

            };
            var stdn2 = new StudentAttendanceDetailsModel
            {
                StudentID = 2,
                StudentName = "shahin",
                AttendencePercentage = 20
            };
            return new List<StudentAttendanceDetailsModel> { stdn1, stdn2 };
        }

        // GET api/<StudentAttendanceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAttendanceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAttendanceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAttendanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
