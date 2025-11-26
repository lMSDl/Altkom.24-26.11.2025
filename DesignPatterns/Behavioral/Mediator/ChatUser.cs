namespace DesignPatterns.Behavioral.Mediator
{
    internal class ChatUser : ChatMemeber
    {
        public override void Receive(string from, string message, bool isPrivate)
        {
            Console.WriteLine(isPrivate
                ? $"{from} (Private): {message}"
                : $"{from}: {message}");
        }
    }
}
