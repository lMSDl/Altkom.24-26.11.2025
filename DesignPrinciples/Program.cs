using DesignPrinciples;

var paymentService = new PaymentService();
var customersService = new CustomersService();

var custmerId = 1;

var customer = customersService.FindCustomerById(custmerId);

paymentService.Fund(customer, 500);
if (paymentService.Charge(customer, 100))
{
    Console.WriteLine($"Customer {custmerId} charged. Actual balace: {customer.Account.GetBalance()}");
}
else
{
    Console.WriteLine($"Customer {custmerId} cannot be charged. Actual balace: {customer.Account.GetBalance()}");
}