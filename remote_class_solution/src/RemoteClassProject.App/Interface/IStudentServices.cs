using System.Collections.Generic;
using RemoteClassProject.Domain.Entities.Users;

namespace RemoteClassProject.App.Interface
{
    public interface IStudentServices
    {
        void CreateStudent(Student student);
        IEnumerable<Student> GetAll();
        IEnumerable<Student> GetStudentByName(string name);
        Student GetStudentById(string id);
    }
}