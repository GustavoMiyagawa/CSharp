namespace Desafio3.Model
{
  public class Student : User, IComparable
  {
    public Student(string name, string email, DateTime dtBirth, int age) : base(name, email, dtBirth, age)
    {
    }

    public int CompareTo(object obj)
    {
      Student that = obj as Student;
      return this.Name.CompareTo(that.Name);
    }
  }
}