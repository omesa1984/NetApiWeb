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

        public void CreateAddress(Address add)
        {
            if (add == null)
            {
                throw new ArgumentNullException(nameof(add));
            }

            _context.Address.Add(add);
        }

        public void DeleteAddress(Address address)
        {
            throw new NotImplementedException();
        }

        public Address GetAddressById(int Id)
        {
            return _context.Address.FirstOrDefault(p => p.Id == Id);
        }

        public IEnumerable<Address> GetAllAddress()
        {
            return _context.Address.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateAddress(Address address)
        {
            //Nothing
        }
    }
}
