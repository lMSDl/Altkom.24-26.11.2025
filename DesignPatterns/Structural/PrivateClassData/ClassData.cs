namespace DesignPatterns.Structural.PrivateClassData
{
    internal class ClassData
    {
        //private readonly string _someString;
        //public int SomeInt { get; }

        private PrivateData _privateData;

        public ClassData(string someString, int someInt)
        {
            //_someString = someString;
            //SomeInt = someInt;
            _privateData = new PrivateData(someString, someInt);
        }


        public void DoSth()
        {
            //_someString = ""; // Compilation error: Cannot assign to '_someString' because it is readonly
            //SomeInt = 5; // Compilation error: Property or indexer 'ClassData.SomeInt' cannot be assigned to -- it is read only
            
            _privateData.GetSomeString();
            _privateData.GetSomeInt();
        }
    }
}
