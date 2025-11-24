namespace SOLID
{

    public class Invoice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        public decimal CalculateTax()
        {
            return Amount * 0.23m;
        }
    }

    public class InvoiceRepository
    {
        // Odpowiedzialność: zapis do pliku
        public void Save(Invoice invoice, string path)
        {
            File.WriteAllText(path, $"Invoice {invoice.Id}, Amount: {invoice.Amount}");
        }
    }

    public class EmailService
    {
        // Odpowiedzialność: wysyłanie e-maila
        public void SendEmail(Invoice invoice, string email)
        {
            Console.WriteLine($"Sending invoice {invoice.Id} to {email}");
        }
    }


    /*public class Invoice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        // Odpowiedzialność: logika biznesowa faktury
        public decimal CalculateTax()
        {
            return Amount * 0.23m;
        }

        // Odpowiedzialność: zapis do pliku
        public void SaveToFile(string path)
        {
            File.WriteAllText(path, $"Invoice {Id}, Amount: {Amount}");
        }

        // Odpowiedzialność: wysyłanie e-maila
        public void SendEmail(string email)
        {
            Console.WriteLine($"Sending invoice {Id} to {email}");
        }
    }*/
}
