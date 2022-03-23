using Desafio4.Controller;
using Desafio4.Repository;

namespace Desafio4
{
  class Program
  {
    static void Main(string[] args)
    {
      UserController user = new UserController();      

      user.CreateUser("Antônio Pereira", 2012, 9, 21, "male", "antonio.pereira@cedrotech.com", "014.665.941-44", "antony", "123", "STUDENT");
      user.CreateUser("Gustavo Miyagawa", 1992, 8, 12, "male", "gustavo.santos@cedrotech.com", "014.665.941-44", "gus", "123", "STUDENT");
      user.CreateUser("Alexandre Miyagawa", 1981, 01, 24, "male", "gustavo.santos@cedrotech.com", "014.665.941-44", "gus", "123", "STUDENT");

      user.GetAll();
    }
  }
}