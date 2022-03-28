using GoCedroAPI.Domains.UserDomain;

namespace GoCedroAPI.Domains
{
    public class Facilitator : User
    {
        public Facilitator(string name, int year, int month, int day, string email, string cpf, string login, string password) : base(name, year, month, day, email, cpf, login, password)
        {
        }
    }
}
