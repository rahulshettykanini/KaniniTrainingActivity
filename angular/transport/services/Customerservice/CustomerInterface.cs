using transport.Models;

namespace transport.services.Customerservice
{
    public interface CustomerInterface
    {

        public Task<List<Customer>> GetCustomers();
        public Task<Customer?> GetCustomer(string id);
        public Task<Customer?> PutCustomer(string id, Customer customer);

        public Task<List<Customer>> PostCustomer(Customer customer);

        public Task<List<Customer?>> DeleteCustomer(string id);



    }
}
