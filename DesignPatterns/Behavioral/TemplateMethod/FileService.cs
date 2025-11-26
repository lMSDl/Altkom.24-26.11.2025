namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileService : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Close File.");
        }

        public void Write(string @string)
        {
            Console.WriteLine("Appending Log message to file : " + @string);
        }
    }
}