using System.ComponentModel.DataAnnotations;

namespace Desafio4.Model
{
  public abstract class User : IComparable
  {
    [Required(ErrorMessage = "O campo Name é obrigatório")]
    [MinLength(10)]
    [MaxLength(80)]
    public string Name { get; private set; }
    public DateTime DtBirth { get; private set; }
    [Required(ErrorMessage = "O campo idade é obrigatório")]
    [Range(18, 199, ErrorMessage = "Você precisa ser maior de 18 anos!!")]
    public int Age { get; private set; }
    public GenderType Gender { get; private set; }

    [Required(ErrorMessage = "O campo E-mail é obrigatório")]
    [EmailAddress]
    public string Email { get; private set; }
    public string CPF { get; private set; }
    public string Login { get; private set; }
    public string Password { get; private set; }
    public Role Role { get; private set; }

    public User(string name, DateTime dtBirth, int age, GenderType gender, string email, string cpf, string login, string password, Role role)
    {
      // fazendo cast de string para enum. No minuto 14:00 o Monteiro explica esse código.
      // Gender = (GenderType) Enum.Parse(typeof(GenderType), gender.ToUpper());
      this.Name = name;
      this.DtBirth = dtBirth;
      this.Age = age;
      this.Gender = gender;
      this.Email = email;
      this.CPF = cpf;
      this.Login = login;
      this.Password = password;
      this.Role = role;
    }

    public int CompareTo(object obj)
    {
      User that = obj as User;
      return this.Name.CompareTo(that.Name);
    }
  }
}