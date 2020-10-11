namespace DataTier
{
    public class Client
    {
        public Client(string FirstName, string LastName, string PhoneNr)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNr = PhoneNr;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNr { get; set; }
    }
}
