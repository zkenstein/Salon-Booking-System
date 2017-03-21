using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salon.Models;
namespace Salon.ViewModels
{
    public class DetailsViewModel
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public ContactType Contact { get; set; }

    }
}
