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
        }

        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return studentServices.GetAll();
        }

        //https://docs.microsoft.com/pt-br/aspnet/core/mvc/controllers/routing?view=aspnetcore-6.0
        [HttpGet("{name}")]
        public IEnumerable<Student> GetStudentByName(string name)
        {
            return studentServices.GetStudentByName(name);
        }
    }
}
