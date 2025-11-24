namespace DesignPatterns.Creational.AbstractFactory
{
    internal interface ISedanFactory
    {
        ISedan CreateSedan(string segment);
    }
}
