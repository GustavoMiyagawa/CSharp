using System.ComponentModel.DataAnnotations;

namespace Desafio3.Model
{
    public abstract class User
    {
        [Required]
        [MinLength(10)]
        [MaxLength(80)]
        public string Name { get; private set; }
        [Required]
        [EmailAddress]
        public string Email { get; private set; }
        public DateTime DtBirth { get; private set; }
        [Range(18, 199, ErrorMessage = "Você precisa ser maior de 18 anos!!")]
        public int Age { get; private set; }

        public User(string name, string email, DateTime dtBirth, int age)
        {
            this.Name = name;
            this.Email = email;
            this.DtBirth = dtBirth;
            this.Age = age;
        }
    }
}