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

        public void CreatePhone(Phone pho)
        {
            if(pho == null)
            {
                throw new ArgumentNullException(nameof(pho));
            }

            _context.Phones.Add(pho);
        }

        public IEnumerable<Phone> GetAllPhones()
        {
            return _context.Phones.ToList();
        }

        public Phone GetPhoneById(int Id)
        {
            return _context.Phones.FirstOrDefault(p => p.Id == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
