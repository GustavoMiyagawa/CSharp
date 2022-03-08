using System.ComponentModel.DataAnnotations;

namespace Desafio3.Model
{
  class StudentRepository
  {
    public List<Student> Students { get; set; }
    public Student Student;

    public StudentRepository()
    {
      Students = new List<Student>();
    }

    public void saveStudent(string name, string email)
    {
      Student = new Student(name, email);

      var context = new ValidationContext(Student, null, null);
      var results = new List<ValidationResult>();
      var isValid = Validator.TryValidateObject(Student, context, results, true);

      if(!isValid)
      {
        foreach(var result in results)
        {
          Console.WriteLine($"attr: {result.MemberNames.First()}, mesage: {result.ErrorMessage}");
        }
      }
      else
      {
        Students.Add(Student);
      }

    }

    public void GetAll()
    {
      List<Student> sortList = Students;
      sortList.Sort();
      foreach (var student in sortList)
      {
        var name = student.Name;
        var email = student.Email;
        System.Console.WriteLine($"Nome: {name}, Email: {email}");
      }
    }

    public void FilterByName(string name)
    {
      IEnumerable<Student> scoreQuery =
        from score in Students
        where score.Name.Contains(name)
        select score;

      foreach (var item in scoreQuery)
      {
        System.Console.WriteLine($"Nome: {item.Name}, Email: {item.Email}");
      }
    }

    public void LINQExpression()
    {
      var scoreQuery = Students.Select(s => s)
                                .OrderBy(s => s)
                                .ToList();

      foreach (var item in scoreQuery)
      {
        System.Console.WriteLine($"Nome: {item.Name}, Email: {item.Email}");
      }
    }

    public void LINQExpressionFilterByName(string name)
    {
      var query = Students.Where(s => s.Name.Contains(name)).ToList();

      foreach (var item in query)
      {
        System.Console.WriteLine($"Nome: {item.Name}, Email: {item.Email}");
      }
    }
  }
}