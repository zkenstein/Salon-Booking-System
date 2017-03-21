using Salon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.ViewModels
{
    public class UpdateClientViewModel
    {
        [Required,MinLength(2)]
        public string Name { get; set; }
        [Required]
        public string Dob { get; set; }
        public ContactType Contact { get; set; }
    }
}
