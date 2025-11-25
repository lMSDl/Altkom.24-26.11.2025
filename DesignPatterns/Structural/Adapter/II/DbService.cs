namespace DesignPatterns.Structural.Adapter.II
{
    internal class DbService
    {
        private IEnumerable<DbPerson> _people = [];

        public IEnumerable<DbPerson> Read()
        {
            return _people.ToList();
        }
    }
}
