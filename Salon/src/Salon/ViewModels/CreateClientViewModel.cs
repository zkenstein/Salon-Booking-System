using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salon.Models;
using System.ComponentModel.DataAnnotations;

namespace Salon.ViewModels
{
    public class CreateClientViewModel
    {
        [Required, MinLength(2)]
        public string Name { get; set; }

        public ContactType Contact { get; set; }

        [Required]
        public DateTime Dob { get; set; }
    }
}
