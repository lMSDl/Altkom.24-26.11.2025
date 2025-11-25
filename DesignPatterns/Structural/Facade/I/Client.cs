using System.Text.Json;

namespace DesignPatterns.Structural.Facade.I
{
    internal class Client
    {
        public static void Execute()
        {
            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(1990, 1, 1),
                Email = string.Empty,
                PESEL = null
            };

            /*JsonSerializerOptions options = new()
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
                IgnoreReadOnlyProperties = true,
            };

            var json = JsonSerializer.Serialize(person, options);*/

            var json = SerializeFacade.Serialize(person);

            Send(json);
        }

        private static void Send(string json)
        {
            Console.WriteLine(json);
        }
    }
}
