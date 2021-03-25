using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Models
{
    public class Phone
    {
        //[Key]
        public int Id { get; set; }

        //[Required]
        public String Tipo { get; set; }

        //[Required]
        //[MaxLength(18)]
        public String Numero { get; set; }
    }
}
