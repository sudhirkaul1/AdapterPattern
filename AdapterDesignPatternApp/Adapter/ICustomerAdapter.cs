using AdapterDesignPatternApp.NewSystem;

namespace AdapterDesignPatternApp.Adapter;
public interface ICustomerAdapter
{
    IEnumerable<CustomerDto> GetCustomerData();
}