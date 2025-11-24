namespace SOLID
{

    /*public interface IFormatter
    {
        void ToPdf();
        void ToExcel();
    }*/

    public interface IPdfFormatter
    {
        void ToPdf();
    }

    public interface IExcelFormatter
    {
        void ToExcel();
    }

    public class Report : IPdfFormatter, IExcelFormatter
    {
        public void ToPdf()
        {
            Console.WriteLine("Report to PDF");
        }
        public void ToExcel()
        {
            Console.WriteLine("Report to Excel");
        }
    }

    public class Poem : IPdfFormatter
    {
        public void ToPdf()
        {
            Console.WriteLine("Poem to PDF");
        }
        /*public void ToExcel()
        {
            
        }*/
    }
}
