using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Models
{
    public class People
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        [MaxLength(14)]
        public String Cpf { get; set; }

        [Required]
        [MaxLength(10)]
        public String Rg { get; set; }
        
        public Phone Phone { get; set; }

        public int Phone_People_Id { get; set; }

        public Address Address { get; set; }

        public int Address_People_Id { get; set; }
    }
}
