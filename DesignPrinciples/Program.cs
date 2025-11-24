using DesignPrinciples;

var service = new PaymentService();

var custmerId = 1;

service.Fund(custmerId, 500);
if (service.Charge(custmerId, 100))
{
    Console.WriteLine($"Customer {custmerId} charged. Actual balace: {service.GetBalance(custmerId)}");
}
else
{
    Console.WriteLine($"Customer {custmerId} cannot be charged. Actual balace: {service.GetBalance(custmerId)}");
}