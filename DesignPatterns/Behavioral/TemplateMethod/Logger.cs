namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal abstract class Logger<T, TService> where TService : IDisposable
    {

        public void Log(string message)
        {
            message = PrepareMessage(message);
            TService service = GetService();
            T item = CreateItem(message);
            WriteLogMessage(service, item);
            CloseService(service);
        }

        protected virtual void CloseService(TService service)
        {
            service.Dispose();
        }

        protected abstract void WriteLogMessage(TService service, T item);
        protected abstract T CreateItem(string message);
        protected abstract TService GetService();

        protected virtual string PrepareMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return $"{DateTime.Now}: {message}";
        }
    }
}
