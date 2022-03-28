using GoCedroAPI.Domains.LessonDomain.TrailDomain;

namespace GoCedroAPI.Domains
{
    public class Challenge
    {
        public Guid ChallengeID { get; private set; }
        public string Detail { get; private set; }
        public TrailType TrailType { get; private set; }
        public Trail Trail { get; private set; }
        public DateTime DtStart { get; private set; }
        public DateTime DtEnd { get; private set; }
        public Facilitator Facilitator { get; private set; }
    }
}
