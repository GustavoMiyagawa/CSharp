using System;
using System.ComponentModel.DataAnnotations;
using RemoteClassProject.Domain.Entities.Enums;

namespace RemoteClassProject.Domain.Entities.Users
{
    public abstract class User : IComparable
    {
        [Required(ErrorMessage = "O campo Name é obrigatório")]
        [MinLength(10)]
        [MaxLength(80)]
        public string Name { get; private set; }
        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }
        public DateTime DtBirth { get; private set; }
        [Required(ErrorMessage = "O campo idade é obrigatório")]
        [Range(18, 199, ErrorMessage = "Você precisa ser maior de 18 anos!!")]
        public int Age { get; private set; }
        [EnumDataType(typeof(GenderType))]
        public GenderType Gender { get; private set; }
        [Required(ErrorMessage = "O campo E-mail é obrigatório")]
        [EmailAddress]
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        [EnumDataType(typeof(Role))]
        public Role Role { get; private set; }

        public User(string name, int year, int month, int day, GenderType gender, string email, string cpf, string login, string password, Role role)
        {
            this.Name = name;
            //this.Year = year;
            this.DtBirth = DefineDataDeAniversario(year, month, day);
            this.Age = DateTime.Now.Year - year;
            this.Gender = gender;
            this.Email = email;
            this.CPF = cpf;
            this.Login = login;
            this.Password = password;
            this.Role = role;
        }

        public DateTime DefineDataDeAniversario(int year, int month, int day)
        {
            return new DateTime(year, month, day);
        }

        public int CompareTo(object obj)
        {
            User that = obj as User;
            return this.Name.CompareTo(that.Name);
        }
    }
}