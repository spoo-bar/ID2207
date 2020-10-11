using DataTier;
using System.Collections.Generic;

namespace BusinessTier
{
    public class ClientController
    {
        private static List<Client> clients = new List<Client>();

        public ClientController()
        {
            
        }

        public void Create(string firstName, string lastName, string phoneNr)
        {
            Client client = new Client(firstName, lastName,phoneNr);
            clients.Add(client);
        }

        public Client Find(string firstName)
        {
            return clients.Find(client => client.FirstName.Equals(firstName));
        }

        public List<Client> Clients { get {return clients; }}
    }
}
