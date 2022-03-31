using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RemoteClassProject.App.Interface;
using RemoteClassProject.App.Services;
using RemoteClassProject.Domain.Entities.Users;

namespace RemoteClassProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentController : ControllerBase
    {
        // private IStudentServices _studentServices;

        public StudentServices _studentServices;

        public StudentController()
        {
            _studentServices = new StudentServices();
        }

        // public StudentController(IStudentServices studentServices)
        // {
        //     _studentServices = studentServices;
        // }

        [HttpPost]
        public void CreateUser([FromBody] Student student)
        {
            _studentServices.CreateStudent(student);
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_studentServices.GetAll());
        }

        //https://docs.microsoft.com/pt-br/aspnet/core/mvc/controllers/routing?view=aspnetcore-6.0
        [HttpGet("{name}")]
        public IEnumerable<Student> GetStudentByName(string name)
        {
            return _studentServices.GetStudentByName(name);
        }

        [HttpGet("searchId/{id}")]
        public IActionResult GetStudentById(string id)
        {
            var student = _studentServices.GetStudentById(id);

            if(student != null)
            {
                return Ok(student);
            }
            return NotFound();
        }
    }
}
