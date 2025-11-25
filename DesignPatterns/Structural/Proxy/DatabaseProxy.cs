namespace DesignPatterns.Structural.Proxy
{
    internal class DatabaseProxy : IDatabase
    {
        private IDatabase _database;
        public DatabaseProxy(IDatabase database)
        {
            _database = database;
        }
        private Func<IDatabase>? _openConnection;
        public DatabaseProxy(Func<IDatabase> openConnection)
        {
            _openConnection = openConnection;
        }

        public void Dispose()
        {
            _database.Dispose();
            _database = null;
        }


        public const int MAX_REQUESTS = 4;
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(MAX_REQUESTS);
        public async Task RequestAsync(int @int)
        {
            await _semaphore.WaitAsync();

            if (_database is null)
            {
                if (_openConnection is null)
                {
                    _semaphore.Release();
                    return;
                }
                else
                {
                    _database = _openConnection();
                }
            }

            await _database.RequestAsync(@int);

            _semaphore.Release();

            if (_semaphore.CurrentCount == MAX_REQUESTS && _openConnection != null)
            {
                Dispose();
            }
        }
    }
}
