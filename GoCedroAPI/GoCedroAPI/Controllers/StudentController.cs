using GoCedroAPI.Domains;
using GoCedroAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace GoCedroAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentController
    {
        public StudentServices studentServices;

        public StudentController()
        {
            studentServices = new StudentServices();
        }

        [HttpPost]
        public void CreateUser([FromBody] Student student)
        {
            studentServices.CreateStudent(student);
            //Console.WriteLine(student.Name);
        }

        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return studentServices.GetAll();
        }
    }
}
