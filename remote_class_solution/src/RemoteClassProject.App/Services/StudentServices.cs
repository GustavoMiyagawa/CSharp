using RemoteClassProject.App.Interface;
using RemoteClassProject.Domain.Entities.Users;
using RemoteClassProject.Repository.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace RemoteClassProject.App.Services
{
    public class StudentServices : IStudentServices
    {
        public StudentRepository studentRepository;

        public StudentServices()
        {
            studentRepository = new StudentRepository();
        }

        public void CreateStudent(Student student)
        {
            studentRepository.SaveStudent(student);
        }

        public IEnumerable<Student> GetAll()
        {
            var students = studentRepository.GetAll().Select(s => s).OrderBy(s => s).ToList();

            return students;
        }

        public IEnumerable<Student> GetStudentByName(string name)
        {
            var students = studentRepository.GetAll().Where(s => s.Name.Contains(name)).ToList();

            return students;
        }
    }
}