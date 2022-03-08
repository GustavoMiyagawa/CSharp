namespace Desafio3.Model
{
    public class Lesson
    {
        public string Name { get; set; }
        public string Data { get; set; }
        // public List<Student> Students { get; set; }
        public Student Student { get; set; }
        public Facilitator Facilitator { get; set; }
        public Classroom Classroom { get; set; }
    }
}