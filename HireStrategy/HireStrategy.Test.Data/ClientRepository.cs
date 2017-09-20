using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireStrategy.Test.Data
{
    public class ClientRepository
    {
        List<Client> clients;
        public ClientRepository()
        {
            clients = new List<Client>();
            clients.Add(new Client() { ClientId = 1, Name = "Client 1" });
            clients.Add(new Client() { ClientId = 2, Name = "Client 2" });
            clients.Add(new Client() { ClientId = 3, Name = "Client 3" });

        }
        public List<Client> GetAll()
        {
            return clients;
        }
        public Client GetById(int id)
        {
            return clients.Where(z => z.ClientId == id).FirstOrDefault();
        }
    }
}
