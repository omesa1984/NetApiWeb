using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public interface IAddressRepo
    {
        bool SaveChanges();

        IEnumerable<Address> GetAllAddress();
        Address GetAddressById(int Id);

        void CreateAddress(Address address);

        void UpdateAddress(Address address);

        void DeleteAddress(Address address);
    }
}
