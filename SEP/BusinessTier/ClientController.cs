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

        public void Create(string FirstName, string LastName, string PhoneNr)
        {
            Client client = new Client(FirstName, LastName, PhoneNr);
            clients.Add(client);
        }

        public Client Find(string FirstName)
        {
            return clients.Find(client => client.FirstName.Equals(FirstName));
        }
    }
}
