using System.Collections.Generic;
using RemoteClassProject.Domain.Entities.Users;

namespace RemoteClassProject.Repository.Repositories
{
    public class StudentRepository
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
