namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class DatabaseLogger : Logger<DbLog, DatabaseService>
    {
        protected override string PrepareMessage(string message)
        {
            return message;
        }

        protected override void WriteLogMessage(DatabaseService service, DbLog item)
        {
            service.Insert(item);
        }

        protected override DbLog CreateItem(string message)
        {
            Console.WriteLine("Serializing message");
            return new DbLog { DateTime = DateTime.Now, Message = message };
        }

        protected override DatabaseService GetService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DatabaseService();
        }
    }
}
