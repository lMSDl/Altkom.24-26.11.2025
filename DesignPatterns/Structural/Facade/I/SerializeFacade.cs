using System.Text.Json;

namespace DesignPatterns.Structural.Facade.I
{
    internal static class SerializeFacade
    {
        static JsonSerializerOptions Options { get; } = new()
        {
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
            IgnoreReadOnlyProperties = true,
        };

        public static string Serialize(object obj)
        {
            return JsonSerializer.Serialize(obj, Options);
        }

        public static T? Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, Options);
        }
    }
}
