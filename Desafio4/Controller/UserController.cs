using Desafio4.Services;

namespace Desafio4.Controller
{
    public class UserController
    {
        public UserServices UserServices;
        public void CreateUser
        (
            string name,
            int year,
            int month,
            int day,
            string gender,
            string email,
            string cpf,
            string login,
            string password,
            string role
        )
        {
            UserServices = new UserServices();

            UserServices.CreateUser(name, year, month, day, gender, email, cpf, login, password, role);
        }

        public void GetAll()
        {
            UserServices.GetAll();
        }
    }
}