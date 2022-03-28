namespace GoCedroAPI.Domains.LessonDomain
{
    public class ClassRoom
    {
        public string Link { get; private set; }
        public List<Facilitator> Responsible { get; private set; }
    }
}
