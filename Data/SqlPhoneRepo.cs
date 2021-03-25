using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public class SqlPhoneRepo : IPhoneRepo
    {
        private readonly AvaliacaoDbContext _context;

        public SqlPhoneRepo(AvaliacaoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Phone> GetAllPhones()
        {
            return _context.Phones.ToList();
        }

        public Phone GetPhoneById(int Id)
        {
            return _context.Phones.FirstOrDefault(p => p.Id == Id);
        }
    }
}
