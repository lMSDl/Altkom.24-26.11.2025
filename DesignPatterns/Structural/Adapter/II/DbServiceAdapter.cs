namespace DesignPatterns.Structural.Adapter.II
{
    internal class DbServiceAdapter : IPeopleService
    {
        private readonly DbService _dbService;
        public DbServiceAdapter(DbService dbService)
        {
            _dbService = dbService;
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = _dbService.Read();

            return people.Select(CovertToPerson).ToList();
        }

        private static Person CovertToPerson(DbPerson p)
        {
            return new Person
            {
                FullName = $"{p.FirstName} {p.LastName}",
                Age = DateTime.Now.Year - p.BirthDate.Year
            };
        }
    }
}
