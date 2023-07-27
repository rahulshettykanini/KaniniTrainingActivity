using Microsoft.AspNetCore.Mvc;
using transport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace transport.services.Customerservice
{
    public class Customerservice :CustomerInterface
    {

        private readonly ShipsContext _context;

        public Customerservice(ShipsContext context)
        {
            _context = context;
        }
        public async Task<List<Customer>> GetCustomers()
        {
            var clients = await _context.Customers.ToListAsync();
            return clients;

        }

        public async Task<Customer?> GetCustomer(string id)
        {
            var client = await _context.Customers.FindAsync(id);

            return client;
        }

        public async Task<Customer?> PutCustomer(string id, Customer customer)
        {

            var clients = await _context.Customers.FindAsync(id);

            clients.Product = customer.Product;
            clients.Weight = customer.Weight;
            clients.Source = customer.Source;
            clients.Destination = customer.Destination;
            clients.Ship = customer.Ship;
            await _context.SaveChangesAsync();
            return clients;

        }

        public async Task<List<Customer>> PostCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return await _context.Customers.ToListAsync();
        }

        public async Task<List<Customer>> DeleteCustomer(string id)
        {
            var clients = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(clients);
            await _context.SaveChangesAsync();
            return await _context.Customers.ToListAsync();
        }


    }
}
