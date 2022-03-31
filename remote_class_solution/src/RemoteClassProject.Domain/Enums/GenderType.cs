using System.Text.Json.Serialization;

namespace RemoteClassProject.Domain.Entities.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GenderType
    {
        MALE,
        FEMALE,
        OTHERS
    }
}