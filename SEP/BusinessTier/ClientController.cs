using DataTier;
using System.Collections.Generic;

namespace BusinessTier
{
    public class ClientController
    {
        private static List<Client> clients = Seed.Clients;

        public ClientController()
        {
            
        }

        public void Create(string firstName, string lastName, string phoneNr)
        {
            Client client = new Client(firstName, lastName,phoneNr);
            clients.Add(client);
        }

        public List<Client> Clients { get {return clients; }}
    }
}
