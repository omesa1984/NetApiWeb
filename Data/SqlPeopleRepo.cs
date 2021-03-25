using AvaliacaoNetApiWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public class SqlPeopleRepo : IPeopleRepo
    {
        private readonly AvaliacaoDbContext _context;

        public SqlPeopleRepo(AvaliacaoDbContext context)
        {
            _context = context;
        }

        public void CreatePeople(People peop)
        {
            if (peop == null)
            {
                throw new ArgumentNullException(nameof(peop));
            }

            _context.Peoples.Add(peop);
        }

        public IEnumerable<People> GetAllPeoples()
        {
            //return _context.Peoples.ToList();
            return _context.Peoples.Include("Phone").Include("Address").ToList();
        }

        public People GetPeopleById(int Id)
        {
            //return _context.Peoples.FirstOrDefault(p => p.Id == Id);
            return _context.Peoples.Include("Phone").Include("Address").FirstOrDefault(p => p.Id == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
