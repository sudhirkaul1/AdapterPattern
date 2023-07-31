using AdapterDesignPatternApp.LegacySystem.Models;
using System.Text.Json;
namespace AdapterDesignPatternApp.LegacySystem.BusinessLogic;

public class CustomerManager
{
    private List<Customer> customerList = new List<Customer>();
    public CustomerManager()
    {
        customerList.Add(new Customer 
        {
            Id = 123,
            Name = "Adapter",
            Address = "VSCODE",
            Contact = "123459"
        });
    }

    public string GetData()
    {
        return JsonSerializer.Serialize(customerList);
    }

}