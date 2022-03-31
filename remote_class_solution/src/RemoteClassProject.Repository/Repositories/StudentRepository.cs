using System.Collections.Generic;
using RemoteClassProject.Domain.Entities.Users;
using RemoteClassProject.Domain.Interface;

namespace RemoteClassProject.Repository.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> Students = new List<Student>();

        public void SaveStudent(Student student)
        {
            Students.Add(student);
        }

        public List<Student> GetAll()
        {
            return Students;
        }
    }
}
