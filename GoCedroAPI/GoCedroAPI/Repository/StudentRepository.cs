using GoCedroAPI.Domains;

namespace GoCedroAPI.Repository
{
    public class StudentRepository
    {
        private static List<Student> Students = new List<Student>();

        public void SaveStudent(Student student)
        {
            Students.Add(student);
        }

        public List<Student> GetAll()
        {
            return Students;
        }
    }
}
