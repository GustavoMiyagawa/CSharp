using System.ComponentModel.DataAnnotations;

namespace GoCedroAPI.Domains.UserDomain
{
    public abstract class User
    {
        [Required(ErrorMessage = "O campo Name é obrigatório")]
        public string Name { get; private set; }

        public User(string name)
        {
            this.Name = name;
        }
    }
}
