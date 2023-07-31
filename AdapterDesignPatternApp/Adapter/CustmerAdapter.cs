using AdapterDesignPatternApp.LegacySystem.BusinessLogic;
using AdapterDesignPatternApp.NewSystem;
using System.Text.Json;
using AdapterDesignPatternApp.LegacySystem.Models;
namespace AdapterDesignPatternApp.Adapter;
public class CustomerAdapter : CustomerManager, ICustomerAdapter
{
    public IEnumerable<CustomerDto> GetCustomerData()
    {
        var data = base.GetData();
        var customerList = JsonSerializer.Deserialize<IEnumerable<Customer>>(data);

        return customerList.Select(x => new CustomerDto
        {
            Id = x.Id,
            CustomerName = x.Name,
            CustomerAddress = x.Address,
            Mobile = x.Contact
        });
    }
}