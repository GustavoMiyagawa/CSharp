using Desafio3.Model;
using Desafio3.Controller;

namespace Desafio3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Student student = new Student ("José", "josé@cedrotech.com");
      // Student student2 = new Student ("Maria", "maria@cedrotech.com");

      // Facilitator facilitator = new Facilitator ("Antônio", "antonio@cedrotech.com");

      // Classroom classroom = new Classroom ("Room 1", "https://localhost:3000/room1");

      // Lesson lesson = new Lesson { Name = "Estrutura de Dados", Data = "25/02/2022", Facilitator = facilitator, Classroom = classroom};
      // lesson.Students.Add(student);
      // lesson.Students.Add(student2);

      // Console.WriteLine(lesson.Facilitator.Name);

      // LessonController lesson = new LessonController();
      // var result = lesson.CreateLesson("Estrutura de Dados", "25/02/2022", "Gustavo", "gustavo.santos@cedrotech.com", "Antônio", "antonio.nunes@cedrotech.com", "Aula 4", "https://cedrogotechtalent/aula4");
      // System.Console.WriteLine(result);

      StudentRepository studentRepository = new StudentRepository();
      studentRepository.saveStudent("Gus", "guscedro");
      studentRepository.saveStudent("Gustavo Miyagawa", "miyagawa@cedro");
      studentRepository.saveStudent("douglas", "douglas@cedro");
      studentRepository.saveStudent("Antônio", "antoni@cedro");

      // studentRepository.Imprimir();

      studentRepository.GetAll();

      // studentRepository.FilterByName("Gustavo");

      // studentRepository.LINQExpression();

      // studentRepository.LINQExpressionFilterByName("Gustavo");


      // studentRepository.getStudents();

      Console.ReadLine();
    }
  }
}