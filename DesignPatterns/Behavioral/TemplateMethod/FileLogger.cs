namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileLogger : Logger<string, FileService>
    {
        protected override void WriteLogMessage(FileService service, string item)
        {
            service.Write(item);
        }

        protected override string CreateItem(string message)
        {
            Console.WriteLine("Serializing message");
            return message;
        }

        protected override FileService GetService()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }
    }
}
