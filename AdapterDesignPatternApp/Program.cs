// See https://aka.ms/new-console-template for more information
using AdapterDesignPatternApp.Adapter;

Console.WriteLine("Hello, World!");

ICustomerAdapter customer = new CustomerAdapter();

var custList = customer.GetCustomerData();

foreach(var cust in custList)
{
    Console.WriteLine(cust.Id );
    Console.WriteLine(cust.CustomerName);
    Console.WriteLine(cust.CustomerAddress);
    Console.WriteLine(cust.Mobile);
}

Console.ReadKey();