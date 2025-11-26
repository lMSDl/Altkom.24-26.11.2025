namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class EmailLogger : Logger<Email, IDisposable>
    {
        protected override void WriteLogMessage(IDisposable service, Email item)
        {
            Console.WriteLine("Sending Email with Log Message : " + item.Content);
        }

        protected override Email CreateItem(string message)
        {
            return new Email { Content = message };
        }

        protected override IDisposable GetService()
        {
            return default;
        }

        protected override void CloseService(IDisposable service)
        {
            
        }
    }
}
