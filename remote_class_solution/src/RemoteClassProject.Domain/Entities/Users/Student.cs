using System;
using RemoteClassProject.Domain.Entities.Enums;

namespace RemoteClassProject.Domain.Entities.Users
{
    public class Student : User
    {
      public Guid StudentID { get; private set; }
      public Student(string name, int year, int month, int day, GenderType gender, string email, string cpf, string login, string password) : base(name, year, month, day, gender, email, cpf, login, password)
      {
          this.StudentID = Guid.NewGuid();
      }
    }
}