using System.Text.Json.Serialization;

namespace SWI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperationType
    {
        Add,
        Sub,
        Mul,
        Sqrt
    }
}
