using Desafio3.Service;
using Desafio3.Model;

namespace Desafio3.Controller
{
  class LessonController
  {
    public LessonService Service;

    public LessonController()
    {
      Service = new LessonService();
    }

    public string CreateLesson(string name, string data, string studentName, string studentEmail, string facilitatorName, string facilitatorEmail, string classroomName, string classroomLink)
    {
      // var result = Service.CreateLesson(name, data, studentName, studentEmail, facilitatorName, facilitatorEmail, classroomName, classroomLink);

      return "result";
    }

    // public Lesson GetLesson()
    // {
    //   return 
    // }
  }
}