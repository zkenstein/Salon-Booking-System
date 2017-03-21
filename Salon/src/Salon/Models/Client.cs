using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public ContactType Contact { get; set; }
    }

    public enum ContactType
    {
        MOBILE,
        SMS,
        EMAIL
    } 
}
