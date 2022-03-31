using System.Text.Json.Serialization;

namespace RemoteClassProject.Domain.Entities.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
        STUDENT,
        FACILITATOR
    }
}