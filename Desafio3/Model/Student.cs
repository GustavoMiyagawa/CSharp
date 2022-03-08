namespace Desafio3.Model
{
  public class Student : User, IComparable
  {
    public Student(string name, string email) : base(name, email)
    {
    }

    public int CompareTo(object obj)
    {
      Student that = obj as Student;
      return this.Name.CompareTo(that.Name);
    }
  }
}