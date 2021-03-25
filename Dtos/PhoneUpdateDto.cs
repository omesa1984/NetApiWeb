using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoNetApiWeb.Dtos
{
    public class PhoneUpdateDto
    {
        [Required]
        public String Tipo { get; set; }

        [Required]
        [MaxLength(18)]
        public String Numero { get; set; }
    }
}
