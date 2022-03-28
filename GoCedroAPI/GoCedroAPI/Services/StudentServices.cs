using GoCedroAPI.Domains;
using GoCedroAPI.Repository;

namespace GoCedroAPI.Services
{
    public class StudentServices
    {
        public StudentRepository studentRepository;

        public StudentServices()
        {
            studentRepository = new StudentRepository();
        }

        public void CreateStudent(Student student)
        {
            studentRepository.SaveStudent(student);
        }

        public IEnumerable<Student> GetAll()
        {
            var students = studentRepository.GetAll().Select(s => s).OrderBy(s => s).ToList();

            return students;
        }

        public IEnumerable<Student> GetStudentByName(string name)
        {
            var students = studentRepository.GetAll().Where(s => s.Name.Contains(name)).ToList();

            return students;
        }
    }
}
