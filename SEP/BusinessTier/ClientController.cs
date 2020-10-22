using DataTier;
using System.Collections.Generic;

namespace BusinessTier
{
    public class ClientController
    {
        public void Create(string firstName, string lastName, string phoneNr)
        {
            Client client = new Client(firstName, lastName,phoneNr);
            Seed.clients.Add(client);
        }

        public List<Client> Clients { get {return Seed.clients; }}
    }
}
