using api.Models;

namespace api.Repository.interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(string id);
        Customer CreateCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        bool DeleteCustomer(string id);
    }
}
