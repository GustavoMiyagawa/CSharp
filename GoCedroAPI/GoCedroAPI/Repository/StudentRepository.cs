using GoCedroAPI.Domains;

namespace GoCedroAPI.Repository
{
    public class StudentRepository
    {
        public List<Student> Students;

        public StudentRepository()
        {
            Students = new List<Student>();
        }

        public void SaveStudent(Student student)
        {
            Students.Add(student);
            Console.WriteLine("Usuário cadastrado");
        }

        public IEnumerable<Student> GetAll()
        {
            foreach (var item in Students)
            {
                Console.WriteLine(item);
            }
            return Students;
        }
    }
}
