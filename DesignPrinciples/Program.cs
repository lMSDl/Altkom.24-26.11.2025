using DesignPrinciples;

var paymentService = new PaymentService();
var customersService = new CustomersService();

var custmerId = 1;

var customer = customersService.FindCustomerById(custmerId);
var account = customer?.Account;

paymentService.Fund(account, 500);
if (paymentService.Charge(account, 100))
{
    Console.WriteLine($"Customer {custmerId} charged. Actual balace: {account.GetBalance()}");
}
else
{
    Console.WriteLine($"Customer {custmerId} cannot be charged. Actual balace: {account.GetBalance()}");
}