namespace Desafio4.Model
{
  public class Student : User
  {
    public Guid StudentID { get; private set; }
    public Student(string name, DateTime dtBirth, int age, GenderType gender, string email, string cpf, string login, string password, Role role)
      : base(name, dtBirth, age, gender, email, cpf, login, password, role)
    {
    }
  }
}