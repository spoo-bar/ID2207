using System.Collections.Generic;

namespace DataTier
{
    public class User
    {
        private List<User> _subordinates = new List<User>();

        public User(string email, string password, Roles role)
        {
            Email = email;
            Password = password;
            Role = role;
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public Roles Role { get; set; }

        public void AddSubordinate(User subordinate)
        {
            _subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(User subordinate)
        {
            _subordinates.Remove(subordinate);
        }

        public List<User> Subordinates { get => _subordinates; }

        public override string ToString()
        {
            return Email;
        }

        public enum Roles
        {
            AdministrationDepartmentManager,
            SeniorCustomerServiceOfficer,
            CustomerService,
            FinancialManager,
            ProductionManager,
            Photographer,
            GraphicDesigner,
            ServicesDepartmentManager,
            TopChef,
            SeniorWaitress,
            SeniorHRManager
        }
    }
}
