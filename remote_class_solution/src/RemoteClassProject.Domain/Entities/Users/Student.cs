using System;

namespace RemoteClassProject.Domain.Entities.Users
{
    public class Student : User
    {
      public Guid StudentID { get; private set; }
      public Student(string name, int year, int month, int day, string email, string cpf, string login, string password) : base(name, year, month, day, email, cpf, login, password)
      {
          this.StudentID = Guid.NewGuid();
      }
    }
}