using System.Collections.Generic;
using RemoteClassProject.Domain.Entities.Users;

namespace RemoteClassProject.Domain.Interface
{
    public interface IStudentRepository
    {
        void SaveStudent(Student student);
        List<Student> GetAll();
    }
}