using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.Services
{
    public interface IDataService
    {
        IEnumerable<Client> getAll();

        Client getClient(int id);

        void addClient(Client c);

        void updateClient();
    }
}
