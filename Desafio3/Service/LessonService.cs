using Desafio3.Model;

namespace Desafio3.Service
{
  class LessonService
  {
    // public Lesson Lesson;
    // public LessonService()
    // {
    //   Lesson = new Lesson();
    // }

    public string CreateLesson(string name, string data, string studentName, string studentEmail, string facilitatorName, string facilitatorEmail, string classroomName, string classroomLink)
    {
      Student student = new Student(studentName, studentEmail);
      Facilitator facilitator = new Facilitator(facilitatorName, facilitatorEmail);
      Classroom classroom = new Classroom(classroomName, classroomLink);

      Lesson lesson = new Lesson { Name = name, Data = data, Student = student, Facilitator = facilitator, Classroom = classroom};

      var lessonName = lesson.Name;
      var lessonData = lesson.Data;
      var lessonStudentName = lesson.Student.Name;
      var lessonStudentEmail = lesson.Student.Email;

      return $"Nome da aula: {lessonName}, Data da Aula: {lessonData}, Dados do estudante: {lessonStudentName}, {lessonStudentEmail}";
    }

    
  }
}