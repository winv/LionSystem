using LionServer.Domain.Interfaces;
using LionServer.Domain.Models;
using LionServer.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LionServer.Infra.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(LionContext context)
            : base(context)
        {

        }

        public Customer GetByEmail(string email)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Email == email);
        }
    }
}
