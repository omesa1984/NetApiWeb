using AvaliacaoNetApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Data
{
    public interface IAddressRepo
    {
        IEnumerable<Address> GetAllAddress();
        Address GetAddressById(int Id);
    }
}
