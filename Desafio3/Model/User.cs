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

        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}