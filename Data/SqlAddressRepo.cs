using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public class SqlAddressRepo : IAddressRepo
    {
        private readonly AvaliacaoDbContext _context;

        public SqlAddressRepo(AvaliacaoDbContext context)
        {
            _context = context;
        }

        public Address GetAddressById(int Id)
        {
            return _context.Address.FirstOrDefault(p => p.Id == Id);
        }

        public IEnumerable<Address> GetAllAddress()
        {
            return _context.Address.ToList();
        }
    }
}
