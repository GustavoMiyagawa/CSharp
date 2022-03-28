using GoCedroAPI.Domains.LessonDomain.TrailDomain;

namespace GoCedroAPI.Domains.LessonDomain
{
    public class Lesson
    {
        public Guid ClassRoomID { get; private set; }
        public DateTime Time { get; private set; }
        public Trail Theme { get; private set; }
    }
}
