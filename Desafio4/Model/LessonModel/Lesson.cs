using Desafio4.Model.LessonModel.TrailModel;

namespace Desafio4.Model.LessonModel
{
    public class Lesson
    {
        public Guid ClassRoomID { get; private set; }
        public DateTime Time { get; private set; }
        public Trail Theme { get; private set; }
    }
}