namespace SOLID
{
    public interface IMessage
    {
        void Send();
    }

    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            Console.WriteLine($"Sending SMS to {PhoneNumber}: {Content}");
        }
    }

    public class MMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public byte[] Content { get; set; }

        public void Send()
        {
            Console.WriteLine($"Sending MMS to {PhoneNumber}: {Content.Length} bytes");
        }
    }

    public class Email : IMessage
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void Send()
        {
            Console.WriteLine($"Sending Email to {EmailAddress}: {Subject} - {Content}");
        }
    }


    public class Messenger
    {
        public IEnumerable<IMessage> Messages { get; set; }

        public Messenger(IEnumerable<IMessage> messages)
        {
            Messages = messages;
        }

        public void SendMessages(IEnumerable<IMessage> messages)
        {
            Messages = messages;
            SendMessages();
        }

        public void SendMessages()
        {
            foreach (var message in Messages)
            {
                message.Send();
            }
        }

    }
}
