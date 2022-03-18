namespace Desafio4.Model
{
  public class Facilitator : User
  {
      public Guid FacilitatorID { get; private set; }
    public Facilitator(string name, DateTime dtBirth, int age, GenderType gender, string email, string cpf, string login, string password, Role role)
     : base(name, dtBirth, age, gender, email, cpf, login, password, role)
    {
    }
  }
}