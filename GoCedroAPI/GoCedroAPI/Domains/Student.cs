using GoCedroAPI.Domains.UserDomain;

namespace GoCedroAPI.Domains
{
    public class Student : User
    {
        public Guid StudentID { get; private set; }
        public Student(string name) : base(name)
        {
        }
    }
}
