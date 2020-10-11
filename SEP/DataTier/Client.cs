namespace DataTier
{
    public class Client
    {
        public Client(string firstName, string lastName, string phoneNr)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNr = phoneNr;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNr { get; set; }
    }
}
