namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileLogger
    {
        public void Log(object message)
        {
            var messageToLog = SerializeMessage(message);
            var service = OpenFile();
            WriteLogMessage(service, messageToLog);
            CloseFile(service);
        }
        private string SerializeMessage(object message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
        private FileService OpenFile()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }
        private void WriteLogMessage(FileService service, string message)
        {
            service.Write(message);
        }
        private void CloseFile(FileService service)
        {
            service.Dispose();
        }
    }
}
