using Desafio3.Service;

namespace StudentController.Controller
{
  public class StudentController
  {
    public void getNameController(string name)
    {
      StudentService studentService = new StudentService();

      studentService.getStudentName(name);
    }
  }
}