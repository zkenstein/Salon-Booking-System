using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Salon.Models;

namespace Salon.Services
{
    public class DataService : IDataService
    {
        private static List<Client> _clients;

           static DataService()
        {
            _clients = new List<Models.Client>
            {
                new Client { ClientId = 1, Name="Joe Bonifacio", Dob=new DateTime(1982,9,24), Contact= ContactType.MOBILE },
                new Client { ClientId = 2, Name="Silvia Bonifacio", Dob=new DateTime(1984,10,23), Contact= ContactType.MOBILE },
                new Client { ClientId = 3, Name="Josephine Bonifacio", Dob=new DateTime(1988,1,21), Contact= ContactType.MOBILE },
                new Client { ClientId = 4, Name="Rosa Bonifacio", Dob=new DateTime(1968,9,19), Contact= ContactType.MOBILE },
                new Client { ClientId = 5, Name="Frank Bonifacio", Dob=new DateTime(1962,5,1), Contact= ContactType.MOBILE }

            };
        }

        public void addClient(Client c)
        {
            int id = _clients.Max(client => client.ClientId);
            id++;
            c.ClientId = id;
            _clients.Add(c);
            
        }



        public IEnumerable<Client> getAll()
        {
            return _clients;
        }

        public Client getClient(int id)
        {
            Client client = _clients.FirstOrDefault(c => c.ClientId == id);
            return client;
        }

        public void updateClient()
        {
            
        }
    }
}
