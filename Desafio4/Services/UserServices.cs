using System.ComponentModel.DataAnnotations;
using Desafio4.Model;
using Desafio4.Repository;

namespace Desafio4.Services
{
    public class UserServices
    {
        public Student Student;
        public StudentRepository StudentRepository;
        public UserServices()
        {
            StudentRepository = new StudentRepository();
        }
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
            var date = new DateTime(year, month, day);
            var age = DateTime.Now.Year - year;
            var stringGender = (GenderType) Enum.Parse(typeof(GenderType), gender.ToUpper());
            var stringRole = (Role) Enum.Parse(typeof(Role), role.ToUpper());

            Student = new Student(name, date, age, stringGender, email, cpf, login, password, stringRole);

            var context = new ValidationContext(Student, null, null);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(Student, context, results, true);

            if(!isValid)
            {
                foreach (var result in results)
                {
                    Console.WriteLine($"attr: {result.MemberNames.First()}, mesage: {result.ErrorMessage}");
                }
            }
            else
            {
                StudentRepository.SaveStudent(Student);
            }
        }

        public void GetAll()
        {
            var StudentList = StudentRepository.GetAllLINQExpression().Select(s => s).OrderBy(s => s).ToList();

            foreach (var item in StudentList)
            {
                System.Console.WriteLine($"Nome: {item.Name}, Email: {item.Email}, Age: {item.Age}");
            }
            // StudentRepository.GetAllLINQExpression();
        }
    }
}