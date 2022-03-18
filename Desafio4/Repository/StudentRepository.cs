using Desafio4.Model;

namespace Desafio4.Repository
{
    public class StudentRepository
    {
        public Student Student;
        public List<Student> Students;
        public StudentRepository()
        {
            Students = new List<Student>();
        }
        public void SaveStudent(Student student)
        {
            Students.Add(student);
        }

        public void GetAllLINQExpression()
        {
            var scoreQuery = Students.Select(s => s)
                                    .OrderBy(s => s)
                                    .ToList();

            foreach (var item in scoreQuery)
            {
                System.Console.WriteLine($"Nome: {item.Name}, Email: {item.Email}, Age: {item.Age}");
            }

            // return scoreQuery;
            // return Students;
        }

        
    }
}