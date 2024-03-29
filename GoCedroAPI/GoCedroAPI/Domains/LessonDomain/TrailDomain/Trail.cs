﻿namespace GoCedroAPI.Domains.LessonDomain.TrailDomain
{
    public class Trail
    {
        public Guid TrailID { get; private set; }
        public string Detail { get; private set; }
        public List<string> Topics { get; private set; }
        public TrailType TrailType { get; private set; }
    }
}
